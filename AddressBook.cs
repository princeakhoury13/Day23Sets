﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23Sets
{
    public class AddressBook
    {
        public Contacts[] ContactInfo { get; set; }
        public int NumberOfContacts { get; set; }

        public AddressBook()
        {
            ContactInfo = new Contacts[100];
            NumberOfContacts = 0;
        }

        //public void AddContact(Contacts contact)
        //{
          //  ContactInfo[NumberOfContacts] = contact;
            //NumberOfContacts++;
        //}

        public void AddContact(Contacts contact)
        {
            bool isDuplicate = ContactInfo.Any(existingContact => existingContact != null && existingContact.firstName == contact.firstName && existingContact.lastName == contact.lastName);

            if (!isDuplicate)
            {
                ContactInfo[NumberOfContacts] = contact;
                NumberOfContacts++;
                Console.WriteLine("Contact added successfully!");
            }
            else
            {
                Console.WriteLine("A contact with the same name already exists in the address book. Contact not added.");
            }
        }


        public void PrintContacts()
        {
            for (int i = 0; i < NumberOfContacts; i++)
            {
                Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
                    ContactInfo[i].firstName, ContactInfo[i].lastName, ContactInfo[i].country, ContactInfo[i].phoneNumber, ContactInfo[i].email);
            }
        }
    }
}
