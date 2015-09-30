﻿using contactManager2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using contactManager2.Services;

namespace contactManager2.Controllers
{
    public class ContactController : ApiController
    {

        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        public Contacts[] Get()
        {
            return contactRepository.GetContacts();
        }

    }
}
