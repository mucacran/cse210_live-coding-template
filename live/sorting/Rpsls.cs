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

        public static void ganaPapel(string valor1, string valor2){
            if(valor1 == "Paper" && valor2 == "Scissors" || valor2 == "Scissors" && valor2 == "Paper" ){
                Console.WriteLine($"Win {valor1}");
            }
        }

        public static void ganaPapel3P(string papel, string roca, string tijera){
            Console.WriteLine($"Nadie Gana");
        }
    }

}