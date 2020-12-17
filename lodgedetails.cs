using System;

namespace Lodge
{
    class Lodge
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Lodge ");
       
            String entrance = "yes";
            OrderDetails Order = new OrderDetails();
            Problemdetails Problem=new Problemdetails();
            while (entrance.Equals("yes"))
            {
                Console.WriteLine("1.Do You want to order: .       2.report an Problem.       3.show Problem. 4.exit.");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Order.setOrderDetails();
                        break;
                    case 2:
                        Problem.setProblemdetails();
                        break;
                    case 3:
                        Problem.ShowProblemtails();
                        break;
                    case 4:
                        entrance = "no";
                        Console.WriteLine("Thankyou ");
                        break;
                    default: 
                    break;
                }

            }

        }
    }
}
