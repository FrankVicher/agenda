import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  testValues: string[] = [];
  constructor(private _service: Http) {

  }
  
  ngOnInit() {
    this._service.get('/api/values').subscribe(r => {
      this.testValues = r.json() as string[];
    });
  }
}
