using System.Linq.Expressions;

class Cal
{
    public double a;
    public double b;
    
    public Cal(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public double Add(double a, double b)
    {
        return a + b;

    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Division(double a, double b)
    {
        return a / b;
    }

}
public class Program
{
    public static void Main()
    {
        try { 
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                     CALCULATOR                        ");
        Console.WriteLine("-------------------------------------------------------");

        int Choice;
        Console.Write("Enter a number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter another number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n\t0. : Exit");
        Console.WriteLine("\t1. : Add");
        Console.WriteLine("\t2. : Subtract");
        Console.WriteLine("\t3. : Multiply");
        Console.WriteLine("\t4. : Divide");
        Console.WriteLine("\t5. : Reset");

       
        Cal obj = new Cal(a, b);
        Choice = 1;



            while (Choice != 0)
            {
                Console.Write("\nEnter your Choice: ");
                Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    Console.WriteLine($"\nInput1 = {a}");
                    Console.WriteLine($"Input2 = {b}");

                    Console.WriteLine($"\nAdd = {a} + {b} \n\n\t\tAns = {obj.Add(a, b)}");

                }
                else if (Choice == 2)
                {
                    Console.WriteLine($"\nInput1 = {a}");
                    Console.WriteLine($"Input2 = {b}");

                    Console.WriteLine($"\nSubtract = {a} - {b} \n\n\t\tAns = {obj.Subtract(a, b)}");
                }
                else if (Choice == 3)
                {
                    Console.WriteLine($"\nInput1 = {a}");
                    Console.WriteLine($"Input2 = {b}");

                    Console.WriteLine($"\nMultiply = {a} X {b} \n\n\t\tAns = {obj.Multiply(a, b)}");
                }
                else if (Choice == 4)
                {
                    Console.WriteLine($"\nInput1 = {a}");
                    Console.WriteLine($"Input2 = {b}");

                    Console.WriteLine($"\nDivide = {a} / {b} = \n\n\t\tAns = {obj.Division(a, b)}");
                }
                else if (Choice == 0)
                {
                    Console.WriteLine("\nExiting ... ");
                    //Console.WriteLine("--------BYE!------------");
                }
                else if (Choice == 5)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("                     CALCULATOR                        ");
                    Console.WriteLine("-------------------------------------------------------");


                    Console.Write("Enter a number: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter another number: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\t0. : Exit");
                    Console.WriteLine("\t1. : Add");
                    Console.WriteLine("\t2. : Subtract");
                    Console.WriteLine("\t3. : Multiply");
                    Console.WriteLine("\t4. : Divide");
                    Console.WriteLine("\t5. : Reset");


                }
                else
                {
                    Console.WriteLine("INVALID INPUT");
                }
            } 
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine($"\nERROR : {e.Message}");

        }
        catch(FormatException e)
        {
            Console.WriteLine($"\nERROR : {e.Message}");
        }
        catch(Exception e)
        {
            Console.WriteLine($"\nERROR : {e.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\tTHANK YOU FOR USING THE APP.");
            Console.WriteLine("-------------------------------------------------------");

        }


        Console.ReadKey();
    }
}