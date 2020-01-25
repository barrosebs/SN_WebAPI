import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-atletas',
  templateUrl: './atletas.component.html',
  styleUrls: ['./atletas.component.css']
})
export class AtletasComponent implements OnInit {

  atletas: any = [];

  constructor( private http: HttpClient) { }

  ngOnInit() {
    this.getAtletas();
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

}
