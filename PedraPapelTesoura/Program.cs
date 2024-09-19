
string[] opcoes = ("pedra", "papel", "tesoura");
Random random = new Random ();

while(true)
{
    Console.Write("Escolha entre pedra, papel e tesoura: ")
    string jogador = Console.ReadLine();

    if (jogador == "sair")
    {
        break;
    }
    string computador = opcoes[random.Next(opcoes.Length)];
    Console.WriteLine("O computador escolheu: " + computador);

    if(jogador == computador)
    Console.Write("Empate");

    else if (jogador == "pedra" && computador == "tesoura" || jogador == "pedra" && computador == "tesoura" || jogador == "pedra" && computador == "tesoura" ) 

    Console.Write("Voce venceu!")
    else 
    Console.Write("Computador venceu.")
    Console.Write();
}