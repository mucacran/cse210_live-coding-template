using System;
using System.Collections.Generic;
using LiveCoding;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>(){
            "Paper",
            "Scissors",
            "Rock",
            "Lizard",
            "Spock"
        };
        Console.WriteLine($"este es lo que esta dentro de: {string.Join(", ", list)}");

        list.Sort();

        Console.WriteLine($"este es lo que esta dentro de: {string.Join(", ", list)}");


        List<Rpsls> list2 = new List<Rpsls>(){
            new Rpsls(Rpsls.Hand.Paper),
            new Rpsls(Rpsls.Hand.Scissors),
            new Rpsls(Rpsls.Hand.Rock),
            new Rpsls(Rpsls.Hand.Lizard),
            new Rpsls(Rpsls.Hand.Spock)
        };

        Console.WriteLine($"este es lo que esta dentro de: {string.Join(", ", list2)}");


        Console.WriteLine();
        Console.WriteLine();

        List<int> list3 = new List<int>(){
            1,
            3,
            2,
            5,
            4
        };
        Console.WriteLine($"este es lo que esta dentro de: {string.Join(", ", list3)}");

        list3.Sort();

        Console.WriteLine($"este es lo que esta dentro de: {string.Join(", ", list3)}");

        //Rpsls rpsls = new Rpsls(Rpsls.Hand);

        LiveCoding.Hand myHand = LiveCoding.Hand.Rock;


        Console.WriteLine(myHand);

        

         

    }
}
