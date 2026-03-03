using System;

public class Program
{
    public static void Main(String[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("                   DATA STRUCTURES                  ");
            Console.WriteLine("====================================================");

            Console.WriteLine("\n\t1. Arrays");
            Console.WriteLine("\t2. Linked List");
            Console.WriteLine("\t3. Stacks");
            Console.WriteLine("\t4. Queues");
            Console.WriteLine("\t5. Exit");

            Console.Write("\nEnter a choice(1 - 5): ");
            String choice = Console.ReadLine();

            if(choice != "1" && choice != "2" && choice != "3"  && choice != "4" && choice != "5")
            {
                Console.WriteLine("\nInvalid Input! (Enter 1 - 5)");
                Console.ReadKey();
                continue;
            }
          
            if (choice == "5")
            {
                break;
            }

            if(choice == "1")
            {
                int[] scores = new int[10];
                int count = 0;

                Console.WriteLine("\nEnter 10 student scores: ");

                for(int i = 0; i < 10; i++)
                {
                    Console.Write($"Score {i + 1} (or press Enter to stop): ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input)) break;

                    /*int val = int.Parse(input);

                    scores[count++] = val;*/

                    if(int.TryParse(input,out int val))
                    {
                        scores[count++] = val;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid number - skipped!");
                        i--;
                    }

                }
                while(true)
                {
                    Console.Clear();
                    Console.WriteLine("====================================");
                    Console.WriteLine("                ARRAYS              ");
                    Console.WriteLine("====================================");

                    Console.WriteLine("\nArray current state: ");

                    Console.Write("[");
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(scores[i] + " ");
                    }
                    Console.WriteLine("]");

                    Console.WriteLine("\n\ta. Insert a new Score");
                    Console.WriteLine("\tb. Delete a Score");
                    Console.WriteLine("\tc. Search for a Score");
                    Console.WriteLine("\td. Update  Score");
                    Console.WriteLine("\te. Back to Main Menu");

                    Console.Write("\nChoice: ");
                    String arr = Console.ReadLine();

                    Console.WriteLine("\n====================================");

                    if (arr == "e")
                    {
                        break;
                    }

                    if(arr == "a")
                    {
                        
                        
                        Console.Write($"Enter the index (0 to {count}): ");

                        if(!int.TryParse(Console.ReadLine(),out int index) || 
                            index < 0 || index > count || index == 10)
                        {
                            Console.WriteLine("\nInvalid index or array full!");
                            continue;
                        }

                        Console.Write("Enter the Score: ");

                        if (!int.TryParse(Console.ReadLine(), out int Score))
                        {
                            Console.WriteLine("\nInvalid Score!");
                            continue;
                        }

                        //scores[index] = Score;

                        for(int i = count; i > index; i--)
                        {
                            scores[i] = scores[i - 1];
                            
                        }
                        scores[index] = Score;
                        count++;


                    }

                    if(arr == "b")
                    {
                        Console.Write($"Enter the index (0 to {count}): ");

                        if (!int.TryParse(Console.ReadLine(), out int index) ||
                            index < 0 || index > count || index == 10)
                        {
                            Console.WriteLine("\nInvalid index or array full!");
                            continue;
                        }

                        
                        for (int i = index; i < count - 1; i++)
                        {
                            scores[i] = scores[i + 1];

                        }
                       
                        count--;
                    }

                    if (arr == "c")
                    {
                        Console.Write("Enter a value to search for: ");
                        if (!int.TryParse(Console.ReadLine(), out int val))
                        {
                            Console.WriteLine("Invalid number! ");
                        }

                        int pos = -1;

                        for(int i = 0; i < scores.Length; i++)
                        {
                            if (scores[i] == val)
                            {
                                pos = i;
                                break;
                            }
                            
                        }
                        Console.WriteLine($"{val} found at index {pos}");
                    }

                    if (arr == "d")
                    {


                        Console.Write($"Enter the index to update: ");

                        if (!int.TryParse(Console.ReadLine(), out int index) ||
                            index < 0 || index >= count)
                        {
                            Console.WriteLine("\nInvalid index!");
                            continue;
                        }

                        Console.Write("Enter the new value: ");

                        if (!int.TryParse(Console.ReadLine(), out int Score))
                        {
                            Console.WriteLine("\nInvalid Score!");
                            continue;
                        }

                        scores[index] = Score;

                    }

                    

                }
                

                
            }
            
        }

    } 

}


