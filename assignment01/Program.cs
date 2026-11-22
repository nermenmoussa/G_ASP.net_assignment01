/*Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
in a variable of type object. Print it.
*/
using System;
class Book
{
    public string Title { get; set; } ="";
    public int Pages { get; set; }

    public override string ToString()
    {
        return $"Title : {Title} , Pages : {Pages}";
    }
}

class Program
{

    static void Main() {

        Console.WriteLine("----------Q1----------");
        Object obj = new Book{ Title="c#",Pages=555 };
        Console.WriteLine(obj.ToString());

        /*Using the Book class above, print the result of calling ToString(), Equals() (compare book
        with itself), GetHashCode(), and GetType() on book.*/

        Console.WriteLine("----------Q2----------");
        Console.WriteLine(obj.ToString());
        Console.WriteLine(obj.Equals(obj));
        Console.WriteLine(obj.GetHashCode());
        Console.WriteLine(obj.GetType());

        Console.WriteLine("----------Q3----------");
        //compile error 
        int pages = 444;


        Console.WriteLine("-----------Q4------------");
        /*Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
        divide by zero", and then prints "Done" in a finally block.
        */

        try
        {
            int x = 10;
            int res = x/0;
            Console.WriteLine(res);

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("done");
        }



        Console.WriteLine("--------Q5-----------");
        /*Declare an int pages = 300; then store it in a double variable without using a cast.*/

        int page = 300;
        double p = page;

        Console.WriteLine(p);

        Console.WriteLine("--------Q6-----------");
        /*Declare a double price = 49.99; then convert it into an int using a cast.*/

        double price = 49.99;
        int price2 = (int)price;
        Console.WriteLine(price2);

        Console.WriteLine("--------Q7-----------");
        /*Given string pagesText = "464";, convert it into an int using the Convert class.*/
        string pagesText = "444";
        int pagesint = Convert.ToInt32(pagesText);
        Console.WriteLine(pagesint);

        Console.WriteLine("-----------Q8---------");
        /*Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
         "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.*/

        string yearText = "2023";
        int year1 = int.Parse(yearText);

        string badText = "abc";
        if(! int.TryParse(badText, out int parsed))
        {
            Console.WriteLine("invalid number");
        }
        else
        {
            Console.WriteLine(parsed);
        }

        Console.WriteLine("--------Q9_-------------");
        /*Given int pages = 464;, convert it into a string using ToString() and print its type using
        GetType() to prove it's now a string.
        */

        int y11 = 444;
        string r = Convert.ToString(y11);
        Console.WriteLine(r.GetType());

        Console.WriteLine("--------Q10-------------");
        /*Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            variable, and print both.
            */
        int copies = 100;
        Object c1 = copies;

        int c2 = (int)c1;
        Console.WriteLine(c1);
        Console.WriteLine(c2);

        Console.WriteLine("--------Q11-------------");
        /*Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
        value.
        */

        int? year = null;
        Console.WriteLine(year.HasValue);
        year = 2023;
        Console.WriteLine(year.Value);

        Console.WriteLine("--------Q12-------------");
        /*Declare a string? reviewer = null;. Print whether it is null.*/

        string? reviewer = null;
        Console.WriteLine(reviewer==null);


        Console.WriteLine("----------Q13,Q14,Q15---------");
        /*Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the
            program, and print the result.
            */

        Book? nullBook = null;
        string? title = nullBook?.Title; // null instead of NullReferenceException
        Console.WriteLine(title ?? "(null)");

        Console.WriteLine(title ?? "Untitled");
        title ??= "Untitled";
        Console.WriteLine(title);

        string? name = "Ahmed";
        string confirmedName = name!;
        Console.WriteLine(confirmedName);

    }

}


