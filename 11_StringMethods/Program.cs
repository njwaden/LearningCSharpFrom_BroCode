internal class Program
{
    private static void Main(string[] args)
    {
        String fullName = "nasibukhari";
        String phoneNum = "123-456-7890";

        //fullName = fullName.ToUpper();
        //fullName = fullName.ToLower();
        //Console.WriteLine(fullName);

        //phoneNum = phoneNum.Replace("-","");
        //Console.WriteLine(phoneNum);

        //String username = fullName.Insert(0,"@");       //first letter is at index 0 so @ will be inserted at the start of the string
        //Console.WriteLine(username);

        //Console.WriteLine(fullName.Length); 

        String firstName = fullName.Substring(0,4);         // substring(startIndex, length)
        String lastName = fullName.Substring(4, 7);

        Console.WriteLine("Your first name: " + firstName);
        Console.WriteLine("Your last name: " + lastName);

        Console.ReadKey();
    }
}