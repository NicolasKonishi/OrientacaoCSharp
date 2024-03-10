class Musica
{
   public String nome;
   public String artista;
   public int duracao;
   private bool disponivel;

   public void EscreveDiponivel(bool value)
    {
        this.disponivel = value;
    }
    public bool LeDisponivel()
    {
        return disponivel;
    }

    public void ExibirListaTecnica()
    {
        Console.WriteLine($"NOME: {nome}");
        Console.WriteLine($"ARTISTA: {artista}");
        Console.WriteLine($"DURAÇÂO: {duracao}");
       
        if (disponivel) {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano+");
        }

    }
    public void ExibirNomeArtista()
    {
        Console.WriteLine($"Nome/artista: {nome}-{artista}");

    }
}