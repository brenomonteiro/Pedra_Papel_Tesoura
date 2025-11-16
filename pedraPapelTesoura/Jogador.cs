
using System;

namespace PedraPapelTesoura
{
  public class Jogador
  {
    public string jogada { get; set; }
    public string nome { get; set; }

    public int quantidadeVitoria { get; set; }

    public Jogador(string nome)
    {
      this.nome = nome;

    }

    public void vitoria()
    {
      Console.WriteLine("ganhou!");
    }

    public void empate()
    {
      Console.WriteLine("empatou!");
    }

    public void derrota()
    {
      Console.WriteLine("perdeu!");
    }



  }
}
