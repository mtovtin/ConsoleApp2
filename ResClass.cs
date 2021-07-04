using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    public struct Resident { public int Id; public string LastName; public string Address; };
    public struct Payment { public int Id; public string Type; public double Amount; public DateTime Date; };
    public class ResClass
    {

        public List<Tuple<int, double>> TaskA(List<Payment> payments)
        {
            /*  var query1 = from payment in payments
                           group payment by payment.Date.Year
                           into YGroup
                           orderby YGroup.Key
                           select new { year = YGroup.Key, count = YGroup.Count() };
                           */
            var query1 = payments.GroupBy(x => x.Date.Year).Select(x => new { Year = x.Key, Count = x.Count() }).OrderBy(x => x.Year);
            List<Tuple<int, double>> tuples = new List<Tuple<int, double>>();
            if (query1.Any())
            {
                foreach (var item in query1)
                {
                    tuples.Add(new Tuple<int, double>(item.Year, item.Count));
                    Console.WriteLine("Year: {0}, Count: {1}", item.Year, item.Count);
                }
            }
            else
                Console.WriteLine("No payments found.");

            return tuples;
        }


        public List<Tuple<int, string, double>> TaskA1(List<Payment> payments)
        {
            var query2 = from payment in payments
                         group payment by new { payment.Date.Year, payment.Type }
                         into YGroup
                         select YGroup;
            query2 = query2.OrderBy(x => x.Key.Year).ThenBy(x => x.Count());
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            if (query2.Any())
            {
                foreach (var item in query2)
                {
                    tuple.Add(new Tuple<int, string, double>(item.Key.Year, item.Key.Type, item.Count()));
                    Console.WriteLine("Year: {0}, Service: {1}, Count: {2}", item.Key.Year, item.Key.Type, item.Count());
                }
            }
            else
                Console.WriteLine("No information found.");

            return tuple;

        }



        public List<Tuple<int, string, double>> TaskB(List<Payment> payments, List<Resident> residents, int year, string address)
        {
            var query3 = from payment in payments
                         join resident in residents on payment.Id equals resident.Id
                         where payment.Date.Year == year && resident.Address.StartsWith(address) && payment.Type == "Gas"
                         group payment.Amount by new { payment.Date.Year, address }
                         into GGroup
                         select new { GGroup.Key, Income = GGroup.Sum() };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            if (query3.Any())
            {
                foreach (var item in query3)
                {
                    tuple.Add(new Tuple<int, string, double>(item.Key.Year, address, item.Income));
                    Console.WriteLine("Year: {0}, Address: {1}, Total sum for gas: {2}", item.Key.Year, address, item.Income);
                }
            }
            else
                Console.WriteLine("No payments found.");

            return tuple;
        }




        public List<string> TaskC(List<Payment> payments, List<Resident> residents)
        {
            /* var query4 = from payment in payments
                          join resident in residents on payment.Id equals resident.Id
                          group payment.Amount by new { payment.Date.Year, resident.LastName }
                             into SGroup
                          orderby SGroup.Key.Year

                          select new { SGroup.Key.Year,SGroup.Key.LastName, Income = SGroup.Sum()};
             var query5 = from query in query4
                          join resident in residents on query.LastName equals resident.LastName
                          group query.Income by query.Year
                          into RGroup
             select RGroup ;

 
                 var query4 = from payment in payments

                                   join resident in residents on payment.Id equals resident.Id

                                   group new { payment.Amount, resident.LastName } by new
                                   {
                                       payment.Date.Year,
                                       resident.LastName
                                   }

                                        into SGroup

                                group SGroup.Select(x => x.Amount).Sum() by SGroup.Key.Year into RGroup
                                // group SGroup.Select(x=>x.Amount).Sum() by  SGroup.Key.Year into RGroup
                                // group SGroup.Select(x => new { x.LastName, x.Amount }).Where(x => x.Amount == SGroup.Sum(y => y.Amount)) by SGroup.Key.Year into RGroup
                                select new { RGroup.Key, Income = RGroup.Max() };
 */
              var query4 = from payment in payments
                         join resident in residents on payment.Id equals resident.Id
                         group  payment.Amount by new
                         {
                             payment.Date.Year,
                             resident.LastName
                         }
                         into SGroup
                         group new { Surname = SGroup.Key.LastName,Sum= SGroup.Sum() } by  SGroup.Key.Year into RGroup
                         select new { RGroup.Key, Income = RGroup.Where(a=>a.Sum==RGroup.Max(y=>y.Sum)) };

            List<string> list = new List<string>();
            foreach (var item in query4)
            {

                Console.Write("Year: {0}, Sum: ", item.Key);
                foreach(var item2 in item.Income)
                {
                    list.Add(item2.Surname);
                    Console.Write(item2.Surname+", ");
                }
                Console.WriteLine();
            }
            return list;
        }
    }


}

