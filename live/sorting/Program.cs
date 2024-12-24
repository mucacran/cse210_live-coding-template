using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using LiveCoding;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ordenando numeros Racionales");
        List<Rational> listNum = new List<Rational> {
            new Rational(4,5),
            new Rational(8,2),
            new Rational(5,4),
            new Rational(2,1),
            new Rational(4,3),
        };

        Console.WriteLine(string.Join(", ", listNum));

        listNum.Sort(( a,  b) => (a.CompareTo(b)));
        //Array.Sort(listNum);

        Console.WriteLine(string.Join(", ", listNum));

        List<int> numers = new List<int>{
            7,5,3,5,1
        };
        Console.WriteLine("Ordenando numeros naturales");
        Console.WriteLine($"Estos son los numeros sin ordenar: {string.Join(", ", numers)}");
        numers.Sort();
        Console.WriteLine($"Estos son los numeros ordenados: {string.Join(", ", numers)}\n");

        Console.WriteLine("Ordenado texto");
        List<string> palabras = new List<string>{
            "Sergio", "Bravo", "Moran", "Francisco"
        };
        Console.WriteLine($"Estos son las palabras sin ordenar: {string.Join(", ", palabras)}");
        palabras.Sort();
        Console.WriteLine($"Estos son los palabras ordenadas: {string.Join(", ", palabras)}\n");




        List<Rpsls> newList = new List<Rpsls>{
            new Rpsls (Rpsls.Hand.Lizard),
            new Rpsls (Rpsls.Hand.Paper),
            new Rpsls (Rpsls.Hand.Rock),
            new Rpsls (Rpsls.Hand.Scissors),
            new Rpsls (Rpsls.Hand.Spock)
            };



        
/*
        foreach(Rpsls Text in newList){
            Console.WriteLine(Text);
        }
*/
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

        //Rpsls rpsls = new Rpsls();

        Rpsls.enfrentanDosElementos("Paper","Paper");

        Rpsls.enfrentanTresElementos(valorNew1,valorNew2,valorNew3);

/*
Una cosa más que quiero que hagas, y no tiene que ser esta noche. Escribe
* ¿Qué más harías para resolver el problema?
* ¿Cómo usaste la programación orientada a objetos en lo que hiciste?
* ¿Cómo usarías la programación orientada a objetos para resolver todo el problema?

Redacta ese documento y envíamelo.

Ok profesor, ¿lo enviaste en equipos o en Canvas por correo?

Puedes enviármelo de cualquier manera

Voy a redactar el documento lo más pronto, muchas gracias por la paciencia hacia mí y la oportunidad de tener esta reunión

*/

        


    }
}