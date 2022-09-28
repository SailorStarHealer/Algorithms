class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stuff goes here");

        double t;
        double r;
        double i;
        int k;


        //FOR y FROM - 10 to 10 DO
        for (int y = -10; y <= 10; y++)
        {
            //FOR x FROM 1 to 80 DO
            for (int x = 1; x <= 80; x++)
            {
                //SET REAL r TO 0
                r = 0;

                //SET REAL i TO 0
                i = 0;

                //SET INTEGER k TO -1
                k = -1;

                //WHILE r² + i² < 11 AND k < 112
                while ((r * r) + (i * i) < 11 && k < 112)
                {
                    //SET REAL t TO r
                    t = r;

                    //SET r TO t² - i² - 2.3 + x / 24.5
                    r = (t * t) - (i * i) - 2.3 + x / 24.5;

                    //SET i TO 2 * t * i + y / 8.5
                    i = 2 * t * i + y / 8.5;

                    //INCREMENT k
                    k++;

                    //END WHILE
                }

                //SET INTEGER c TO k MOD 16
                int c = k % 16;

                //SET Console.BackgroundColor TO (ConsoleColor)c
                Console.BackgroundColor = (ConsoleColor)c;

                //SEND '#' TO DISPLAY
                Console.Write("#");

                //END FOR
            }
            //SEND NEW LINE TO DISPLAY
            Console.ReadLine();
        }




    }
