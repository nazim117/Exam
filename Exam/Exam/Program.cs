/*
200 90 40 100
20 40 30 50
50 60 80 90

40 66 123 100
10 30 70 33
40 55 77 100

*/

Stack<int> fuelSequence = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Queue<int> consumptionIndexSequence = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> necessaryAmount = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int altitudeCount = 0;
int totalAltitudes = necessaryAmount.Count;
while (fuelSequence.Any() && consumptionIndexSequence.Any() && necessaryAmount.Any())
{
    int currentFuel = fuelSequence.Pop();
    int consumption = consumptionIndexSequence.Dequeue();
    int necessaryFuel = necessaryAmount.Dequeue();
    if (currentFuel - consumption >= necessaryFuel)
    {
        altitudeCount++;
        Console.WriteLine($"John has reached: Altitude {altitudeCount}");

    }
    else
    {
        int notReachedAltitudeCount = altitudeCount;
        notReachedAltitudeCount++;
        Console.WriteLine($"John did not reach: Altitude {notReachedAltitudeCount}");
        break;
    }
}

if (necessaryAmount.Any())
{
    Console.WriteLine("John failed to reach the top.");
    if (altitudeCount ==0)
    {
        Console.WriteLine("John didn't reach any altitude.");
    }
    else
    {
        if (altitudeCount == 1)
        {
            Console.Write($"Reached altitudes: Altitude 1");
        }
        else
        {
            Console.Write($"Reached altitudes: Altitude 1");
            for (int i = 2; i <= altitudeCount; i++)
            {
                Console.WriteLine($", Altitude {i}");
            }
        }
        
    }
}
else
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}


