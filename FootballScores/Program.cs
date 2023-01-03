// See https://aka.ms/new-console-template for more information
using FootballScores;
using System.Runtime.CompilerServices;

//TODO: Tratar erro de conversão de número em todos os ReadLine

Console.WriteLine("Enter the number of matches for Team A");

int sizeTeamA = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Enter the number of goals in matches for Team A, one per line");

List<int> goalsTeamA = new List<int>();

for (int i = 0; i < sizeTeamA; i++)
{
    goalsTeamA.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine();
Console.WriteLine("Enter the number of matches for Team B");
int sizeTeamB = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Enter the number of goals in matches for Team B, one per line");

List<int> goalsTeamB = new List<int>();

for (int i = 0; i < sizeTeamB; i++)
{
    goalsTeamB.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine();
Console.WriteLine("Calculating the result");
Console.WriteLine();

//int[] result = new Business().Calculate(goalsTeamA, goalsTeamB);
int[] result = new Business().CalculateBetter(goalsTeamA, goalsTeamB);

Console.WriteLine($"Result = [ { string.Join(", ", result) } ]");