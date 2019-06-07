import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {

  constructor() { }
  addressId: number = 0;
  street: string = '';
  number: string = '';
  city: string = '';
  state: string = '';
  country: string = '';
  code: string = '';

  ngOnInit() {
  }

}
