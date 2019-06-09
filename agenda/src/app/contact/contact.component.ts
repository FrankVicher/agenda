import { Component, OnInit } from '@angular/core';
import { ContactService } from '../contact.service';
import {PhoneComponent} from '../phone/phone.component';
import {Phone} from '../phone';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  constructor(private contactService: ContactService) { }
  contactId: number = 0;
  name: string = '';
  company: string = '';
  phones: Phone[] = [{phoneId:0,
    phoneTypeId: 0,
    number:''
  }];
  mails: {}[] = [];
  addresses: {}[] = [];

  ngOnInit() {
  }

  add() {
    //alert('go');
    let contact = {
      name: this.name,
      company: this.company,
      phones: this.phones,
      mails: this.mails,
      addresses: this.addresses
    }
    this.contactService.createContact(contact);

  }

}
