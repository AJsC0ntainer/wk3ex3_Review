namespace wk3ex3_Review;
class Program
{
    static void Main(string[] args)
    {
        string str;
        int vowels = 0;

        Console.Write("Enter a string: ");
        str = (Console.ReadLine().ToLower());

        foreach (char c in str)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowels++;

            }
        }

        Console.WriteLine($"The Number of vowels in the string is: {vowels}");

        Console.Read();

    }
}

