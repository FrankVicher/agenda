import { Component, OnInit, Input } from '@angular/core';
import{Address} from '../address';
@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {

  constructor() { }
  @Input() address: Address = {
  addressId: 0,
  street:'',
  number: '',
  city: '',
  state: '',
  country: '',
  code: ''
  }

  ngOnInit() {
  }

}
