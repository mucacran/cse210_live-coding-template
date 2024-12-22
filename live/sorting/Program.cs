using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using LiveCoding;

class Program
{
    static void Main(string[] args)
    {


        List<Rpsls> newList = new List<Rpsls>{
            new Rpsls (Rpsls.Hand.Lizard),
            new Rpsls (Rpsls.Hand.Paper),
            new Rpsls (Rpsls.Hand.Rock),
            new Rpsls (Rpsls.Hand.Scissors),
            new Rpsls (Rpsls.Hand.Spock)
            };

        foreach(Rpsls Text in newList){
            Console.WriteLine(Text);
        }

        Random valorR = new Random();

        Console.WriteLine($"Su cantidad es: {valorR.Next(newList.Count)}");

        //Rpsls roca = new Rpsls(Rpsls.Hand.Rock);
        //Rpsls tijeras = new Rpsls(Rpsls.Hand.Scissors);
        //Rpsls papel = new Rpsls(Rpsls.Hand.Paper);
        Rpsls valor1 = newList[valorR.Next(newList.Count)];
        Rpsls valor2 = newList[valorR.Next(newList.Count)];
        Rpsls valor3 = newList[valorR.Next(newList.Count)];

/*
        string papel1 = papel.ToString();
        string roca1 = roca.ToString();
        string tijeras1 = tijeras.ToString();
*/


        string valorNew1 = valor1.ToString();
        string valorNew2 = valor2.ToString();
        string valorNew3 = valor3.ToString();



        Console.WriteLine("-> " + valorNew1);
        Console.WriteLine("-> " + valorNew2);





/*
        string papel = papel.ToString();
        string roca = roca.ToString();*/

        /**********************************************/

        //List<Rational> listNum = new Rational();


        

    }
}