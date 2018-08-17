using System;

namespace CG_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = ("Alice was beginning to get very tired of sitting by her sister on the bank, " +
                 "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                 "but it had no pictures or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without " +
                 "pictures or conversation?’");

            Console.WriteLine("Please enter a search term."); //prompt user for a search term
            string searchTerm = Console.ReadLine();  //accepts and puts out word entered
                                                     
            myString = myString.ToLower(); //this converts the entire string to lowercase so a search for "alice" will print true
            searchTerm = searchTerm.ToLower();   //this converts the user's input to loswercase so if they type "Alice" it will produce 
                                                 //"alice" and therefore return a true result
          
            if (myString.IndexOf(searchTerm) >= 0)  //this searches all of the characters in the sentence from {0} through rest of text
                Console.WriteLine("True");  //if statement to produce "true" if the search term is found in text
            else
                Console.WriteLine("False");  //else statement to print "false" if search term is not found in text
           
            Console.ReadLine();
             




        }
    }
}
