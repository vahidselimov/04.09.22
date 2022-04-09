using System;

namespace _09._04._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Id;
            int Age;
            int Point;

            do
            {

                Console.WriteLine("Please,Enter the age");
                 Age = Convert.ToInt32(Console.ReadLine());


            } while (Age < 0);
            do
            {
                Console.WriteLine("Please,Enter the point");
                 Point = Convert.ToInt32(Console.ReadLine());


            } while (Point<0||Point>100);
            do
            {
                Console.WriteLine("Please,Enter ID");
                Id = Convert.ToInt32(Console.ReadLine());
            } while (Id<0||Id>100);
            Student student = new Student("Vahid", "Selimov", Point, Id, Age);
          
            

           
            student.Showinfo();
        }
        
     

    }
}

