import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hinos',
  templateUrl: './hinos.component.html',
  styleUrls: ['./hinos.component.scss']
})
export class HinosComponent implements OnInit {
public hinos : any = [];
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getHinos();
  }

  public getHinos(): void {
    this.http.get('https://localhost:5001/api/hinos').subscribe(
      response => this.hinos = response,
      error => console.log(error)
    );    
  }

}
