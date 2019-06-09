import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { ContactComponent } from './contact/contact.component';
import { PhoneComponent } from './phone/phone.component';
import { MailComponent } from './mail/mail.component';
import { AddressComponent } from './address/address.component';
import { ContactListComponent } from './contact-list/contact-list.component';

import { ContactService} from './contact.service';

@NgModule({
  declarations: [
    AppComponent,
    ContactComponent,
    PhoneComponent,
    PhoneComponent,
    MailComponent,
    AddressComponent,
    ContactListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [ContactService],
  bootstrap: [AppComponent]
})
export class AppModule { }
