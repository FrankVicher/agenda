import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-phone',
  templateUrl: './phone.component.html',
  styleUrls: ['./phone.component.css']
})
export class PhoneComponent implements OnInit {

  constructor(private _service: Http) { }

  number: string = '';
  phoneTypeId: number = 0;
  phoneTypes: {}[] = [];
  ngOnInit() {
    this._service.get('/api/phonetypes').subscribe(r => {
      this.phoneTypes = r.json();
    });
    
  }

}
