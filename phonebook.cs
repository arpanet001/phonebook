using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace phonebook
{


 class phonebook
 {

  private List<contact> _contacts { get; set; } = new List<contact>();

  private void DisplayContactDetails(contact contact)
  {
   Console.WriteLine($"Contact: {contact.Name} , {contact.Number}");
  }

  private void DisplayContactDetails(List<contact> contacts)
  {
   foreach (var contact in contacts)
   {
    DisplayContactDetails(contact);
   }

  }

  public void AddContact(contact contact)
  {
   _contacts.Add(contact);
  }


  public void DisplayContact(string number)
  {
   var contact = _contacts.FirstOrDefault(contact => contact.Number == number);
   if (contact == null)
   {
    Console.WriteLine("Contact not found");
   }
   else
   {
    DisplayContactDetails(contact);
   }
  }
  public void DisplayAllContacts()
  {
   DisplayContactDetails(_contacts);
  }
  public void DisplayMatchingContacts(string searchPhrase)
  {
   var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
   DisplayContactDetails(matchingContacts);


  }

 }
}