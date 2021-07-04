using System;
using System.Collections.Generic;
using ConsoleApp4;
namespace ConsoleTestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new ResClass();

            List<Resident> residents = new List<Resident>()
              {
                  new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                  new Resident {Id=2, LastName="Johnson", Address="Oak Street 15" },
                  new Resident {Id=4, LastName="Williams", Address="Elm Street 3" },
                  new Resident {Id=5, LastName="Brown", Address="View Street 1" },
                  new Resident {Id=6, LastName="Jones", Address="Fifth Street 52" },
                  new Resident {Id=7, LastName="Scott", Address="Main Street 35" },
                  new Resident {Id=8, LastName="Miller", Address="Hill Street 1" },
                  new Resident {Id=9, LastName="Davis", Address="Lake Street 25" },
                  new Resident {Id=10, LastName="Lopez", Address="Pine Street 6" },
                  new Resident {Id=11, LastName="Wilson", Address="Fifth Street 79" },
                  new Resident {Id=13, LastName="Anderson", Address="Park Street 144" },
                  new Resident {Id=14, LastName="Thomas", Address="Washington Street 15" },
                  new Resident {Id=15, LastName="Taylor", Address="Beldon Street 55" },
                  new Resident {Id=18, LastName="Moore", Address="Oak Street 8" },
                  new Resident {Id=20, LastName="Jackson", Address="Main Street 57" },
                  new Resident {Id=19, LastName="Martin", Address="Wood Street 4" },
                  new Resident {Id=22, LastName="Lee", Address="Bowden Street 1" },
                  new Resident {Id=23, LastName="Harris", Address="Clifford Street 26" },
                  new Resident {Id=25, LastName="Young", Address="Park Street 9" },
                  new Resident {Id=26, LastName="Scott", Address="Elderberry Street 52" },
                  new Resident {Id=27, LastName="Randell", Address="Elderberry Street 13" }
              };

            List<Payment> payments = new List<Payment>()
            {

                  new Payment {Id=1, Type = "Gas", Amount =220.37, Date = new DateTime(2021, 3, 12)},
                  new Payment {Id=2, Type = "Internet", Amount =219, Date = new DateTime(2021, 4, 26)},
                  new Payment {Id=4, Type = "TV", Amount =89.90, Date = new DateTime(2021, 5, 16)},
                  new Payment {Id=5, Type = "Gas", Amount =293, Date = new DateTime(2020, 12, 16)},
                  new Payment {Id=26, Type = "Water", Amount =145, Date = new DateTime(2021, 1, 9)},
                  new Payment {Id=26, Type = "Water", Amount =139, Date = new DateTime(2021, 2, 14)},
                  new Payment {Id=26, Type = "Water", Amount =124.04, Date = new DateTime(2021, 3, 13)},
                  new Payment {Id=6, Type = "Gas", Amount =87.16, Date = new DateTime(2021, 3, 21)},
                  new Payment {Id=6, Type = "Gas", Amount =129, Date = new DateTime(2021, 5, 12)},
                  new Payment {Id=7, Type = "Internet", Amount =239.45, Date = new DateTime(2021, 5, 16)},
                  new Payment {Id=8, Type = "Internet", Amount =112.12, Date = new DateTime(2021, 5, 12)},
                  new Payment {Id=8, Type = "Gas", Amount =39, Date = new DateTime(2021, 3, 16)},
                  new Payment {Id=9, Type = "Water", Amount =50, Date = new DateTime(2021, 1, 16)},
                  new Payment {Id=10, Type = "Gas", Amount =110.5, Date = new DateTime(2021, 5, 12)},
                  new Payment {Id=11, Type = "Gas", Amount =95.3, Date = new DateTime(2021, 3, 16)},
                  new Payment {Id=11, Type = "Internet", Amount =199, Date = new DateTime(2021, 3, 19)},
                  new Payment {Id=13, Type = "Gas", Amount =139, Date = new DateTime(2021, 1, 16)},
                  new Payment {Id=14, Type = "Internet", Amount =199, Date = new DateTime(2021, 3, 19)},
                  new Payment {Id=15, Type = "Gas", Amount =135.34, Date = new DateTime(2021, 3, 16)},
                  new Payment {Id=15, Type = "Gas", Amount =139, Date = new DateTime(2021, 1, 16)},
                  new Payment {Id=15, Type = "Water", Amount =139, Date = new DateTime(2021, 2, 16)},
                  new Payment {Id=15, Type = "Water", Amount =55.65, Date = new DateTime(2021, 1, 19)},
                  new Payment {Id=19, Type = "TV", Amount =199, Date = new DateTime(2018, 9, 2)},
                  new Payment {Id=20, Type = "Internet", Amount =135.2, Date = new DateTime(2018, 3, 19)},
                  new Payment {Id=20, Type = "Internet", Amount =239.45, Date = new DateTime(2018, 5, 16)},
                  new Payment {Id=27, Type = "Internet", Amount =135.2, Date = new DateTime(2018, 3, 19)},
                  new Payment {Id=27, Type = "Internet", Amount =239.45, Date = new DateTime(2018, 5, 16)},
                  new Payment {Id=23, Type = "Water", Amount =245, Date = new DateTime(2021, 5, 16)},
                  new Payment {Id=26, Type = "TV", Amount =239.45, Date = new DateTime(2021, 1, 13)},


              };
            Console.WriteLine("Task 1");
            f.TaskA(payments);
            Console.WriteLine("Task 1.1");
            f.TaskA1(payments);
            Console.WriteLine("Task 2");
            f.TaskB(payments,residents, 2021, "Park Street");
            Console.WriteLine("Task 3");
            f.TaskC(payments,residents);

        }
    }
}
