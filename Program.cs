using System;
namespace MyTool
{
    class Program
{
        static int GetMarks()
        {
            Console.WriteLine("Enter the name of the unit");
            string unit = Console.ReadLine();
            Console.WriteLine("Enter the marks for " + unit);
            int mark=Convert.ToInt32( Console.ReadLine());

            return mark;
        }
        static void FinalGrade(int marks)
        {
            if (marks>=70 && marks <=100)
            {
                Console.WriteLine("Congratulations... you've got an A");
            }else if(marks>=60 && marks <= 69)
            {
                Console.WriteLine("Congratulations.... your mean grade is B");
            }else if(marks>=50 && marks <= 59)
            {
                Console.WriteLine("Your mean grade is C");
            }else if(marks>=40 && marks <=49) {

                Console.WriteLine("Your grade is D");
            }else if(marks>=0 && marks <= 39)
            {
                Console.WriteLine("Your grade is E");
            }
            else
            {
                Console.WriteLine("Please enter valid marks(0-100)");
            }
        }
    static void Main(string[] args)
    {FinalGrade(GetMarks()); 

    }
}
}
