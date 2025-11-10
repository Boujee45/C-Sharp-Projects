using System;
using System.ComponentModel.Design;
using System.Reflection;
namespace EG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            String[] friends = { "jane", "Oscar", "Boujee", "Jacinta" };
            //String[] friends1 = new String[5];

            String exp = "";

            foreach (String friend in friends)
            {
                Console.WriteLine(friend);
            }

            for(int i = 0; i < friends.Length;i++)
            {
                if(exp != "")
                {
                    exp += ",";
                }
                exp += friends[i];
                //Console.WriteLine(friends[i]);
            }
            Console.WriteLine(exp);*/

            /*  double total = Checkout(4.99, 3.45, 5.55, 6.77);

              Console.WriteLine(total);

          }
          static double Checkout(params double[] prices)
          {
              double total = 0;

              foreach(double price in prices)
              {
                  total += price;
              }
              return total;
          }*/
            /*int temp = 60;
            String care = (temp < 50) ? "Its cold you should wear a hoodie" :
                "Its warm outside get out and play";

            Console.WriteLine(care);

            String[,] languages =
            {
                {"HTML","CSS","JS"},
                {"PHP","JAVA","Cs"},
                {"C++","C","Perl"}

            };

            for(int i = 0;i < languages.GetLength(0);i++)
            {
                for(int j = 0;j < languages.GetLength(1);j++)
                {
                    Console.WriteLine(languages[i,j]);
                }
                
            }*/

            /*List<string> liverpoolPlayers = new List<string>();

            liverpoolPlayers.Add("Alisson Becker");
            liverpoolPlayers.Add("Van Djik");
            liverpoolPlayers.Add("Konate");
            liverpoolPlayers.Add("Bradley");
            liverpoolPlayers.Add("Robertson");
            liverpoolPlayers.Add("Mac Allister");
            liverpoolPlayers.Add("Szoboszlai");
            liverpoolPlayers.Add("Gravenberch");
            liverpoolPlayers.Add("Mo Salah");
            liverpoolPlayers.Add("Luis Diaz");
            liverpoolPlayers.Add("Diogo Jota");
            liverpoolPlayers.Add("Darwin Nunez");

            liverpoolPlayers.Insert(7, "Curtis Jones");
            
            liverpoolPlayers.Reverse();

            liverpoolPlayers.Remove("Diogo Jota");

            String[] liverpoolPlayersArray = liverpoolPlayers.ToArray();

            foreach(String liverpool in liverpoolPlayers)
            {
                Console.WriteLine(liverpool);
                
            }
            Console.WriteLine(liverpoolPlayers.Count);*/

            /*Car car1 = new Car("Ford",80);
            Car car2 = new Car("Mustang",90);
            Car car3 = new Car("Mercedes",180);

            Car[] garage =
            {
                new Car("Ford",80),
                new Car("Mustang",90),
                new Car("Mercedes",180)
            };

            Boat boat = new Boat("Ferry", 99);

            vehicle vehicle1 = new vehicle("Blue", "Lambo", "2020");

            Console.WriteLine(vehicle1.ToString());

            Console.WriteLine($"Number of cars = {Car.numberCars}");
            garage[0].displayInfo();
            garage[1].Race();

            
            boat.displayInfo();*/
            /*
            List<Movie> list = new List<Movie>();

            list.Add(new Movie("Shrek", "shrek", "PG"));

            foreach (Movie movie in list)
            {
                Console.WriteLine(movie.title);
            }

            Movie movie1 = new Movie("Avengers", "Joss Whedon", "PG");
            movie1.Rating = "oscar";

            Console.WriteLine(movie1.Rating);

            int[] Iarray = { 1, 2, 3, 4, 5, 6, 6, 7, 7, 8, 8, 9, 9, 9 };

            displayElements(Iarray);

            Console.Write(Planets.Mercury + "=" + (int)Planets.Mercury);
            */

        }
    }
}
       /* public static void displayElements<T> (T[] array)
        {
            foreach(T item in array)
            {
                Console.Write(item + ",");
            }
        }
        enum Planets
        {
            Mercury = 1,
            Venus = 2,
            Mars = 3,
            Earth = 4,
        }

    }

}

/*interface IRace
{
    void Race();
}*/

/*public /*abstract*/ /*class Car:IRace
{
    public string name;
    public static int numberCars;
    public int speed;

    public Car(string name,int speed)
    {
        this.name = name;
        this.speed = speed;
        numberCars++;
    }
    public virtual void displayInfo()
    {
        Console.WriteLine($"This cars model is: {name} and has a speed of {speed} Km/hr");
    }
    public void Race()
    {
        Console.WriteLine("The race has started!");
    }

}
public class Boat:Car
{
    public Boat(String name,int speed):base(name,speed)
    {
        this.name = name;
        this.speed = speed;
    }
    public override void displayInfo()
    {
        //base.displayInfo();
        Console.WriteLine($"This boats model is: {name} and has a speed of {speed} Km/hr");
    }
}
public class vehicle
{
    public string color;
    public string model {get; set;}
    public string year;

    public vehicle(String color, String model, String year)
    {
        this.color = color;
        this.model = model;
        this.year = year;
    }
    public string ToString()
    {
        return "This is a " + model + " " + "Color: " + color + " Year: " + year;
    }
}*/


/*public class Movie
{
    public string title;
    public string director;
    private string rating;

    public Movie(string title, string director, string aRating)
    {
        this.title = title;
        this.director = director;
        rating = aRating;

    }

    public string Rating
    {
        get { return rating; }

        set
        {
            if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
            {
                rating = value;
            }
            else
            {
                rating = "NR";
            }
        }
    }
}*/