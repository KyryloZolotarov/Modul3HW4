using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}
