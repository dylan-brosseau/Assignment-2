using System;

public static class GradeAverage
{
    public static void Main()
    {
        //Variable Declarations.
        char deptCode = ' ';
        int cNum = 0, pNum = 0, hNum = 0, deptMark;
        double cGrade = 0, pGrade = 0, hGrade = 0, cFinal, pFinal, hFinal;

        //Prints a Header with basic instructions
        Console.WriteLine("The course codes are - Computer Science:'c' or 'C', Psycology:'p' or 'P', History:'h' or 'H'\n Enter 'q' or 'Q' to calculate\n" +
            "For the marks, please enter an integer between 1 and 100");


        while (deptCode != 'Q')
        {
            while (true)
            {
                //Prompts the user to enter a charcter
                Console.Write("Please enter the department code: ");
                try
                //If the input can be converted to a char, it is asssigned to deptCode
                {
                    deptCode = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                }
                catch
                {
                    //Otherwise (a non char was enterd, or more than 1) An error message is printed and the program terminates.
                    Console.WriteLine("You did not enter a single character.  Restart the program to try again");
                    Environment.Exit(1);
                }

                if (deptCode == 'C' || deptCode == 'P' || deptCode == 'H' || deptCode == 'Q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You did not enter a valid department code, please try again");
                }
            }


            Console.Write("Please enter the mark: ");

                try // If the input is an int, it is assigned to deptMark
                    {
                        deptMark = Convert.ToInt32(Console.ReadLine());
                    }

                catch //Otherwise, an error message is printed and the program terminates.
                    {
                        deptMark = 0; // Only here because if its not I get a "variable unassigned error "
                        Console.WriteLine("You did not enter an interger. Restart the prgram to try again.");
                        Environment.Exit(1);
                    }

            if (deptMark < 0 || deptMark > 100)
            {
                Console.WriteLine("The value you have entered is not between 1 and 100, please restart the program and try again.");
                Environment.Exit(1);
            }
                if (deptCode == 'C')
                {
                    cNum++;
                    cGrade += deptMark;
                }
                else if (deptCode == 'P')
                {
                    pNum++;
                    pGrade += deptMark;
                }
                else if (deptCode == 'H')
                {
                    hNum++;
                    hGrade += deptMark;
                }

        }

        // Calculating CompSci
        if (cNum > 0)
         {
             cFinal = cGrade / cNum;
         }
        else
         {
             cFinal = 0;
         }
        if (pNum > 0)
         {
             pFinal = pGrade / pNum;
         }
        else
         {
             pFinal = 0;
         }
        if (hNum > 0)
        {
            hFinal = hGrade / hNum;
        }
        else
        {
            hFinal = 0;
        }

        Console.Write("The Average for computer science students is {0}\n" +
            "The average for physcology students is {1}\n" +
            "The average for history students is {2}\n", cFinal, pFinal, hFinal);

    }
}
