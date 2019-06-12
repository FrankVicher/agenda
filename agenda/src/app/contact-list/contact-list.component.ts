import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'
import { ContactService } from '../contact.service';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.css']
})
export class ContactListComponent implements OnInit {

  constructor(private _service: Http) { }

  contacts: {}[] = [];

  ngOnInit() {
     this._service.get('/api/contacts').subscribe(r => {
       this.contacts = r.json();
     });
  }

}
