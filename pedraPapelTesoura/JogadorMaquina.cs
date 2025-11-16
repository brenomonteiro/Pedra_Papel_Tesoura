namespace PedraPapelTesoura
{
  public class JogadorMaquina : Jogador
  {


    public JogadorMaquina(string nome) : base(nome)
    {

    }

    public string jogar()
    {
      Random random = new Random();
      int numeroAleatorio = random.Next(0, 3);

      if (numeroAleatorio == 0)
      {
        return "PEDRA";
      }
      else if (numeroAleatorio == 1)
      {
        return "PAPEL";
      }
      else
      {
        return "TESOURA";
      }

    }

  }
}
