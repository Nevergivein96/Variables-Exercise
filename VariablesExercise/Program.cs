
using System.Transactions;

string firstName = "Spencer";
char lastNameInitial = 'H';
decimal currentWeight = 198.8m;
int desiredWeightClass = 170;
double amountToLose = 28.8;
bool possibility = true;

Console.WriteLine($"{firstName}, {lastNameInitial}");
Console.WriteLine($"Has a current weigth of{currentWeight}lbs");
Console.WriteLine($"Weight goal of {desiredWeightClass}lbs");
Console.WriteLine($"Need to lose {amountToLose} lbs");
Console.WriteLine($"I this a good weight goal? true=yes false=no");
Console.WriteLine($"{possibility}");