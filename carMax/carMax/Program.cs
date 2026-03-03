using System;
using System.Numerics;
using System.Text.RegularExpressions;

class Program
{
    static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("======================================================================");
            Console.WriteLine("                       CAR MAX PETROL STATION                         ");
            Console.WriteLine("======================================================================");

            Double superPetrol = 193.84;
            Double vPower = 205.25;
            Double Diesel = 183.38;
            Double carWash = 300;
            Double cost = 0;
            //String fuel;
            Double Total = 0;
            String serviceName = "";

            Console.Write("\nAttendants name: ");
            String attName = Console.ReadLine();

            DateTime start = DateTime.Now;
            Console.WriteLine($"Start Time: {start:HH:mm:ss}");

            List<String> records = new List<string>();

            while (true)
            {
                Console.WriteLine("\nServices: ");
                Console.WriteLine("\t1. Fuelling");
                Console.WriteLine("\t2. Car Wash");
                Console.WriteLine("\t3. Both");
                Console.WriteLine("\t4. Exit");

                Console.Write("Choose a service: ");
                String service = Console.ReadLine().ToUpper();

                while (service != "1" && service != "3" && service != "FUELLING" && service != "BOTH" &&
                    service != "4" && service != "EXIT" && service != "2" && service != "CAR WASH")
                {
                    Console.WriteLine("\nInvalid Input!");

                    Console.WriteLine("\nServices: ");
                    Console.WriteLine("\t1. Fuelling");
                    Console.WriteLine("\t2. Car Wash");
                    Console.WriteLine("\t3. Both");
                    Console.WriteLine("\t4. Exit");
                    Console.Write("Choose a service: ");
                    service = Console.ReadLine().ToUpper();
                }

                if (service == "4" || service == "EXIT")
                {
                    break;
                }
                else if (service == "1" || service == "3" || service == "FUELLING" || service == "BOTH")
                {
                    Console.WriteLine("\nFuels: ");
                    Console.WriteLine("\t1. Diesel");
                    Console.WriteLine("\t2. Super ");
                    Console.WriteLine("\t3. vPower");

                    Console.Write("\nEnter the vehicle Reg No: ");
                    String regNo = Console.ReadLine();

                    Console.Write("\nEnter the type of fuel: ");
                    String fuel = Console.ReadLine().ToUpper();

                    while (fuel != "DIESEL" && fuel != "SUPER" && fuel != "VPOWER" && fuel != "1"
                        && fuel != "2" && fuel != "3")
                    {
                        Console.WriteLine("\nInvalid input: ");
                        Console.WriteLine("\tPlease enter(Diesel,Super or vPower)!");

                        Console.Write("\nEnter the type of fuel: ");
                        fuel = Console.ReadLine().ToUpper();

                    }

                    Console.Write("\nEnter the no. of litres: ");
                    Double litres = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nCar Wash(Y or N): ");
                    String carClean = Console.ReadLine().ToUpper();

                    while (carClean != "Y" && carClean != "N")
                    {
                        Console.WriteLine("\nInvalid Input!");
                        Console.WriteLine("Please Enter(Y or N)!");

                        Console.Write("\nCar Wash(Y or N): ");
                        carClean = Console.ReadLine().ToUpper();

                    }

                    serviceName = "Fuelling";

                    if (fuel == "DIESEL")
                    {
                        Total = Diesel * litres;
                    }
                    else if (fuel == "SUPER")
                    {
                        Total = superPetrol * litres;
                    }
                    else
                    {
                        Total = vPower * litres;
                    }

                    if (carClean == "Y" || service == "3" || service == "BOTH")
                    {
                        cost = carWash + Total;
                        serviceName = "Fuelling,Car Wash";

                        records.Add($"{regNo} {serviceName} Ksh {Math.Round(cost, 4)}");
                    }
                    else if (carClean == "N")
                    {
                        cost = Total;
                        records.Add($"{regNo} {serviceName} Ksh {Math.Round(cost, 4)}");
                    }


                }

                else if (service == "2" || service == "CAR WASH")
                {
                    Console.WriteLine("\nCar Wash = ksh 300.0");

                    Console.Write("\nEnter the vehicle Reg No: ");
                    String regNo = Console.ReadLine();

                    serviceName = "Car Wash";

                    cost = carWash;

                    records.Add($"{regNo} {serviceName} Ksh {Math.Round(cost, 4)}");
                }

                else
                {
                    Console.WriteLine("\nInvalid Input!");
                }

                Console.WriteLine();

                foreach (var i in records)
                {
                    Console.WriteLine(i);
                }


                Console.Write("\nDo you wish to  attend the next client:(Y or N): ");
                String choice = Console.ReadLine().ToUpper();

                if (choice == "N")
                {
                    break;
                }
                else if (choice == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("\nInvalid input!");
                    break;
                }
            }
            DateTime end = DateTime.Now;

            /*foreach(var i in records)
            {

                Console.WriteLine($"{i}");
            }*/

            Console.WriteLine("\n================================================");
            Console.WriteLine("              CAR MAX PETROL STATION            ");
            Console.WriteLine("================================================");

            Console.WriteLine($"\nAttendant: {attName}");
            Console.WriteLine($"Shift Start: {start}");
            Console.WriteLine($"Shift End: {end}");

            Console.WriteLine();

            Double totalCash = 0;

            Console.WriteLine("Register: ");
            for (int i = 0; i < records.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {records[i]}");
                totalCash += cost;
            }

            Console.WriteLine($"\n\t\t\t\tTotal: Ksh {Math.Round(totalCash, 4)}");


            Console.WriteLine("================================================");

            Console.WriteLine("\n======================================================================");
        }
        catch (Exception e)
        {
            Console.WriteLine("\nINVALID INPUT!");
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
