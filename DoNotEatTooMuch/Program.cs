Console.WriteLine("Watch Your Intake!");

var HealthyPerson = 50;

var fruit = 10;
var soda = 20;
var water = 0;
var candy = 20;
var exercise = 5;

var counter = 4;


while (HealthyPerson >= 0 && counter >= 0)
{
    Console.WriteLine("You are healthy");
   
    Console.WriteLine();
        Console.WriteLine($"Healthy Person - {HealthyPerson}");
        Console.WriteLine($"Choose an item from 'f' for fruit, 's' soda, 'w' water, 'c' for candy or 'e' for exercise! ");
        var item = Console.ReadLine();

        if (item == "f")
        {
            Console.WriteLine();
            HealthyPerson -= fruit;
        }
        else if (item == "s")
        {
            HealthyPerson -= soda;
        }
        else if (item == "w")
        {
            HealthyPerson -= water;
        }
        else if (item == "c")
        {
            HealthyPerson -= candy;
        }
        else if (item == "e")
        {
            HealthyPerson += exercise;
        }
        else
        {
            Console.WriteLine("Invalid Character!!");
        }

        counter--;
}
    Console.WriteLine();
    //Console.WriteLine("YOU ARE HEALTHY!");
















