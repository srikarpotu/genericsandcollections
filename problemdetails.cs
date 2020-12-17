using System;
using System.Collections.Generic;
using System.Linq;

namespace Lodge
{
    
    public class Problemdetails
    {

        public int Roomno
        {
            get;
            set;
        }
        public string Problem
        {
            get;
            set;
        }

        public Problemdetails()
        {
            ProblemdetailsList = new List<Problemdetails>();
        }
        public Problemdetails(int Roomno, string Problem)
        {

            this.Roomno = Roomno;
            this.Problem = Problems;

        }
        public void setProblemdetails()
        {

            Console.Write("Enter your roomno : ");
            Roomno = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your Problem: ");
            string Problem=Console.ReadLine();
            ProblemdetailsList.Add(new Problemdetails(Roomno, Problem));
            Console.WriteLine("Your Problem is Succesfully added ");
        }

        public void ShowIProblemdetails()
        { 
            Console.Write("Enter your roomno : ");
            Roomno = Convert.ToInt16(Console.ReadLine());
           var query=from Problemdetails in ProblemdetailsList orderby select Problem;
            foreach (var Problem in query)
            {
                 Console.WriteLine(Problem);
            }


     
        }
          public List<Problemdetails> ProblemdetailsList;
    }
    
}