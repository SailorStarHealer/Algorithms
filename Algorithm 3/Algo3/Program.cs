

class Program

{
    static string OrdinalNumber(int number)

    {

        //Get the last digit of an integer.
        int lastDigit = number % 10;

        //If the number is bigger than 10, also get the second to last digit.
        if (number > 10)
        {
            int numberSansLastDigit = number / 10;

            int secondToLastDigit = numberSansLastDigit % 10;

            //If the second to last digit is 1, return the integer plus "th"
            if (secondToLastDigit == 1)
            {

                return $"{number}th";

            }

        }

        //If the last digit is 1, return the integer plus "st".
        if (lastDigit == 1)
        {
            return $"{number}st";
        }

        //If the last digit is 2, return the integer plus "nd".
        if (lastDigit == 2)
        {
            return $"{number}nd";
        }

        //If the last digit is 3, return the integer plus "rd".
        if (lastDigit == 3)
        {
            return $"{number}rd";
        }

        //Otherwise return integer plus "th".
        return ($"{number}th");
    }


    static void Main(string[] args)
    {
        for (int inputNumber = 0; inputNumber < 200; inputNumber++)
        {
            Console.WriteLine($"{OrdinalNumber(inputNumber)}");

        }



    }

}