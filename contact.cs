using System;

namespace phonebook
{
 class contact
 {

  public contact(string name, string number)
  {
   Name = name;
   Number = number;
  }
  public string Name { get; set; }
  public string Number { get; set; }
 }

}