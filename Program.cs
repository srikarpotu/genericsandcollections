using System;
using System.Collections.Generic;

namespace Lodge
{
    public class OrderDetails
    {
        public int Roomno
        {
            get;
            set;
        }
        public int Orderno
        {
            get;
            set;
        }
       
        public OrderDetails()
        {
            OrderDetailsList = new List<OrderDetails>();
        }
        public OrderDetails(int Roomno, int Orderno)
        {
           
            this.Roomno= Roomno;
            this.Orderno = Orderno;
            
        }
        public void setOrderDetails()
        {
            Console.Write("Please your Details:");
            Console.Write("Enter your roomno : ");
            Roomno= Convert.ToInt16(Console.ReadLine());
            Console.Write("1.chocolate 2.cooldrink");
            Orderno = Convert.ToInt16(Console.ReadLine());
            OrderDetailsList.Add(new OrderDetails(Roomno, Orderno));
            Console.WriteLine("Your Details  added Succesfully ");
        }
        public void ShowOrder()
        {
            foreach (var order in OrderDetailsList)
            {
                Console.WriteLine(order.Roomno + "    " + order.Orderno);
            }
        }
        public List<OrderDetails> OrderDetailsList;
    }
}