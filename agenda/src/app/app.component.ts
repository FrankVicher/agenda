import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Contact } from './contact';
import {Phone} from './phone'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  mode:string = 'list'
  workingContact: Contact
  constructor(private _service: Http) {

  }
  onContactChanged(contact: Contact){
    this.workingContact=contact
    this.mode='edit'    
  }
  editMode(){    
    this.workingContact=new Contact()
    
    this.mode='edit'
  }
  ngOnInit() {
    
  }
}
