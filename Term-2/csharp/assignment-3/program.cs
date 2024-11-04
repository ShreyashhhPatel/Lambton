using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Shreyash V Patel
//C0934529

namespace shreyashVPatel
{
    internal class Program
    {
        public void Main(string[] args)
        {
            //declaring variables and their datatype and turing them into array
            double[] gpa = new double[5];
            DateTime[] birthday = new DateTime[5];
            string[] lastname = new string[5];
            string[] firstname = new string[5];
            //string[,] studentdata;
              
            //To take data from the user
            for (int i = 0; i < (4+1); i++)
            {
                Console.WriteLine("Please Enter the require information:");
                Console.WriteLine("Enter Student's Firstname");
                firstname[i] = Console.ReadLine();
                Console.WriteLine("Enter Student's lastname");
                lastname[i] = Console.ReadLine();
                Console.WriteLine("Enter Student's GPA");
                gpa[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter student's birth date (as mm/dd/yyyy): ");
                birthday[i] = DateTime.Parse(Console.ReadLine());

                //studentdata = new[] {firstname,lastname,birthday,gpa};
            }

            //to show data 
            for (int i = 0; i < (4+1); i++)
            {
                Console.WriteLine("Student's name is : {0}", (firstname[i]));
                Console.WriteLine("Student's lastname is : {0}", (lastname[i]));
                Console.WriteLine("Student's GPA is : {0}", (gpa[i]));
                Console.WriteLine("Student's birthdate is: ", birthday[i].ToString("d"));
            };

            //to find one index with highest gpa
            int highgpa = Array.IndexOf(gpa, gpa.Max());
            Console.WriteLine("The highest GPA among the 5 student is of "+ firstname[highgpa]+" " + lastname[highgpa]);

            //to print avg value
            Console.WriteLine("The average GPA is" + gpa.Average());

            //to print current date and time
            Console.WriteLine("current date and time: "+ DateTime.Now);


        }
    }
    
}

