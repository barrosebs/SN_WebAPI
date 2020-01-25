import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-atletas',
  templateUrl: './atletas.component.html',
  styleUrls: ['./atletas.component.css']
})
export class AtletasComponent implements OnInit {


  _filtroLista: string;
  get filtroLista(): string {
    return this._filtroLista;
  }
  set filtroLista(value: string) {
    this._filtroLista = value;
    this.atletasFiltrados = this.filtroLista ? this.filtrarAtletas(this.filtroLista) : this.atletas;
  }

  atletasFiltrados: any = [];
  imagemLargura = 80;
  imagemMargen = 2;
  mostrarImagem = false;

  atletas: any = [];

  constructor( private http: HttpClient) { }

  ngOnInit() {
    this.getAtletas();
  }

  filtrarAtletas(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.atletas.filter(
      atleta => atleta.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  getAtletas() {
    this.atletas = this.http.get('http://localhost:5000/api/atleta').subscribe(
      response => {
        this.atletas = response;
      }, error => {
        console.log(error);
      }
    );
  }

  alterarImagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

}
