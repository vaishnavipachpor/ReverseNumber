// Write the program to print the reverse of the given Number.
 class ReverseNumber
{
static void Main()
    {
        Console.Write("Enter the number");
        int Number = int.Parse(Console.ReadLine());
        int Reminder, Reverse = 0;
        while(Number!=0)
        {
            Reminder = Number % 10;
            Reverse = Reverse * 10 + Reminder;
            Number = Number / 10;

        }
        Console.WriteLine("reverse number is" + Reverse);
        Console.ReadLine();

    }

}