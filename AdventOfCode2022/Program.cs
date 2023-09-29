// See https://aka.ms/new-console-template for more information
using AdventOfCode2022.Day1;
using AdventOfCode2022.Day2;

Console.WriteLine("Advent of Code 2022");
var day1 = new Day1();
day1.Run();

var day2 = new Day2();
day2.Run();



public class Day1
{
    private readonly string foodCarriedByElfsDataFilePath = @"c:\dev\AdventOfCode2022\AdventOfCode2022\Day1\PuzzleInput\ElfsCarryingFood.txt";
    private readonly string[] data;
    private readonly FoodCarriedByElfsDataReader dataReader = new FoodCarriedByElfsDataReader();
    private readonly CaloriesCounter caloriesCounter = new CaloriesCounter();
    public Day1()
    {
        data = File.ReadAllLines(foodCarriedByElfsDataFilePath);
        dataReader = new FoodCarriedByElfsDataReader();
        caloriesCounter = new CaloriesCounter();
    }
    public void Run()
    {
        var caloriesByElfs = dataReader.Read(data);
        Console.WriteLine("Day 1");
        Console.WriteLine("=======================");
        Console.WriteLine("Highest calories counter: " + caloriesCounter.HighestCalorieCount(caloriesByElfs));
        Console.WriteLine("Total of the top 3 calories counter: " + caloriesCounter.TotalTop3HighestCalorieCount(caloriesByElfs));
    }
}

public class Day2
{
    private readonly string rockPaperScissorsStrategyGuide = @"c:\dev\AdventOfCode2022\AdventOfCode2022\Day2\PuzzleInput\RockPaperScissors.txt";
    private readonly string[] encryptedData;
    public Day2()
    {
        encryptedData = File.ReadAllLines(rockPaperScissorsStrategyGuide);
        Console.WriteLine("Day 2");
        Console.WriteLine("=======================");
        var total = 0;
        var decryptedData = RockPaperScissorsStrategyDecrypt.Decrypt(encryptedData);
        decryptedData.ForEach(x => total += RockPaperScissorsGame.RoundScore(x.opponentChoice, x.myChoice));
        Console.WriteLine("Total game score is: " + total);

        total = 0;
        decryptedData = RockPaperScissorsStrategyDecrypt.DecryptAndCalculateNextChoice(encryptedData);
        decryptedData.ForEach(x => total += RockPaperScissorsGame.RoundScore(x.opponentChoice, x.myChoice));
        Console.WriteLine("Total game score considering required ending is: " + total);

    }
    public void Run()
    {

    }
}