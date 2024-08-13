using System;

namespace SalesRepresentatives
{
    class SalesPerson:IComparable
    {
        private string name;
        private double rate;
        private double sales;

        public SalesPerson(string name, double sales)
        {
            this.name = name;
            this.sales = sales;
            this.rate = 0.08;


        }
        public SalesPerson(string name,double sales,double rate)
        {
            this.name = name;
            this.sales = sales;
            this.rate = rate;
        }

        public string GetName()
        {
            return name;
        }

        public double GetSales()
        {
            return sales;
        }
        public double GetRate()
        {
            return rate;

        }
        public void Setrate(double amount)
        {
           rate = amount;
        }

        public void SetSales(double amount)
        {
            sales = amount;
        }

        public void DisplayPerson()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Commission Rate: {0}", rate);
            Console.WriteLine("Sales: {0:C}", sales);
      
        }
        public int CompareTo(object obj)
        {
            int returnValue;
            SalesPerson temp = (SalesPerson)obj;

            if (string.Compare(this.name, temp.name) > 0)
                returnValue = 1;
            else if (string.Compare(this.name, temp.name) < 0)
                returnValue = -1;
            else
                returnValue = 0;

            return returnValue;
        }

    }

}

