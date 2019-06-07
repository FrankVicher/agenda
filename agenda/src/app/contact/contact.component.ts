import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  constructor() { }
  contactId: number = 0;
  name: string = '';
  company: string = '';
  phones: object[] = [];
  mails: object[] = [];
  addresses: object[] = [];
  
  ngOnInit() {
  }

}
