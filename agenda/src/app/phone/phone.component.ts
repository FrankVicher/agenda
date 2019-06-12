import { Component, OnInit, Input } from '@angular/core';
import { Http } from '@angular/http';
import { Phone } from '../phone';

@Component({
  selector: 'app-phone',
  templateUrl: './phone.component.html',
  styleUrls: ['./phone.component.css']
})
export class PhoneComponent implements OnInit {

  @Input() phone: Phone = {
    phoneId: 0,
    number: '',
    phoneTypeId: 0
  }
  constructor(private _service: Http) { }

  phoneTypes: {}[] = [];
  ngOnInit() {
    this._service.get('/api/phonetypes').subscribe(r => {
      this.phoneTypes = r.json();
    });
  }
}
