using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Book book = new Book();
            book.title = "name1";
            book.author = "author1";
            book.pages = 400;*/

            Book book = new Book("name1", "author1", 400);
            Student student = new Student("naga","cse",3.0);
            Student student1 = new Student("raju", "ece", 4.0);
            Movie movie = new Movie("rrr","rajamouli",9);
            Movie movie1 = new Movie("kgf-2", "neel", 7);
            Super super = new Super();  
            Sub sub = new Sub();
            super.me1();
            super.me2();
            super.me3();
            sub.me5();  
            sub.me3();
            Console.WriteLine(movie.Rating);
            Console.WriteLine(movie1.Rating);
            movie1.Rating = 8;
            Console.WriteLine(movie1.Rating);
            Console.WriteLine(student.HasPassed());
            Console.WriteLine(student1.HasPassed());
            Console.WriteLine(book.title);
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
