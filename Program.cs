namespace _4UTopic_One___The_Basics
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string afriend = "Maria";
            string secondFriend = "Sage";
            string greeting = "     Hello       ";
            string sayHello = "Hello, World!";
            string songric = "You say goodbye, and I say hello";


            Console.WriteLine("Hello, World!"); 
            Console.WriteLine("Hello," + afriend+ "!");
            Console.WriteLine($"Hello, {afriend}!"); //EASY WAY

            Console.WriteLine($"My friends are, {afriend} and {secondFriend}!");
            Console.WriteLine($"The name {afriend} has {afriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            Console.WriteLine($"[{greeting}]");
            Console.WriteLine($"[{greeting.TrimEnd()}]"); //Trim removes spaces after the text)
            Console.WriteLine($"[{greeting.Trim()}]"); //Trim removes spaces before and after the text

            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper()); //Makes all letters uppercase
            Console.WriteLine(sayHello.ToLower()); //Makes all letters lowercase

            Console.WriteLine(songric.Contains("goodbye")); //Checks if the string contains the word goodbye
            Console.WriteLine(songric.Contains("greetings")); //Checks if the string contains the word greetings

            Console.WriteLine(songric.StartsWith("You")); //Checks if the string starts with the word You





            //Answering the questions

            //1) Provide 2 differnet ways to write a greeting to someone who's name is stored in a string varianble
            //firstName? Use string interpolaton and the + opperator. Which do you prefer?

                //Two different ways to write someone's name stored in a string variable would be to use
                //the + oppeaator or string interpolation. The + operator joins string together between "quotation marks"
                //while the method of string interpolation uses a $ sign before the inital quotations marks, 
                //and {} or curly brackets to insert the desired string variable into the line of code. I prefer
                //string interpolation because because it shortents the length of the code, and makes it easier to combine 
                //multiple string variables into one line of code. In addition the string interpolation method is much easier to read
                //as the varables are easily identified between the curly brackets.


            //2) How would you print out the number of letters in a string called passPhrase?

                //This method takes the number of letters within the string variable and returns that number as an integer.
                     //Console.Writeline($"passPhrase contains {passPhrase.Length} letters.");

            //3) What does the Trim() method do?

                //The trim method is used to get rid of unnessasary spaces before ands after the string variable.

            //4) Methods such as trim(), ToUpper(), and Replace() do not actully change the original string. 
            //Instead, they return a new string. What do you need to add to the following line of code so that schoolCheer
            //will be in all caps when it is printed?

                //You would need to reassign the variable schoolCheer to the result of the method ToUpper().

            string schoolCheer = "programmers are the best!";
            schoolCheer = schoolCheer.ToUpper();
            Console.WriteLine(schoolCheer);


            //5) Attempt the challenge on step 5 of the hello world tutorial by using StartWith() and EndsWith()
            //put code below this line

            Console.WriteLine(songric.StartsWith("You")); 
            Console.WriteLine(songric.EndsWith("hello")); 
            Console.WriteLine(songric.EndsWith("goodbye")); 
            Console.WriteLine(songric.StartsWith("goodbye")); 


            //6 What is the difference between Console.Write() and Console.WriteLine()?

                //Console.Write() prints the line of code to the console and leaves the cursor on the same line.'
                //Console.WriteLine() prints the line of code to the console and the cursor moves to the next line








        }
    }
}
