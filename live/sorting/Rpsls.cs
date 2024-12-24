using System.Runtime.CompilerServices;

namespace LiveCoding
{

    public class Rpsls
    {
        public enum Hand
        {
            Rock,
            Paper,
            Scissors,
            Lizard,
            Spock
        }

        Hand _hand;

        public Rpsls(){}

        public Rpsls(Rpsls.Hand hand) {
            _hand = hand;
        }

        public override string ToString()
        {
            return _hand switch {
                Hand.Rock => "Rock",
                Hand.Paper => "Paper",
                Hand.Scissors => "Scissors",
                Hand.Lizard => "Lizard",
                Hand.Spock => "Spock",
                _ => "UNKNOWN"
            };
        }



        public static void enfrentanDosElementos(string valor1, string valor2){

            Console.WriteLine($"Se enfrenta en juego {valor1} VS {valor2}");

            if(valor1 == "Paper" || valor2 == "Paper"){
                if(valor2 == "Rock" || valor1 == "Rock"){
                    Console.WriteLine($"Gana PAPEL");
                }
            }else{
                Console.WriteLine("Los dos valores son iguales");
            }

/*
            if(valor1 == "Rock" && valor2 == "Paper"){
                Console.WriteLine($"Win {valor2}");
            }

            else if(valor1 == valor2){
                Console.WriteLine("El juego esta empatado");
            }

            else if(valor1 == "Paper" && valor2 == "Scissors"){
                Console.WriteLine($"Win {valor2}");

            }

            else if(valor2 == "Rock" && valor1 == "Paper"){
                Console.WriteLine($"Win {valor1}");
            }

            else if(valor2 == "Paper" && valor1 == "Scissors"){
                Console.WriteLine($"Win {valor1}");

            }

            else if(valor1 == "Scissors" && valor2 == "Spock"){
                Console.WriteLine($"Win {valor2}");

            }

            else if(valor1 == "Scissors" && valor2 == "Lizard"){
                Console.WriteLine($"Win {valor2}");

            }

            else{
                Console.WriteLine("No hay Gnadores");
            }*/
        }

        public static void enfrentanTresElementos(string valor1, string valor2, string valor3){
            Console.WriteLine($"\nSe enfrenta en juego {valor1} VS {valor2} VS {valor3}");
            if(valor1 == valor2 && valor3 != valor2)
            {
                Console.WriteLine($"Gana valor: {valor2}");
            }
            else if(valor1 == valor2 && valor2 == valor3){
                Console.WriteLine($"Esto es un empate");
            }
            else if(valor1 != valor2 && valor2 != valor3){
                Console.WriteLine($"Nadie Gana");
            }
            else{
                Console.WriteLine("No hay Gnadores");
            }
        }
/*
        public static void ganaPapel3P(string papel, string roca, string tijera){
            Console.WriteLine($"Nadie Gana");
        }*/
    }

}