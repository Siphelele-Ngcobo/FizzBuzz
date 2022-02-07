// See https://aka.ms/new-console-template for more information
int num1, num2;
String strNum1, strNum2;
String inError = "\nInput has to be a number & cannot be blank, please try again";

//set to repeat request if input is left blank or it is impossible to parse it to an integer 
do
{
	Console.WriteLine("Please input the first number");  //asking for 1st  user input
	strNum1 = Console.ReadLine().Trim();
	if (String.IsNullOrWhiteSpace(strNum1) || !int.TryParse(strNum1, out num1))
		Console.WriteLine(inError);
} while (String.IsNullOrWhiteSpace(strNum1) || !int.TryParse(strNum1, out num1)); //validating input

// Converting input to integer after validation
num1 = Convert.ToInt32(strNum1);

//set to repeat request if input is left blank or it is impossible to parse it to an integer
do
{
	Console.WriteLine("Please input second number");  //ask for 2nd user input
	strNum2 = Console.ReadLine().Trim();
	if (String.IsNullOrWhiteSpace(strNum2) || !int.TryParse(strNum2, out num2))
		Console.WriteLine(inError);
} while (String.IsNullOrWhiteSpace(strNum2) || !int.TryParse(strNum2, out num2)); //validating input 

// Converting input to integer after validation
num2 = Convert.ToInt32(strNum2);

while (num1 >= num2)
{
	Console.WriteLine("\nError, the second number cannot be equal to or smaller than the first.");
	do
	{
		Console.WriteLine("Please input second number");  //ask for 2nd user input
		strNum2 = Console.ReadLine().Trim();
		if (String.IsNullOrWhiteSpace(strNum2) || !int.TryParse(strNum2, out num2))
			Console.WriteLine(inError);
		//validating input
		//set to repeat request if input is left blank or it is impossible to parse it to an integer 

	} while (String.IsNullOrWhiteSpace(strNum2) || !int.TryParse(strNum2, out num2));
}

//output loop
for (int x = num1; x <= num2; x++)
{
	if (x % 3 == 0 && x % 5 == 0)
	{
		Console.WriteLine("FizzBuzz");
	}

	else if (x % 3 == 0)
	{
		Console.WriteLine("Fizz");
	}
	else if (x % 5 == 0)
	{
		Console.WriteLine("Buzz");
	}

	else
		Console.WriteLine(x);
}

Console.ReadLine();
