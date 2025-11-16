// See https://aka.ms/new-console-template for more information
using PedraPapelTesoura;



string nomeJogador = "";

Console.WriteLine("Digite seu nome: ");
nomeJogador = Console.ReadLine();

JogadorMaquina jogadorMaquina = new JogadorMaquina("npc");
Jogador jogador = new Jogador(nomeJogador);

Console.WriteLine("Seja bem vindo " + jogador.nome);

int rodadas = 1;

while (rodadas < 4)
{
  Console.WriteLine("--- RODADA " + rodadas + " ---");

  Console.WriteLine("Digite sua jogada: PEDRA, PAPEL OU TESOURA: ");
  jogador.jogada = Console.ReadLine();
  jogadorMaquina.jogada = jogadorMaquina.jogar();

  Console.WriteLine(jogador.nome + " jogou: " + jogador.jogada);
  Console.WriteLine(jogadorMaquina.nome + " jogou: " + jogadorMaquina.jogada);

  if (jogador.jogada == "PEDRA" && jogadorMaquina.jogada == "TESOURA")
  {
    jogador.quantidadeVitoria++;
    Console.WriteLine("Jogador:" + jogador.nome + " ganhou a rodada");
  }
  else if (jogador.jogada == "PAPEL" && jogadorMaquina.jogada == "PEDRA")
  {
    jogador.quantidadeVitoria++;
    Console.WriteLine("Jogador:" + jogador.nome + " ganhou a rodada");

  }
  else if (jogador.jogada == "TESOURA" && jogadorMaquina.jogada == "PAPEL")
  {
    jogador.quantidadeVitoria++;
    Console.WriteLine("Jogador:" + jogador.nome + " ganhou a rodada");

  }
  else if (jogadorMaquina.jogada == jogador.jogada)
  {
    Console.WriteLine("empate na rodada");
  }
  else
  {
    jogadorMaquina.quantidadeVitoria++;
    Console.WriteLine("Jogador:" + jogadorMaquina.nome + " ganhou a rodada");

  }

  rodadas++;
}


if (jogadorMaquina.quantidadeVitoria > jogador.quantidadeVitoria)
{
  jogador.derrota();
}
else if (jogadorMaquina.quantidadeVitoria == jogador.quantidadeVitoria)
{
  jogador.empate();
}
else
{
  jogador.vitoria();
}
