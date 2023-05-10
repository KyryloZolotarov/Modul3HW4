﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Contact? otherContact = obj as Contact;
            if (otherContact != null)
            {
                return this.Name.CompareTo(otherContact.Name);
            }
            else
            {
                throw new ArgumentException("Object is not a Contact");
            }
        }
    }
}
