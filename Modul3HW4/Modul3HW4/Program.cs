using System.Linq;
namespace Modul3HW4
{
    internal class Program
    {
        public static void Main()
        {
            var task1 = new Task1();
            task1.CoverSumming(task1.Summing);
            var phonebook = new PhoneBook();
            phonebook.AddContact(new Contact() { Name = "edya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            phonebook.AddContact(new Contact() { Name = "/Pitya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            phonebook.AddContact(new Contact() { Name = "Petya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            phonebook.AddContact(new Contact() { Name = "Putya", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            var whereContact = phonebook.Contacts.Where(x => x.Name == "Petya");
            foreach (var contact in whereContact)
            {
                Console.WriteLine($"{contact.Name} {contact.Surname} {contact.PhoneNumber}");
            }

            var selectContact = phonebook.Contacts.Select(x => x.Surname == "ewfwrg");
            foreach (var check in selectContact)
            {
                Console.WriteLine(check);
            }

            var firstContact = phonebook.Contacts.FirstOrDefault(x => x.Name == "Petya");
            if (firstContact != null)
            {
                Console.WriteLine($"{firstContact.Name} {firstContact.Surname} {firstContact.PhoneNumber}");
            }

            var anyContact = phonebook.Contacts.Any(x => x.Name.ToLower() == "edya");
            Console.WriteLine(anyContact);

            var takeContacts = phonebook.Contacts.Take(2);
            foreach (var contact in takeContacts)
            {
                Console.WriteLine($"{contact.Name} {contact.Surname} {contact.PhoneNumber}");
            }

            var phonebook2 = new PhoneBook();
            phonebook2.AddContact(new Contact() { Name = "John", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            phonebook2.AddContact(new Contact() { Name = "Misha", Surname = "ewfwrg", PhoneNumber = "0324032457821" });
            var unionContacts = phonebook.Contacts.Union(phonebook2.Contacts);
            foreach (var contact in unionContacts)
            {
                Console.WriteLine($"{contact.Name} {contact.Surname} {contact.PhoneNumber}");
            }
        }
    }
}