using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace App3
{
    internal class Program
    {
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
        }
    }
}