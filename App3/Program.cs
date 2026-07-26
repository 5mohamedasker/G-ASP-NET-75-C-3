using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace App3
{
    internal class Program
    {
        #region Question018
        ////18.Write a method PrintFirstBook()
        ////that prints the first book in the books array.
        ////If the array is empty,
        ////use return to exit the method early instead of printing anything.
        //public static void PrintFirstBook(string[] books)
        //{
        //    if (books.Length == 0 || books==null)
        //    {
        //        return;
        //    }
        //    Console.WriteLine(books[0]);
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Question01
            ////1.Declare string title = "clean code";
            ////Call title.ToUpper() and store it in a new variable upperTitle.
            ////Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion
            #region Question02
            ////2. Declare two separate string variables,
            ////both set to the literal "Clean Code".Use ReferenceEquals()
            ////to check if they point to the same object in memory.
            //string x = "Clean code";
            //string y = "Clean code";
            //Console.WriteLine( object.ReferenceEquals(x , y) );
            #endregion
            #region Question03
            ////3.Create a StringBuilder, Append() the text "Book List",
            ////then Append() " - Updated" onto the same object.
            ////Print the final result.
            //StringBuilder sb = new ();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);
            #endregion
            #region Question04
            ////4.Using the StringBuilder from the question above,
            ////use Replace() to change "Book List" into "Library".
            ////Print the result.
            //StringBuilder sb = new ("Book List - Updated");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion
            #region Question05
            ////5.Given string title = "Clean Code"; and int pages = 464;
            ////"Book: Clean Code, Pages: 464" using the + operator.
            //string title = "Clean code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + ", Pages: " + pages);
            #endregion
            #region Question06
            ////6.Build the same sentence as above,
            ////but using string interpolation ($"...").
            //string title = "Clean code";
            //int pages = 464;
            //Console.WriteLine($"Book: {title}, Pages: {pages}");
            #endregion
            #region Question07
            ////7.Build the same sentence again, but using string.Format().
            //string title = "Clean code";
            //int pages = 464;
            //Console.WriteLine(string.Format("Book: {0}, Pages: {1}",title,pages));
            #endregion
            #region Question08
            ////8.Given int pages = 464; write an if / else statement 
            ////that prints "Long Book" if pages is greater than 300
            ////otherwise prints "Short Book".
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion
            #region Question09
            ////9.Given int pages = 464; and bool isAvailable = true;
            ////print "You can borrow this book" only if pages is
            ////greater than 300 and isAvailable is true.Use the && operator.
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            //else
            //    Console.WriteLine("You can't borrow this book");
            #endregion
            #region Question010
            ////10.Given string title = "Refactoring";
            ////write a switch statement that prints
            ////"Great choice!" if the title is "Clean Code",
            ////"Nice pick!"  if it's "Refactoring",
            ////and "Never heard of it" for anything else.
            //string title = "Refactoring";
            //switch(title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion
            #region Question011
            ////11.Given int pages = 464;
            ////use the ternary operator to store "Long Book" or "Short Book"
            ////into avariable sizeLabel
            ////(same rule as question 8: long if pages > 300).
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion
            #region Question012
            ////12.Given string[] books =
            ////{ "Clean Code", "The Pragmatic Programmer" , "Refactoring" };
            ////use a for loop to print each book with its position number,
            ////like 1.Clean Code.
            //string[] books = {"Clean Code","The Pragmatic Programmer","Refactoring"};
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion
            #region Question013
            ////13.Using the same books array
            ////use a while loop to print every book title.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int index = 0;
            //while (index < books.Length)
            //{
            //    Console.WriteLine($"{index + 1}. {books[index]}");
            //    index++;
            //}
            #endregion
            #region Question014
            ////14.Write a do-while loop that prints "Checking book..."
            ////exactly 3 times.
            //int times = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    times++;
            //} while (times<3);
            #endregion
            #region Question015
            ////15.Using the same books array
            ////use a foreach loop to print every book title.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion
            #region Question016
            ////16.Using the same books array,
            ////loop through it and print each title,
            ////but stop completely (break) once you reach "Refactoring".
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i=0;i<books.Length;i++)
            //{
            //    if (books[i] == "Refactoring")
            //        break;
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion
            #region Question017
            ////17.Using the same books array
            ////print every title except "The Pragmatic Programmer"
            ////(skip it with continue, don't stop the loop).
            // string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i=0;i<books.Length;i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion
        }
    }
}