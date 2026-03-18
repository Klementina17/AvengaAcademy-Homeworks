//On one tree there are 12 branches with n apples on them.
//One basket can hold m apples.
//If a user enters the number of trees, calculate how many baskets are needed to collect all apples.

Console.WriteLine("Enter the number of trees: "); 

bool isParsedNumOfTrees = int.TryParse(Console.ReadLine(), out int numberOfTrees); 
int branchesOnOneTree = 12; 
int limitOfApplesInOneBasket = 8; 
int totalNumberOfApplesOnOneBranch = 8; 

if (!isParsedNumOfTrees) 
{ Console.WriteLine("Please enter valid number. "); 
} 

int sumOfApples = (numberOfTrees*branchesOnOneTree) * totalNumberOfApplesOnOneBranch; 
int neededBasketsForAllApples = sumOfApples / limitOfApplesInOneBasket; 
Console.WriteLine("The sum of all apples is: " + sumOfApples); 
Console.WriteLine("And we need " + neededBasketsForAllApples + " baskets to collect all apples.");