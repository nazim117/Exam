# Offroad Challenge
There will be two sequences of integers. The first sequence will represent the initial fuel and the second - additional consumption index due to thin air at high altitudes, hence higher fuel consumption. There will also be a third sequence of integers, representing values equal to the necessary amount of fuel needed to reach the corresponding altitude in the challenge.

Your task is to take the last fuel quantity from the fuel sequence and the first index from the additional consumption index sequence. Subtract the values and check the result. 
•	The corresponding altitude is reached if the calculated result is bigger or equal to the first element from the needed amount of fuel sequence. You need to remove both the fuel and the consumption index from their sequences as well as the needed amount of fuel index from their sequence.
•	If the calculated result is smaller or not equal to the first element from the needed amount of fuel sequence, the corresponding altitude is not reached, movement cannot continue, and the program should end.
Input
•	The first line will represent the initial fuel – integers, separated by a single space.
•	The second line will represent the consumption indexes that decrease initial fuel – integers, separated by a single space.
•	The third line will represent the quantities needed to reach the corresponding altitude – integers, separated by a single space.
Output
•	On the first or the next n lines, output the corresponding message on the console from the following options:
	If John reaches the altitude, print the message:
o	"John has reached: Altitude 1"
o	…
o	"John has reached: Altitude {n}"
	If John fails to reach the altitude, print the message:
o	"John did not reach: Altitude {n}"
•	On the next lines, based on whether he reached the top or not, print the following on the console in the specified format:
	If John doesn't have enough fuel to reach the top but has reached some altitude, display the following messages:
o	"John failed to reach the top.
Reached altitudes: Altitude 1, … Altitude {n}"
	If John does not have enough fuel to reach the top and has not reached any altitude, print:
o	"John failed to reach the top.
John didn't reach any altitude."
	If John manages to reach all the altitudes, he will reach the top. End the program and print on the console the following message:
o	"John has reached all the altitudes and managed to reach the top!"

Constraints
•	All the given numbers will be valid integers in the range [1, 200].
•	All sequences always consist of four elements.
•	There will be no negative input.

# Fishing Competition
You will be given an integer n for the size of the fishing area with a square shape. On the next n lines, you will receive the rows of the fishing area. You will be placed in a random position, marked with the letter 'S'. There will be fishing passages on random positions, marked with a single digit. Whirlpools may also be marked with 'W'. All of the empty positions will be marked with '-'.
Each turn until the "collect the nets" command is received you will be given commands for your movement. Move commands will be: "up", "down", "left", and "right".
•	If you move to a fish passage, you collect the amount equal to the digit there, the passage disappears and should be replaced by '-'.
•	If you fall into a whirlpool – the ship sinks and loses its catch, the program ends. 
•	If you leave the fishing area (go out of the boundaries of the matrix) depending on the move command you will be moved to the opposite side of the one you were on. 
/Example: In a 3x3 matrix you are at position [1,2] and receive the command "right" you will be moved to position [1,0]./
 You need at least 20 tons of fish to be considered a successful season. Keep in mind that even if the quotа is reached the ship continues to move.
Input
•	On the first line, you are given the integer n – the size of the square matrix.
•	The next n lines hold the values for every row.
•	On each of the next lines, you will get a move command.
Output
•	On the first line:
	If the ship falls into a whirlpool, print only this message and stop the program: 
o	"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [n,n]"
	If the ship reaches the quota: 
o	"Success! You managed to reach the quota!"
	If the ship did not reach the quota: 
o	"You didn't catch enough fish and didn't reach the quota!
You need {lack of fish} tons of fish more."
•	On the next line.
	If the catch quantity is bigger than zero, print:
o	"Amount of fish caught: {quantity} tons."
	else: do not print anything.
	If you didn't get into a whirlpool, print the matrix.
Constraints
•	The size of the square matrix will be between [2…10].
•	Only the letters 'S' and 'W' will be present in the matrix.
•	The fish passages are represented by single positive digits /tons/ between [1…9].
•	It is expected that there will only be either zero or one whirpool present, marked with the letter - 'W'.
•	Your position will be marked with 'S'.
