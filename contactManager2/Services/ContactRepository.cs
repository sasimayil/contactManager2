using contactManager2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contactManager2.Services
{
    public class ContactRepository
    {
        private ContactDBContext db = new ContactDBContext();

        public Contacts[] GetAllContacts()
        {
            return new Contacts[]
            {
             new Contacts
             {
                  Id = 1,
                  Name = "Glenn"
             },
             new Contacts
             {
                  Id = 2,
                  Name = "Dan Roth"
             }
            };
        }

        public Contacts[] GetContacts()
        {
           var contacts = db.ContactList.ToList();
            var i = 0;
            Contacts[] ct = new Contacts[contacts.LongCount()];
            foreach (var contact in contacts)
            {
                ct[i] = new Contacts { Id = contact.Id , Name = contact.Name};
                i++;
            }

            return ct;
        }

    }
}