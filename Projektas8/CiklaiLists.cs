using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas8.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Projektas8
{
    internal class CiklaiLists
    {
        static void Main(string[] args)
        {
            /////////////////////////////////
            /// Ciklai //////////////////////
            /////////////////////////////////

            //PirmojiUzduotis();

            //AntrojiUzduotis();

            //TreciojiUzduotis();

            //KetvirtojiUzduotis();

            //PenktojiUzduotis();

            //SestojiUzduotis();

            /////////////////////////////////
            /// Lists ///////////////////////
            /////////////////////////////////

            //Task1();

            //Task2();

            //Task3();

            //OrderSystem();
        }

        /// <summary>
        /// Ima skaicius 1-100 ir patikrina ar dalijasi is 3. Jei taip, atspausdina "Fizz", jei ne, atspausdina skaiciu.
        /// </summary>
        public static void PirmojiUzduotis()
        {
            List<int> theList = GetList(1, 100);
            CheckIfDividesByThreeAndPrint(theList);
        }

        /// <summary>
        /// Grazina int kintamuju sarasa pagal nurodyta pradini ir galutini skaiciu
        /// </summary>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        public static List<int> GetList(int start, int finish)
        {
            List<int> tempList = new List<int>();
            for(int i = start; i <= finish; i++)
            {
                tempList.Add(i);
            }
            return tempList;
        }

        /// <summary>
        /// Patikrina visus saraso elementus ir atspausdina rezultata. Jei dalinasi is 3 - "Fizz", kitu atveju atspausdina tiesiog skaiciu
        /// </summary>
        /// <param name="tempList"></param>
        public static void CheckIfDividesByThreeAndPrint(List<int> tempList)
        {
            foreach (int i in tempList)
            {
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Nuskaito vartotojo ivesta masyva ir isveda didziausia ir maziausia elementus
        /// </summary>
        public static void AntrojiUzduotis()
        {
            int[] theArray = Array.Empty<int>();

            ReadArrayComplete(ref theArray);
            Console.WriteLine($"Didziausias masyvo elementas: {theArray.Max()}");
            Console.WriteLine($"Maziausias masyvo elementas: {theArray.Min()}");
        }

        /// <summary>
        /// Nuskaito masyvo ilgi
        /// </summary>
        /// <param name="theArray"></param>
        public static void ReadArrayComplete(ref int[] theArray)
        {
            Console.Write("Iveskite masyvo ilgi: ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length < 1)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            theArray = new int[length];

            ReadArray(ref theArray);
        }

        /// <summary>
        /// Nuskaito masyva pagal nurodyta ilgi
        /// </summary>
        /// <param name="theArray"></param>
        public static void ReadArray(ref int[] theArray)
        {
            Console.WriteLine($"Iveskite {theArray.Length} sveikuju skaiciu:");
            for (int i = 0; i < theArray.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Neteisinga ivestis, bandykite dar karta");
                    i--;
                }
                else
                    theArray[i] = number;
            }
        }

        /// <summary>
        /// Isveda piramidini skaiciu modeli pagal vartotojo nurodyta auksti
        /// </summary>
        public static void TreciojiUzduotis()
        {
            PrintPyramid(GetPyramidHeight("piramides"));
        }

        /// <summary>
        /// Atspausdina piramide pagal nurodyta auksti
        /// </summary>
        /// <param name="height"></param>
        public static void PrintPyramid(int height)
        {
            if (height == -1)
                return;
            string temp;
            Console.WriteLine();
            for (int i = 1; i <= height; i++)
            {
                temp = "*";
                for (int j = 1; j < 2 * i - 1; j++)
                    temp += "*";
                for (int j = 0; j < height - i; j++)
                    temp = " " + temp;
                Console.WriteLine(temp);
            }
        }

        /// <summary>
        /// Grazina nuskaityta piramides auksti
        /// </summary>
        /// <returns></returns>
        public static int GetPyramidHeight(string name)
        {
            Console.Write($"Iveskite {name} auksti: ");
            if (!int.TryParse(Console.ReadLine(), out int height) || height < 1)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return -1;
            }
            return height;
        }

        /// <summary>
        /// Isveda apversta piramidini skaiciu modeli pagal vartotojo nurodyta auksti
        /// </summary>
        public static void KetvirtojiUzduotis()
        {
            PrintPyramidInverted(GetPyramidHeight("apverstos piramides"));
        }

        /// <summary>
        /// Atspausdina apversta piramide pagal nurodyta auksti.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="bDiamond">Naudojamas deimantiniam skaiciu modeliui. Kai true, nespausdina tuscios eilutes pries piramide ir kiekvienai eilutei prideda papildoma tarpa</param>
        public static void PrintPyramidInverted(int height, bool bDiamond = false)
        {
            if (height == -1)
                return;
            string temp;
            if(!bDiamond)
                Console.WriteLine();
            for (int i = height; i > 0; i--)
            {
                if(bDiamond)
                    temp = " *";
                else
                    temp = "*";
                for (int j = 1; j < 2 * i - 1; j++)
                    temp += "*";
                for (int j = 0; j < height - i; j++)
                    temp = " " + temp;
                Console.WriteLine(temp);
            }
        }

        /// <summary>
        /// Isveda deimantini skaiciu modeli pagal vartotojo nurodyta auksti
        /// </summary>
        public static void PenktojiUzduotis()
        {
            int height = GetPyramidHeight("deimanto");

            PrintPyramid(height);
            PrintPyramidInverted(height - 1, true);
        }

        /// <summary>
        /// Isveda kairiojo trikampio skaiciu modeli pagal vartotojo nurodyta auksti
        /// </summary>
        public static void SestojiUzduotis()
        {
            PrintTriangle(GetPyramidHeight("kairiojo trikampio"));
        }

        /// <summary>
        /// Atspausdina kairiojo trikampio skaiciu modelis pagal nurodyta auksti
        /// </summary>
        /// <param name="height"></param>
        public static void PrintTriangle(int height)
        {
            if (height == -1)
                return;
            string temp;
            Console.WriteLine();
            for (int i = 1; i <= height; i++)
            {
                temp = "*";
                for (int j = 1; j < i; j++)
                    temp += "*";
                for (int j = 0; j < height - i; j++)
                    temp += " ";
                Console.WriteLine(temp);
            }
        }

        /// <summary>
        /// Sukuria studentu sarasa ir patikrina, kurie studentai turi pazymi mazesni uz 50
        /// </summary>
        public static void Task1()
        {
            List<Student> students = new List<Student>();

            AddStudents(ref students);
            ListAllItems(ref students);
            if (!CheckForLowGrade(ref students))
                Console.WriteLine("There are no students with a grade less than 50");
        }

        /// <summary>
        /// Prideda studentus i studentu sarasa
        /// </summary>
        /// <param name="students"></param>
        public static void AddStudents(ref List<Student> students)
        {
            students.Add(new Student("Marius", 86));
            students.Add(new Student("Petras", 47));
            students.Add(new Student("Jonas", 98));
            students.Add(new Student("Lukas", 26));
            students.Add(new Student("Tomas", 51));
        }

        /// <summary>
        /// Atspausdina studentu sarasa
        /// </summary>
        /// <param name="students"></param>
        public static void ListAllItems(ref List<Student> students)
        {
            foreach (Student student in students)
                Console.WriteLine(student);
            Console.WriteLine();
        }

        /// <summary>
        /// Patikrina, kurie studentai pazymi, kuris yra mazesnis uz 50
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static bool CheckForLowGrade(ref List<Student> students)
        {
            bool bFound = false;

            Console.WriteLine("Looking for students with a grade lower than 50...");
            foreach (Student student in students)
            {
                if (student.Grade < 50)
                {
                    bFound = true;
                    Console.WriteLine(student);
                }
            }
            return bFound;
        }

        /// <summary>
        /// Sukuria knygu sarasa ir patikrina, kurios knygos yra isnuomotos
        /// </summary>
        public static void Task2()
        {
            List<Book> books = new List<Book>();

            AddBooks(ref books);
            ListAllItems(ref books);
            if (!CheckForRentedBooks(ref books))
                Console.WriteLine("There are no rented books");
        }

        /// <summary>
        /// Sukuria knygu sarasa
        /// </summary>
        /// <param name="books"></param>
        public static void AddBooks(ref List<Book> books)
        {
            books.Add(new Book("Story of Ferdinand", true));
            books.Add(new Book("Mouse and the Motorcycle", false));
            books.Add(new Book("Lenin's Tomb", false));
            books.Add(new Book("Great Stink", true));
            books.Add(new Book("Lovely Bones", false));
        }

        /// <summary>
        /// Atspausdina knygu sarasa
        /// </summary>
        /// <param name="books"></param>
        public static void ListAllItems(ref List<Book> books)
        {
            foreach (Book book in books)
                Console.WriteLine(book);
            Console.WriteLine();
        }

        /// <summary>
        /// Patikrina, kurios knygos yra isnuomotos
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        public static bool CheckForRentedBooks(ref List<Book> books)
        {
            bool bFound = false;

            Console.WriteLine("Looking for books that are rented...");
            foreach (Book book in books)
            {
                if (book.bIsRented)
                {
                    bFound = true;
                    Console.WriteLine(book);
                }
            }
            return bFound;
        }

        /// <summary>
        /// Sudaro produktu sarasa ir apskaiciuoja bendra produktu kaina
        /// </summary>
        public static void Task3()
        {
            List<Product> products = new List<Product>();

            AddProducts(ref products);
            ListAllItems(ref products);
            Console.WriteLine($"Total price of products: {CheckTotalPrice(ref products)} Eur");
        }

        /// <summary>
        /// Sudaro produktu sarasa
        /// </summary>
        /// <param name="products"></param>
        public static void AddProducts(ref List<Product> products)
        {
            products.Add(new Product("Bread", 1.29));
            products.Add(new Product("Milk", 1.59));
            products.Add(new Product("Eggs", 1.89));
            products.Add(new Product("Soap", 2.19));
            products.Add(new Product("Water", 1.19));
        }

        /// <summary>
        /// Atspausdina produktu sarasa
        /// </summary>
        /// <param name="products"></param>
        public static void ListAllItems(ref List<Product> products)
        {
            foreach (Product product in products)
                Console.WriteLine(product);
            Console.WriteLine();
        }

        /// <summary>
        /// Grazina bendra visu produktu kaina
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public static double CheckTotalPrice(ref List<Product> products)
        {
            double totalPrice = 0.00;

            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }
            return Math.Round(totalPrice, 2);
        }

        /// <summary>
        /// Uzsakymu sistema
        /// </summary>
        public static void OrderSystem()
        {
            List<Product> products = new List<Product>();

            AddProducts(ref products);
            ListAllItems(ref products);
            List<Order> orders = new List<Order>();
            ReadOrders(ref orders, ref products);
            if(orders.Count > 0)
                WritePriceOfAllOrders(ref orders);
        }

        /// <summary>
        /// Nuskaito uzsakymu skaiciu ir uzsakymus (kliento duomenys, kiek ir kokiu produktu yra uzsakoma
        /// Taip pat atspausdina kiekvieno uzsakymo kaina
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="products"></param>
        public static void ReadOrders(ref List<Order> orders, ref List<Product> products)
        {
            Console.Write("Enter how many orders you need: ");
            if (!int.TryParse(Console.ReadLine(), out int totalOrders) || totalOrders < 1)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            string vardas;
            string pavarde;
            for (int i = 0; i < totalOrders; i++)
            {
                Console.WriteLine($"/// Order Nr. {i + 1} ///");
                Console.Write("Enter client name: ");
                vardas = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter client surname: ");
                pavarde = Console.ReadLine() ?? string.Empty;
                orders.Add(new Order(vardas, pavarde));

                for (int j = 0; j < products.Count; j++)
                {
                    Console.Write($"Enter amount of {products[j].Name} to order: ");
                    if (!int.TryParse(Console.ReadLine(), out int amount) || amount < 0)
                    {
                        Console.WriteLine("Neteisinga ivestis!");
                        j--;
                    }
                    else if (amount > 0)
                        orders.Last().AddProduct(products[j], amount);
                }
                Console.WriteLine();
                Console.WriteLine($"Created order for {orders.Last().Client}");
                Console.WriteLine(orders.Last());
            }
        }

        /// <summary>
        /// Atspausdina bendra visu uzsakymu kaina
        /// </summary>
        /// <param name="orders"></param>
        public static void WritePriceOfAllOrders(ref List<Order> orders)
        {
            double totalPrice = 0.00;

            foreach (Order order in orders)
                totalPrice += order.GetTotalPrice();
            Console.WriteLine($"Total price of all orders: {totalPrice} Eur");
        }
    }
}
