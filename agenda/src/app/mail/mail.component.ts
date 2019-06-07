import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
  selector: 'app-mail',
  templateUrl: './mail.component.html',
  styleUrls: ['./mail.component.css']
})
export class MailComponent implements OnInit {

  constructor(private _service: Http) { }

  mailId: number = 0;
  mailAddress: string = "";
  mailTypeId: number = 0;

  mailTypes: {}[] = [];
  ngOnInit() {
    this._service.get('/api/mailtypes').subscribe(r => {
      this.mailTypes = r.json();
    });
  }

}
