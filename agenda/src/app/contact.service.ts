import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { findReadVarNames } from '@angular/compiler/src/output/output_ast';
import { Contact} from './contact';


@Injectable()
export class ContactService {

  constructor(private http: Http) { }

  getContacts() { }
  createContact(contact) {   
    this.http.post('/api/contacts', contact).subscribe(r=>{
      alert(r.statusText);
    }, e=>{
      alert(e.statusText);
    });
  }
  updateContact(contact: Contact){
    this.http.put(`/api/contacts/${contact.contactId}`,contact).subscribe(r=>{
      alert(r.statusText)
    }, e=>{
      alert(e.statusText)
    })
  }

}
