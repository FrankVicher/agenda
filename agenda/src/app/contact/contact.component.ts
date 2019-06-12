import { Component, OnInit, Input } from '@angular/core';
import { ContactService } from '../contact.service';
import { PhoneComponent } from '../phone/phone.component';
import{MailComponent} from '../mail/mail.component';
import { Phone } from '../phone';
import { Mail } from '../mail'
import {Address} from '../address'
import { Contact } from 'app/contact';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  constructor(private contactService: ContactService) { }
  @Input() contact: Contact = new Contact()
  ngOnInit() {
  }

  add() {    
    
    this.contactService.createContact(this.contact);

  }
  addPhone(){
    this.contact.phones.push(new Phone())
  }
  addMail(){
    this.contact.mails.push(new Mail())
  }
  addAddress(){
    this.contact.addresses.push(new Address())
  }

}
