using CSharpPractice;

Solution.PlusMinus([-4, 3, -9, 0, 4, 1]);

var diagonalDiff = Solution.DiagonalDifference([new List<int> { 11, 2, 4 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 8, -12 }]);
Console.WriteLine($"Diagonal Difference of a square matrix is :{diagonalDiff}");

Solution.SingleNumber([4, 1, 2, 1, 2]);

var twoSum = Solution.TwoSum([2, 7, 11, 15], 9);
Console.WriteLine($"The indices of two numbers that add up to a target number : {twoSum[0]} {twoSum[1]}");

Solution.PlusOne([1, 2, 3]);

Person person = new("Robert", "Walpole");

Console.WriteLine("Who was UK's first prime minister?");

string fullName = Console.ReadLine();

if (person.FullName == fullName)
{
    Console.WriteLine("Hey! You entered correct name! You won!");
}
else
{
    Console.WriteLine("Guessed wrong name... Try again!");
}

