using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************************
Creating program to use everything learnt.

Situation:
    - Logging win history over 1 week Monday - Sunday
        - Data to be input manually by user.
    - Add up total wins
    - Podium placement
    - Save and export data in a file? Spreadsheet?

Notes:
    - What to do if Tie?
****************************************************************************/
namespace Practice
{
    class Program
    {
        enum Team // define fixed variables.
        {
            Red,
            Blue,
            Green
        }
        static void Main(string[] args)
        {
            Team myVar = new Team();

            // While Loop to check input is Low, Medium or High, then assign myVar accordingly to output
            int check = 0;

            while (check != 1)
            {
                // TO DO: in string have incrementing day simulating week...

                Console.WriteLine("Select winning team of day: \n 1 - Red \n 2 - Blue \n 3 - Green \n\nYour input:");
                string status = Console.ReadLine();

                if ((status == "Red") || (status == "red") || (status == "1"))
                {
                    myVar = Team.Red;
                    check = 1;
                }

                else if ((status == "Blue") || (status == "blue") || (status == "2"))
                {
                    myVar = Team.Blue;
                    check = 1;
                }

                else if ((status == "Green") || (status == "green") || (status == "3"))
                {
                    myVar = Team.Green;
                    check = 1;
                }

                else
                {
                    Console.WriteLine("Invalid input, Please read the damn instructions and try again >:(");
                    check = 0;
                }
            }

            // use myVar to output corresponding string.
            switch (myVar)
            {
                case Team.Red:
                    Console.WriteLine("Status changed to - Red level");
                    break;
                case Team.Blue:
                    Console.WriteLine("Status changed to - Blue level");
                    break;
                case Team.Green:
                    Console.WriteLine("Status changed to - Green level");
                    break;
            }
        }
    }
}
/**********************************************************************************************
Notes:

***********************************************************************************************/