import { Phone } from "./phone";
import { Mail } from "./mail";
import { Address } from "./address";

export class Contact {
    contactId: number
    name: string
    company:string
    phones: Phone[]
    mails: Mail[]
    addresses: Address[]
}

