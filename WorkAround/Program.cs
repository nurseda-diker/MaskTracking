// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
SelamVer();
SelamVer2();
Console.ReadLine();



 static void SelamVer()
{
    Console.WriteLine("hello");
}

void SelamVer2()
{
    Console.WriteLine("hello2");
}

Person person = new Person();
person.FirstName = "Nur";
person.LastName = "Diker";
person.DateOfBirth = 2000;
person.NationalIdentity = 123;

PttManager personManager = new PttManager(new PersonManager());
personManager.GiveMask(person);


