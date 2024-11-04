
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Shreyash V Patel
//C0934529
namespace shreyashVPatel
{
    internal class Question2
    {
        static void Main(string[] args)
        {
            //declaring and assigning a variable
            int airport_charge = 4;
            int one_time_fees = 25;
            int parking_per_day = 40;
            int[] menu_choice = { 1, 2};
            while (true)
            {
                Console.WriteLine("Enter the type of parking you want to avail:");
                Console.WriteLine("1.Short-term Parking");
                Console.WriteLine("2.Long-term Parking");
                //Console.WriteLine("or press anyother keys to exit");
                //using try catch to catch the user from entering invalid input and other thing than integer
                try
                {
                    int x = Int32.Parse(Console.ReadLine());
                    //using switch statment because if else was an easy option but not optimal for memory efficiancy(i think so) because of using nested if else which may decrease efficiancy
                    while (true){   
                        switch (x)
                    {
                        //code for short term parking
                        case 1:
                            Console.WriteLine("Short-term Parking");
                            Console.WriteLine("how many hours you wanna park your vehicle? or press 0 to exit");
                            int parking_hours = Int32.Parse(Console.ReadLine());

                            //using while loop to check if user had given a valid input
                            while (true)
                            {
                                if (parking_hours == 1)
                                {
                                    Console.WriteLine("Your parking fees is $" + airport_charge);
                                    break;

                                }
                                else if (parking_hours == 0)
                                {
                                    Console.WriteLine("exiting the short term parking page.");
                                    break;
                                }
                                else if (parking_hours > 1 || parking_hours < 7)
                                {
                                    Console.WriteLine("your parking fees is $" + (airport_charge + ((parking_hours - 1) * 3)));
                                    break;
                                }
                                else if (parking_hours > 24)
                                {
                                    Console.WriteLine("Your parking fees is $" + parking_per_day);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("It's exceed the maximum parking hours per day or not a valid number");

                                };
                            };
                            break;
                        //Code for long term parking 
                        case 2:
                            Console.WriteLine("Long-term Parking");
                            Console.WriteLine("how many days you wanna park your vehicle? or enter 0 to exit ");
                            int parking_days = Int32.Parse(Console.ReadLine());

                            //using while loop to check if user had given a valid input
                            while (true)
                            {
                                if (parking_days >= 1)
                                {
                                    Console.WriteLine("Your Parking fees is $" + (one_time_fees + (parking_per_day * parking_days)));
                                    break;
                                }
                                else if (parking_days == 0)
                                {
                                    Console.WriteLine("Exiting th long term parking page");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Enter a valid valid amount of days");
                                }
                            }
                            break;
                        default: Console.WriteLine("Entering the parking page"); break;


                    };
                    break;
                }
                } catch
                {
                    Console.WriteLine("Entering a valid output");
                }
                
              

            }
        }
    }
}
//just if else one code
//    if (x == menu_choice[0]|| x == menu_choice[1]|| x == menu_choice[2]) {
//        if (x == menu_choice[0]) {
//            Console.WriteLine("Short-term Parking");
//            Console.WriteLine("how many hours you wanna park your vehicle?");
//            int parking_hours = Int32.Parse(Console.ReadLine());
//            if (parking_hours == 1) {
//                Console.WriteLine("Your parking fees is $" + airport_charge);
//            }else if (parking_hours>1 || parking_hours < 7)
//            {
//                Console.WriteLine("your parking fees is $"+ (airport_charge+((parking_hours-1)*3)));
//            }
//            else if(parking_hours > 24)
//            {
//                Console.WriteLine("Your parking fees is $40");
//            }
//            else
//            {
//                Console.WriteLine("It's exceed the maximum parking hours per day");
//            };
//        }
//        else if(x == menu_choice[1])
//        {
//            Console.WriteLine("2.Long-term Parking");

//        }
//        else {
//            break;
//        };
//    }
//    else {
//        Console.WriteLine("Enter a valid option");
//    };
//}
