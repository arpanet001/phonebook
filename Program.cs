using System;

namespace phonebook
{
 class Program
 {
  static void Main(string[] args)
  {
   Console.WriteLine("Console phonebook app");
   Console.WriteLine("Select operation");
   Console.WriteLine("1 Add contact");
   Console.WriteLine("2 Display Contact by number");
   Console.WriteLine("3 View all contacts");
   Console.WriteLine("4 Search for contatcs for a given name");
   Console.WriteLine("Press 'x' to exit");

   var userInput = Console.ReadLine();

   var phonebook = new phonebook();

   while (true)
   {
    switch (userInput)
    {
     case "1":
      Console.WriteLine("Contact name: ");
      var name = Console.ReadLine();

      Console.WriteLine("Contact number: ");
      var number = Console.ReadLine();

      var newContact = new contact(name, number);
      phonebook.AddContact(newContact);
      break;

     case "2":
      Console.WriteLine("Contact number to search : ");
      var searchnumber = Console.ReadLine();
      phonebook.DisplayContact(searchnumber);
      break;

     case "3":
      phonebook.DisplayAllContacts();
      break;

     case "4":
      Console.WriteLine("Name search phrase");
      var searchphrase = Console.ReadLine();
      phonebook.DisplayMatchingContacts(searchphrase);
      break;

     case "x":
      return;

     default:
      Console.WriteLine("Select valid operation");
      break;
    }

    Console.WriteLine("Select operation");
    userInput = Console.ReadLine();

   }

  }
 }
}
