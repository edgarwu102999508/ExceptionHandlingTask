using System;

namespace ExceptionHandlingTask
{
  class Program
  {
    static void Main(string[] args)
    {
      string roomNum;
      string name;
      int amountOfPerson;
      var dateEntered = new DateTime();
      var timeEntered = new DateTime();


      System.Console.WriteLine("Room Number: ");
      roomNum = Console.ReadLine();

      System.Console.WriteLine("Stduent Name: ");
      name = Console.ReadLine();

      System.Console.WriteLine("Amount of time person stayed in min: ");
      amountOfPerson = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Date entered: ");
      dateEntered = DateTime.Parse(Console.ReadLine());

      System.Console.WriteLine("Time entered: ");
      timeEntered = DateTime.Parse(Console.ReadLine());


      try
      {
        if (roomNum != "TD224" && roomNum != "AGSE111")
        {
          throw new Exception();
        }
      }
      catch
      {
        System.Console.WriteLine("Wrong room number.");
      }


      try
      {
        if (name != "John Doe" && name != "Jane Black")
        {
          throw new Exception();
        }
      }
      catch
      {
        System.Console.WriteLine("Wrong student name.");
      }

      try
      {
        if (amountOfPerson != 12 && amountOfPerson != 15 && amountOfPerson != 300)
        {
          throw new Exception();
        }
      }
      catch (FormatException e)
      {
        System.Console.WriteLine($"Input has to be interger {e.Message}");
      }
      catch (NullReferenceException e)
      {
        System.Console.WriteLine($"Object doesn't exist. {e.Message}");
      }
      catch (Exception e)
      {
        System.Console.WriteLine($"Wrong amount. {e.Message}");
      }

      try
      {
        if (dateEntered != new DateTime(2020, 8, 3) && dateEntered != new DateTime(2020, 23, 2))
        {
          throw new Exception();
        }
      }
      catch
      {
        System.Console.WriteLine("Wrong date.");
      }

      try
      {
        if (timeEntered != DateTime.Parse("14:30") && timeEntered != DateTime.Parse("8:20"))
        {
          throw new Exception();
        }
      }
      catch
      {
        System.Console.WriteLine("Wrong time.");
      }



    }
  }
}
