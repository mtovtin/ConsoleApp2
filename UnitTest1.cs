using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp4;
using System.Collections.Generic;

namespace ConsoleApp4Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTaskA()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                  new Payment {Id=1, Type = "Internet", Amount =220.37, Date = new DateTime(2021, 3, 12)},
                  new Payment {Id=2, Type = "Internet", Amount =219, Date = new DateTime(2021, 4, 26)},
            };
            List<Tuple<int, double>> tuple1 = new List<Tuple<int, double>>();
            tuple1.Add(new Tuple<int, double>(2021, 2));
            CollectionAssert.AreEqual(c.TaskA(payments),tuple1);

        }
        [TestMethod]
        public void TestMethod2TaskA()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {

                  new Payment {Id=1, Type = "Internet", Amount =220.37, Date = new DateTime(2021, 3, 12)},
                  new Payment {Id=2, Type = "Internet", Amount =219, Date = new DateTime(2016, 4, 26)},
            };
            List<Tuple<int, double>> tuple1 = new List<Tuple<int, double>>();
            tuple1.Add(new Tuple<int, double>(2021, 1));
            tuple1.Add(new Tuple<int, double>(2016, 1));
            CollectionAssert.AreNotEqual(c.TaskA(payments), tuple1);

        }
        [TestMethod]
        public void TestMethod3TaskA()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {

                  new Payment {Id=1, Type = "Internet", Amount =220.37, Date = new DateTime(2021, 3, 12)},
                  new Payment {Id=2, Type = "Internet", Amount =219, Date = new DateTime(2016, 4, 26)},
            };
            List<Tuple<int, double>> tuple1 = new List<Tuple<int, double>>();
            tuple1.Add(new Tuple<int, double>(2016, 1));
            tuple1.Add(new Tuple<int, double>(2021, 1));
            CollectionAssert.AreEqual(c.TaskA(payments), tuple1);

        }
        [TestMethod]
        public void TestMethod4TaskA()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
               new Payment {Id=1, Type = "Gas" },
               new Payment {Id=1, Type = "Gas" },
               new Payment {Id=1, Type = "Internet" },
            };
  
            List<Tuple<int, double>> tuple1 = new List<Tuple<int, double>>();
            tuple1.Add(new Tuple<int, double>(1, 3));
            CollectionAssert.AreEqual(c.TaskA(payments), tuple1);
            // Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.TaskA(payments));
        }
        [TestMethod]
        public void TestMethod5TaskA()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                 new Payment {Id=5, Type = "Gas", Amount =293939393993939393, Date = new DateTime(2020, 12, 16)},
                  new Payment {Id=26, Type = "Water", Amount =145, Date = new DateTime(2017, 1, 9)},
                  new Payment {Id=26, Type = "Water", Amount =139, Date = new DateTime(2015, 2, 14)},
                  new Payment {Id=26, Type = "Water", Amount =124.04, Date = new DateTime(2022, 3, 13)},
                  new Payment {Id=6, Type = "Gas", Amount =87.16, Date = new DateTime(2001, 3, 21)},
                  new Payment {Id=6, Type = "Gas", Amount =129, Date = new DateTime(2002, 5, 12)},
                  new Payment {Id=7, Type = "Internet", Amount =239.45, Date = new DateTime(2003, 5, 16)},
                  new Payment {Id=8, Type = "Internet", Amount =112.12, Date = new DateTime(2004, 5, 12)},
                  new Payment {Id=8, Type = "Gas", Amount =39, Date = new DateTime(2005, 3, 16)},
                  new Payment {Id=9, Type = "Water", Amount =50, Date = new DateTime(2006, 1, 16)},
                  new Payment {Id=10, Type = "Gas", Amount =110.5, Date = new DateTime(2007, 5, 12)},
                  new Payment {Id=11, Type = "Gas", Amount =95.3, Date = new DateTime(2008, 3, 16)},
                  new Payment {Id=11, Type = "Internet", Amount =199, Date = new DateTime(2009, 3, 19)},
                  new Payment {Id=13, Type = "Gas", Amount =139, Date = new DateTime(2010, 1, 16)},
                  new Payment {Id=14, Type = "Internet", Amount =199, Date = new DateTime(2011, 3, 19)},
                  new Payment {Id=15, Type = "Gas", Amount =135.34, Date = new DateTime(2011, 3, 16)},
                  new Payment {Id=15, Type = "Gas", Amount =139, Date = new DateTime(2011, 1, 16)},
                  new Payment {Id=15, Type = "Water", Amount =139, Date = new DateTime(2012, 2, 16)},
            };

            List<Tuple<int, double>> tuple1 = new List<Tuple<int, double>>();
            tuple1.Add(new Tuple<int, double>(2001, 1));
            tuple1.Add(new Tuple<int, double>(2002, 1));
            tuple1.Add(new Tuple<int, double>(2003, 1));
            tuple1.Add(new Tuple<int, double>(2004, 1));
            tuple1.Add(new Tuple<int, double>(2005, 1));
            tuple1.Add(new Tuple<int, double>(2006, 1));
            tuple1.Add(new Tuple<int, double>(2007, 1));
            tuple1.Add(new Tuple<int, double>(2008, 1));
            tuple1.Add(new Tuple<int, double>(2009, 1));
            tuple1.Add(new Tuple<int, double>(2010, 1));
            tuple1.Add(new Tuple<int, double>(2011, 3));
            tuple1.Add(new Tuple<int, double>(2012, 1));
            tuple1.Add(new Tuple<int, double>(2015, 1));
            tuple1.Add(new Tuple<int, double>(2017, 1));
            tuple1.Add(new Tuple<int, double>(2020, 1));
            tuple1.Add(new Tuple<int, double>(2022, 1));
            CollectionAssert.AreEqual(c.TaskA(payments), tuple1);
            // Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.TaskA(payments));
        }
        [TestMethod]
        public void TestMethodTaskA1()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {

                  new Payment {Id=1, Type = "Internet", Amount =220.37, Date = new DateTime(2021, 3, 12)},
                  new Payment {Id=2, Type = "Internet", Amount =219, Date = new DateTime(2021, 4, 26)},
            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string,double>(2021,"Internet",2));
            CollectionAssert.AreEqual(c.TaskA1(payments), tuple);

        }
        [TestMethod]
        public void TestMethod2TaskA1()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {

                 new Payment {Id=5, Type = "Gas", Amount =293939393993939393, Date = new DateTime(2020, 12, 16)},
                  new Payment {Id=26, Type = "Water", Amount =145, Date = new DateTime(2017, 1, 9)},
                  new Payment {Id=26, Type = "Water", Amount =139, Date = new DateTime(2015, 2, 14)},
                  new Payment {Id=26, Type = "Water", Amount =124.04, Date = new DateTime(2022, 3, 13)},
                  new Payment {Id=6, Type = "Gas", Amount =87.16, Date = new DateTime(2001, 3, 21)},
                  new Payment {Id=6, Type = "Gas", Amount =129, Date = new DateTime(2002, 5, 12)},
                  new Payment {Id=7, Type = "Internet", Amount =239.45, Date = new DateTime(2003, 5, 16)},
                  new Payment {Id=8, Type = "Internet", Amount =112.12, Date = new DateTime(2004, 5, 12)},
                  new Payment {Id=8, Type = "Gas", Amount =39, Date = new DateTime(2005, 3, 16)},
                  new Payment {Id=9, Type = "Water", Amount =50, Date = new DateTime(2006, 1, 16)},
                  new Payment {Id=10, Type = "Gas", Amount =110.5, Date = new DateTime(2007, 5, 12)},
                  new Payment {Id=11, Type = "Gas", Amount =95.3, Date = new DateTime(2008, 3, 16)},
                  new Payment {Id=11, Type = "Internet", Amount =199, Date = new DateTime(2009, 3, 19)},
                  new Payment {Id=13, Type = "Gas", Amount =139, Date = new DateTime(2010, 1, 16)},
                  new Payment {Id=14, Type = "Internet", Amount =199, Date = new DateTime(2011, 3, 19)},
                  new Payment {Id=15, Type = "Gas", Amount =135.34, Date = new DateTime(2011, 3, 16)},
                  new Payment {Id=15, Type = "Gas", Amount =139, Date = new DateTime(2011, 1, 16)},
                  new Payment {Id=15, Type = "Water", Amount =139, Date = new DateTime(2012, 2, 16)},
            };

            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string, double>(2001,"Gas", 1));
            tuple.Add(new Tuple<int, string, double>(2002,"Gas", 1));
            tuple.Add(new Tuple<int, string, double>(2003, "Internet", 1));
            tuple.Add(new Tuple<int, string, double>(2004, "Internet", 1));
            tuple.Add(new Tuple<int, string, double>(2005, "Gas",1));
            tuple.Add(new Tuple<int, string, double>(2006, "Water", 1));
            tuple.Add(new Tuple<int, string, double>(2007,"Gas", 1));
            tuple.Add(new Tuple<int, string, double>(2008, "Gas", 1));
            tuple.Add(new Tuple<int, string, double>(2009, "Internet", 1));
            tuple.Add(new Tuple<int, string, double>(2010,"Gas", 1));
            tuple.Add(new Tuple<int, string, double>(2011,"Internet", 1));
            tuple.Add(new Tuple<int, string, double>(2011, "Gas", 2));
            tuple.Add(new Tuple<int, string, double>(2012,"Water", 1));
            tuple.Add(new Tuple<int, string, double>(2015,"Water", 1));
            tuple.Add(new Tuple<int, string, double>(2017,"Water", 1));
            tuple.Add(new Tuple<int, string, double>(2020,"Gas", 1));
            tuple.Add(new Tuple<int, string, double>(2022,"Water", 1));
            CollectionAssert.AreEqual(c.TaskA1(payments), tuple);

        }
       
        [TestMethod]
        public void TestMethod4TaskA1()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {

                  new Payment {Id=1, Amount =220.37,Type="Gas"},
                  new Payment {Id=2, Type = "Internet", Amount =219, Date = new DateTime(2021, 4, 26)},
            };
            c.TaskA(payments);
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string, double>(1, "Gas", 1));
            tuple.Add(new Tuple<int, string, double>(2021, "Internet", 1));
            CollectionAssert.AreEqual(c.TaskA1(payments), tuple);

        }
        [TestMethod]
        public void TestMethod5TaskA1()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {

               
            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            CollectionAssert.AreEqual(c.TaskA1(payments), tuple);

        }

        [TestMethod]
        public void TestMethodTaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                new Payment {Id=1, Type = "Gas", Amount =220, Date = new DateTime(2021, 3, 12)},
                new Payment {Id=2, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=3, Type = "Gas", Amount =100, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=4, Type = "Gas", Amount =20, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=5, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string, double>(2021, "Park Street", 500));
            CollectionAssert.AreEqual(c.TaskB(payments,residents,2021,"Park Street"), tuple);

        }
        [TestMethod]
        public void TestMethod2TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                new Payment {Id=2, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
    
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street"), tuple);

        }

        [TestMethod]
        public void TestMethod3TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                new Payment {Id=1, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string, double>(2021, "Park Street", 80));
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street"), tuple);

        }

        [TestMethod]
        public void TestMethod4TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                new Payment {Id=1, Type = "Gas", Amount =220, Date = new DateTime(2021, 3, 12)},
                new Payment {Id=1, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string, double>(2021, "Park Street", 300));
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street"), tuple);

        }

        [TestMethod]
        public void TestMethod5TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                 new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                 new Payment {Id=1, Type = "Gas", Amount =80, Date = new DateTime(2020, 4, 26)},
                 new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
     
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street"), tuple);

        }

        [TestMethod]
        public void TestMethod6TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                 new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                 new Payment {Id=1, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
   
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street 15"), tuple);

        }

        [TestMethod]
        public void TestMethod7TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                 new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                 new Payment {Id=1, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
      
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street 8"), tuple);

        }

        [TestMethod]
        public void TestMethod8TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                 new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                 new Payment {Id=1, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();

            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2023, "Park Street"), tuple);

        }
        [TestMethod]
        public void TestMethod9TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                 new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                 new Payment {Id=1, Type = "Gas", Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=3, Type = "Internet", Amount =100, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                new Resident {Id=3, LastName="John", Address="Park Street 52" },
                new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string, double>(2021, "Park Street", 0));
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street"), tuple);

        }
        [TestMethod]
        public void TestMethod10TaskB()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                 new Payment {Id=1, Type = "Internet", Amount =220, Date = new DateTime(2021, 3, 12)},
                 new Payment {Id=1, Type = "Gas", Amount =80, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=3, Type = "Gas", Amount =100, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=4, Type = "Internet", Amount =20, Date = new DateTime(2021, 4, 26)},
                 new Payment {Id=5, Type = "Internet", Amount =80, Date = new DateTime(2021, 4, 26)},

            };

            List<Resident> residents = new List<Resident>()
            {
                 new Resident {Id=1, LastName="Smith", Address="Park Street 5" },
                 new Resident {Id=2, LastName="Josh", Address="Park Street 15" },
                 new Resident {Id=3, LastName="John", Address="Park Street 5" },
                 new Resident {Id=4, LastName="Mooray", Address="Park Street 55" },
                 new Resident {Id=5, LastName="Perry", Address="Park Street 58" },

            };
            List<Tuple<int, string, double>> tuple = new List<Tuple<int, string, double>>();
            tuple.Add(new Tuple<int, string, double>(2021, "Park Street", 180));
            CollectionAssert.AreEqual(c.TaskB(payments, residents, 2021, "Park Street"), tuple);

        }

        [TestMethod]
        public void TestMethodTaskC()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                  new Payment {Id=1, Type = "Internet", Amount =220.37, Date = new DateTime(2021, 3, 12)},
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
                  new Resident {Id=27, LastName="Randell", Address="Elderberry Street 52" }

            };
            List<string> list = new List<string>();
            list.Add("Scott");
            list.Add("Brown");
            list.Add("Jackson");
            list.Add("Randell");
            CollectionAssert.AreEqual(c.TaskC(payments, residents), list);

        }

        [TestMethod]
        public void TestMethod2TaskC()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {
                  new Payment {Id=1, Type = "Internet", Amount =220.37, Date = new DateTime(2021, 3, 12)},
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
                  

            };
            List<string> list = new List<string>();
            list.Add("Scott");
            list.Add("Brown");
            list.Add("Jackson");
            CollectionAssert.AreEqual(c.TaskC(payments, residents), list);

        }

        [TestMethod]
        public void TestMethod3TaskC()
        {
            var c = new ResClass();
            List<Payment> payments = new List<Payment>()
            {

            };

            List<Resident> residents = new List<Resident>()
            {
           
            };
            List<string> list = new List<string>();

            CollectionAssert.AreEqual(c.TaskC(payments, residents), list);

        }

    }


}
