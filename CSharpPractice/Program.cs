// See https://aka.ms/new-console-template for more information

using CSharpPractice;

Person person = new ("Robert", "Walpole");

Console.WriteLine("Who was UK's first prime minister?");

string fullName = Console.ReadLine();

if(person.FullName == fullName)
{
    Console.WriteLine("Hey! You entered correct name! You won!");
  
}
else
{
    Console.WriteLine("Guessed wrong name... Try again!");
}



