using SalesRepresentatives;
using System;

namespace Recepient
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int nrEl = 0;
            SalesPerson[] adList = new SalesPerson[5];

            while (choice != 7)
            {
                DisplayOptions(ref choice);
           
                switch (choice)
                {
                    case 1:
                        AddSale(adList, ref nrEl);
                        break;
                    case 2:
                        SortDisplay(adList,  nrEl);
                        break;
                    case 3:
                        UpdateSales(adList, nrEl);
                        break;
                    case 4:
                        CalculateCommission(adList, nrEl);
                        break;
                    case 5:
                        UpdateCommissionRate(adList, nrEl);
                        break;
                    case 6:
                        DisplayList(adList);
                        break;
                    case 7:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }

            }
            Console.ReadLine();
        }

        private static void DisplayOptions(ref int choice)
        {
            Console.WriteLine("Sales Representatives app");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a sales representative");
            Console.WriteLine("2. Sort and display list");
            Console.WriteLine("3. Update sales amount");
            Console.WriteLine("4. Calculate commission amount");
            Console.WriteLine("5. Update Commission rate");
            Console.WriteLine("6. Display List");
            Console.WriteLine("7. Quit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public static void AddSale(SalesPerson[] adList, ref int nrEl)
        {
            if (nrEl >= 5)
            {
                Console.WriteLine("List is full. Cannot add more sales representatives.");
            }
            else
            {
                Console.Write("Enter the name of the sales representative: ");
                string name = Console.ReadLine();

                Console.Write("Enter the sales amount for the representative: ");
                double sales = double.Parse(Console.ReadLine());

                adList[nrEl] = new SalesPerson(name, sales);
                nrEl++;

                Console.WriteLine("Sales representative added successfully.");
            }
        }
        public static void SortDisplay(SalesPerson[] adList, int nrEl)
        {
            if (nrEl == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                // Sort the array based on the CompareTo method
                Array.Sort(adList, 0, nrEl); // Sort only the filled portion of the array

                // Display the sorted list
                Console.WriteLine("Sorted list of sales representatives:");
                for (int i = 0; i < nrEl; i++)
                {
                    if (adList[i] != null)
                    {
                        adList[i].DisplayPerson();
                        Console.WriteLine(); // Add a blank line between entries for readability
                    }
                }
            }
        }
        static int FindPerson(SalesPerson[] SalesPList, int nrEl, String wanted)
        {
            for (int i = 0; i < SalesPList.Length; i++)
            {
                if (wanted == SalesPList[i].GetName())
                {  return i; }

                
            }

            return -1;
        }
        public static  void UpdateSales(SalesPerson[]adList, int nrEl)
        {
            if (nrEl == 0)
            {
                Console.WriteLine("The list is empty ");

            }
            else
            {
                Console.Write("Enter the name of the sales representative: ");
                string name = Console.ReadLine();
                int pos = FindPerson(adList, nrEl,name);
                if (pos<0)
                {
                    Console.WriteLine("The person is not in the list");

                }
                else
                {
                    Console.Write("Enter the new sales amount : ");
                    double sales=double.Parse(Console.ReadLine());
                    adList[pos].SetSales(sales);
                }

            }
        }
        public static void CalculateCommission(SalesPerson[] adList, int nrEl)
        {
            if(nrEl == 0)
            {
                Console.WriteLine("The list is empty ");
            }
            else
            {
                Console.Write("Enter the name of the sales representative: ");
                string name = Console.ReadLine();
                int pos = FindPerson(adList, nrEl, name);
                if (pos < 0)
                {
                    Console.WriteLine("The person is not in the list");

                }
                else
                {
                    double Commission = adList[pos].GetSales() * adList[pos].GetRate();
                    Console.WriteLine("The Commission amount is {0:C}",Commission);

                }


            }
        }
        public static void UpdateCommissionRate(SalesPerson[]adList, int nrEl)
        {
            if (nrEl == 0)
            {
                Console.WriteLine("The list is empty ");

            }
            else
            {
                Console.Write("Enter the name of the sales representative: ");
                string name = Console.ReadLine();
                int pos = FindPerson(adList, nrEl, name);
                if (pos < 0)
                {
                    Console.WriteLine("The person is not in the list");

                }
                else
                {
                    Console.Write("Enter the updated commission rate for the representative : ");
                    double rate = double.Parse(Console.ReadLine());
                    adList[pos].Setrate(rate);
                    Console.WriteLine("The commission rate was updated");
                }

            }
        }
        public static  void DisplayList(SalesPerson[]adList)
        {
            if (adList.Length == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                for (int i = 0; i < adList.Length; i++)
                {

                    if (adList[i] != null)
                    {
                        adList[i].DisplayPerson();
                        Console.WriteLine(); // Add a blank line between entries for readability
                    }
                }
            }
        }




    }
}
