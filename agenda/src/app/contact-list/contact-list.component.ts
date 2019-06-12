import { Component, OnInit, Output } from '@angular/core';
import { Http } from '@angular/http';
import { ContactService } from '../contact.service';
import { Contact } from 'app/contact';
import { EventEmitter } from '@angular/common/src/facade/async';

@Component({
	selector: 'app-contact-list',
	templateUrl: './contact-list.component.html',
	styleUrls: [ './contact-list.component.css' ]
})
export class ContactListComponent implements OnInit {
	constructor(private _service: Http) {}
	@Output() selectedContact: EventEmitter<Contact> = new EventEmitter()
	contacts: Contact[] = []
  
  onSelectContact(contact: Contact) {    
		this.selectedContact.emit(contact)
	}

	ngOnInit() {
		this._service.get('/api/contacts').subscribe((r) => {
			this.contacts = r.json()
		});
	}
}
