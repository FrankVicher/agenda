import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { findReadVarNames } from '@angular/compiler/src/output/output_ast';


@Injectable()
export class ContactService {

  constructor(private http: Http) { }

  getContacts() { }
  createContact(contact) {
    //alert('ok');
    // let contact : any = {
    //   contactId:0,
    //   name: 'fvm',
    //   company:'',
    //   phones:[],
    //   mails:[],
    //   addresses:[]
    // }
    this.http.post('/api/contacts', contact).subscribe(r=>{
      alert(r.statusText);
    }, e=>{
      alert(e.statusText);
    });
  }

}
