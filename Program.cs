namespace wk3ex3_Review;
class Program
{
    static void Main(string[] args)
    {
        //Initialize the string variable
        string str;
        //Initialize and store the vowel count
        int vowels = 0;
        //pormpt the user for the string
        Console.Write("Enter a string: ");
        //stores the string value
        str = (Console.ReadLine().ToLower());
        //foreach loop to iterate the string, for each character in string
        foreach (char c in str)
        {
            //if the characters == to vowels increase the vowel count
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                //increase the vowel count by one
                vowels++;
            }
        }
        //display the number of vowels
        Console.WriteLine($"The Number of vowels in the string is: {vowels}");
        //stops the program to allow th user to read the result
        Console.WriteLine("Press any key to exit...");
        Console.Read();
    }
}