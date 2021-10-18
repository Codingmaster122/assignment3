using System;

namespace Assignment3
{
    class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-10) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                    case "8":
                        Question8();
                        break;
                    case "9":
                        Question9();
                        break;
                    case "10":
                        Question10();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        #endregion

        /// <summary>
        /// Write code that prompts the user for a menu choice.
        /// The program will display a message based on the following:
        ///   Choice            Message
        ///   1                 "Calculate area"
        ///   2                 "Calculate volume"
        ///   3                 "Calculate surface area"
        ///   4                 "Exit the program"
        ///   any other input   "ERROR: Invalid choice"
        /// </summary>
        public static void Question1()
        {
         
            Console.WriteLine("choose an option:");
            Console.WriteLine("1) Calculate area");
            Console.WriteLine("2) Calculate volume");
            Console.WriteLine("3) Calculate surface area");
            Console.WriteLine("4) Exit the program");
            Console.WriteLine("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {


                case "1":
                    Console.WriteLine("Calculate area");
                    break;
                case "2":
                    Console.WriteLine("Calculate Volume");
                    break;
                case "3":
                    Console.WriteLine("Calculate Surface Area");
                    break;
                case "4":
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid Choice;");
                    break;

               
            }


        }
        /// <summary>
        /// Write code that allows the user to enter two integers and a character.
        /// If the character is 'A', then add the two integers.
        /// If the character is 'S', then subtract the second integer from the first.
        /// Otherwise, multiply the integers.
        /// Display the results of the arithmetic.
        /// </summary>
        public static void Question2()
        {
            string operation;

            int number1;

            int number2;

            int result;


            Console.WriteLine("pick number 1 ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("pick number 2 ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick a letter: ");
            operation = Console.ReadLine();

            if(operation == "A")
            {
              result = number1 + number2; 
            }
            else
            if(operation == "S")
            {
                result = number1 - number2; 
            }

            else
            {
              result = number1 * number2;
            }


            Console.Write("The result is... ");
            Console.WriteLine(result);

        }

        /// <summary>
        /// Write code that prompts the user for the number of cources and residency status
        /// (domestic or international) and calculates tuition cost. Cost is calculated based on the
        /// folowing:
        ///     Domestic        $325 per course
        ///     International   $1375 per course
        /// You decide how you want the user to enter their residency status and prompt accordingly.
        /// You must use named constants for the cost per course.
        /// Display the total cost.
        /// </summary>
        public static void Question3()
        {
            const int domestic = 325;

            const int international = 1375;

            Console.WriteLine("Please type domestic or international:");
            var userChoice = Console.ReadLine();

            Console.WriteLine("please type the amount of courses: ");
            var amountOfCourses = Console.ReadLine();

        

            switch (Console.ReadLine())
            {
                case "domestic":
                    int result = domestic * int.Parse(amountOfCourses);
                    Console.WriteLine("Your Price is:" + result);
                    break;
                case "international":
                    int result2 = international * int.Parse(amountOfCourses);
                    Console.WriteLine("Your Price is:" + result2);
                    break;
            }



        }

        /// <summary>
        /// Write code that prompts the user for a day of the week. The program will display a 
        /// message based on the following:
        ///     Choice      Message
        ///     Sun         Home
        ///     Mon         Work
        ///     Tue         Work
        ///     Wed         Home
        ///     Thu         Work
        ///     Fri         Work
        ///     Sat         Work
        /// </summary>
        public static void Question4()
        {
            Console.WriteLine("Please type the days week");

            switch (Console.ReadLine())
            {
                case "Sun":
                    Console.WriteLine("Home");
                    break;
                case "Mon":
                    Console.WriteLine("Work");
                    break;
                case "Tue":
                    Console.WriteLine("Work");
                    break;
                case "Wed":
                    Console.WriteLine("Home");
                    break;
                case "Thu":
                    Console.WriteLine("Work");
                    break;
                case "Fri":
                    Console.WriteLine("Work");
                    break;
                case "Sat":
                    Console.WriteLine("Work");
                    break;
            }




        }

        /// <summary>
        /// Write code for a furniture company. Ask the user to choose Pine, Oak or Mahogany.
        /// Show the price of a table manufactured with the choosen wood. Pine tables cost $100, 
        /// Oak tables cost $125, and Mahogany tables cost $310. You must use named constants and
        /// a switch statement. You must accept any variation on the case (Eg. Pine, pine, PINE, piNe, etc
        /// </summary>
        public static void Question5()
        {
            const int pineTable = 100;
            const int oakTable = 125;
            const int mahoganyTable = 310;

            Console.WriteLine(" Choose Pine, Oak or Mahogany");
            switch (Console.ReadLine().ToLower())
            {
                case "pine":
                    Console.WriteLine("Your price is: {0}", pineTable);
                    break;
                case "oak":
                    Console.WriteLine("Your price is: {0}", oakTable);
                    break;
                case "mahogany":
                    Console.WriteLine("your price is:{0}", mahoganyTable);
                    break;
            }

        }

        /// <summary>
        /// Write code that prompts the user for an hourly pay rate. If the value entered is less than
        /// $5.65, display an error message
        /// </summary>
        public static void Question6()
        {
                
            Console.Write("Please type your hourly pay rate: ");
            double payrate = double.Parse(Console.ReadLine());

            if (payrate < 5.65)
            {
                Console.WriteLine("That is less than 5.65");
            }

        }



        /// <summary>
        /// Write code that prompt a user for an hourly pay rate. If the user enters a vale less than
        /// $5.65 or greater than $49.99, prompt the user again. If the user enters an invalid value again,
        /// display an appropriate error message. If the user enters a valid value on either the first or
        /// second attempt, display the pay rate as well as the weekly rate which is calculated as 40 times 
        /// the hourly rate.
        /// </summary>
        public static void Question7(bool is_repeated_attempt = false)
        {
            Console.Write("Please type your hourly pay rate: ");
            double payrate = double.Parse(Console.ReadLine());

            if (payrate < 5.65 || payrate > 49.99)
            {
                if (is_repeated_attempt)
                {
                    Console.WriteLine("ERROR: That is less than 5.65 or higher then 49.99");
                }
                else
                {
                    Question7(true);
                }
                
                return;
            }

            // When we're here, payrate is guaranteed to be > 5.65 and < 49.99

            Console.Write("Hourly rate is: ");
            Console.WriteLine(payrate);

            Console.Write("Weekly rate is: ");
            Console.WriteLine(40 * payrate);
        }

        /// <summary>
        /// Write a program for a college's admissions office. The user enters a numeric high school grade
        /// point average (ex. 3.2) and an admission test score. Print the message "Accept" if the student
        /// meets either of the following requirements:
        /// A grade point average of 3.0 or highier and an admission test score of at least 60
        /// 
        ///  A grade point average of less than 3.0 and an admission test score of at least 80
        /// If the student does not meet either of the qualification criteria, print "Reject"
        /// </summary>
        public static void Question8()
        {
                Console.Write("Enter your numeric high school grade point average: ");
                double grade = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your admission test score: ");
                double score = Convert.ToDouble(Console.ReadLine());

                if ((grade >= 3.0 && score >= 60) || (grade < 3.0 && score >= 80))
                {
                    Console.WriteLine("Accept");
                }
                else
                {
                    Console.WriteLine("Reject");
                }

        }

          
        
    
         
    /// <summary>
    /// Write code that prompts the uesr for an hourly pay rate and hours worked. Compute gross pay
    /// (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax).
    /// Withholding tax is computed as a percentage of gross pay based on the following:
    ///     Gross pay                       Withholding Percentage
    ///     Up to an including 300.00       10%
    ///     300.01 and up                   12%
    /// </summary>
    public static void Question9()
        {

            Console.WriteLine("Enter hourly pay rate : ");
            double hourlypayrate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter hours worked :");
            double hoursworked = double.Parse(Console.ReadLine());

            double tax = 0, grosspay;

            grosspay = hourlypayrate * hoursworked;

            if (grosspay >= 0 && grosspay <= 300)
            {

                tax = grosspay * 0.10;

            }
            else if (grosspay >= 300.01)
            {

                tax = grosspay * 0.12;

            }

            double netpay = grosspay - tax;
          Console.WriteLine("\nhourly pay rate: " + hourlypayrate + "\nhours worked : " + hoursworked +
       "\ngross pay:  " + grosspay + "\nwithholding tax : " + tax + "\nnet pay :" + netpay);


        }

        /// <summary>
        /// Write code for a lawn-mowing service. The lawn-mowing season lasts 20 weeks. The weekly fee
        /// for mowing a lot under 400 square feet is $25. 
        /// The fee for a lot that is 400 square feet or more,
        /// but under 600 square feet, is $35 per week. The fee for a lot that is 600 square feet or over is 
        /// $50 per week. Prompt the user for the length and width of a lawn, and then print the weekly
        /// mowing fee, as well as the total fee for the 20-week season.
        /// </summary>
        public static void Question10()
        {

            Console.WriteLine("Enter the length of lawn : ");
            int len = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of lawn : ");
            int wid = Int32.Parse(Console.ReadLine());
            int area = len * wid;
            int cost = 0;
            if (area >= 600)
            {
                cost = 50;
            }
            else if (area >= 400 && area < 600)
            {
                cost = 35;
            }
            else
            {
                cost = 25;
            }
            int totalcost = 20 * cost;
            Console.WriteLine("Weekly cost : " + cost);
            Console.WriteLine("Cost of 20 week : " + totalcost);

        }
    }

}
