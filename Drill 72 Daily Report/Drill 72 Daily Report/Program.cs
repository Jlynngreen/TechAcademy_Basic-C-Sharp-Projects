using System;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("the tech academy");
        Console.WriteLine("student daily report");

        Console.WriteLine("what course are you on?");
        string whatCourse = Console.ReadLine();
        

        Console.WriteLine("what page number?");
        string pageNumber = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageNumber);
        
        Console.WriteLine("Do you need help with anything?");
        bool isStudying = false;
        Console.WriteLine(isStudying);
       
     

        Console.WriteLine("Were there any positive experiences you'd like to share?");
        string posExper = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide?");
        string otherfeed = Console.ReadLine();

        Console.WriteLine("How Many Hours did you study today?");
        string hrStudy = Console.ReadLine();
        byte hoursWorked = 42;

        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly, Have a great day! This would be the end of the program.");
        Console.ReadLine();
    }

}

