import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  mode:string = 'list'
  constructor(private _service: Http) {

  }
  
  ngOnInit() {
    
  }
}
