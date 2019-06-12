import { Phone } from "./phone";
import { Mail } from "./mail";
import { Address } from "./address";

export class Contact {
    constructor(){
      this.contactId=0
      this.name=''  
      this.company=''
      this.phones=[new Phone()]
      this.mails=[new Mail()]
      this.addresses=[new Address()]
    }
    contactId: number
    name: string
    company:string
    phones: Phone[]
    mails: Mail[]
    addresses: Address[]
}

