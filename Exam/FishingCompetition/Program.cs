/*
4
---S
----
9-5-
34--
down
down
right
down
collect the nets

5
S---9
777-1
W333-
11111
-----
down
down
right
down
collect the nets

*/

int dimensions = int.Parse(Console.ReadLine());

int rows = dimensions;
int cols = dimensions;
int boatRow = 0;
int boatCol = 0;
int caughtFish = 0;

char[,] fishingArea = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
	string currentRow = Console.ReadLine();
	for (int col = 0; col < cols; col++)
	{
		fishingArea[row, col] = currentRow[col];
        if (fishingArea[row, col] == 'S')
        {
            boatRow = row;
            boatCol = col;
            fishingArea[boatRow, boatCol] = '-';
        }
    }
}

string command;
while ((command = Console.ReadLine()) != "collect the nets")
{
    if (command == "up")
    {
        if (boatRow == 0)
        {
            boatRow = rows - 1;
        }
        else
        {
            boatRow--;
        }
    }
    else if (command == "down")
    {
        if (boatRow == rows - 1)
        {
            boatRow = 0;
        }
        else
        {
            boatRow++;
        }
    }
    else if (command == "left")
    {
        if (boatCol == 0)
        {
            boatCol = cols - 1;
        }
        else
        {
            boatCol--;
        }
    }
    else if (command == "right")
    {
        if (boatCol == cols - 1)
        {
            boatCol = 0;
        }
        else
        {
            boatCol++;
        }
    }

    if (char.IsNumber(fishingArea[boatRow, boatCol]))
    {
        caughtFish += int.Parse(fishingArea[boatRow, boatCol].ToString());
        fishingArea[boatRow, boatCol] = '-';
    }
    if (fishingArea[boatRow, boatCol] == 'W')
    {
        caughtFish = 0;
        Console.WriteLine("You fell into a whirlpool! The ship sank and you lost the fish you caught. " +
            $"Last coordinates of the ship: [{boatRow},{boatCol}]");
        break;
    }

}


if (fishingArea[boatRow, boatCol] != 'W')
{
    fishingArea[boatRow, boatCol] = 'S';
    if (caughtFish >= 20)
    {
        Console.WriteLine("Success! You managed to reach the quota!");
    }
    else
    {
        Console.WriteLine("You didn't catch enough fish and didn't reach the quota! " +
            $"You need {20-caughtFish} tons of fish more.");
    }

    if (caughtFish > 0)
    {
        Console.WriteLine($"Amount of fish caught: {caughtFish} tons.");
    }

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(fishingArea[row, col]);
        }
        Console.WriteLine();
    }
}