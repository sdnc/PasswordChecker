using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@$&%#/\\\"€*^><-_";

      Console.Write("Pick a password: ");
      string userPassword = Console.ReadLine();

      int score = 0;
      if (userPassword.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(userPassword, uppercase))
      {
        score++;
      }
      if (Tools.Contains(userPassword, lowercase))
      {
        score++;
      }
      if (Tools.Contains(userPassword, digits))
      {
        score++;
      }
      if (Tools.Contains(userPassword, specialChars))
      {
        score++;
      }

      switch (score)
      {
        case 4: case 5:
        Console.WriteLine(score + "/5 points. Great! Your password is extremely strong");
        break;
        case 3:
        Console.WriteLine("Yeah boiii! Password is strong!");
        break;
        case 2:
        Console.WriteLine("Meh.. password strength gets a medium");
        break;
        case 1:
        Console.WriteLine("That's a weak password bro..");
        break;
        default:
        Console.WriteLine("Damn Gina, this password meets none of the standards");
        break;
      }
      


    }
  }
}