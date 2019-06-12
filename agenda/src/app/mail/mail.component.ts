import { Component, OnInit, Input } from '@angular/core';
import { Http } from '@angular/http'
import { Mail } from '../mail';

@Component({
  selector: 'app-mail',
  templateUrl: './mail.component.html',
  styleUrls: ['./mail.component.css']
})
export class MailComponent implements OnInit {

  constructor(private _service: Http) { }
  @Input() mail: Mail = {
    mailId: 0,
    mailAddress: "",
    mailTypeId: 0
  }
  mailTypes: {}[] = [];
  ngOnInit() {
    this._service.get('/api/mailtypes').subscribe(r => {
      this.mailTypes = r.json();
    });
  }

}
