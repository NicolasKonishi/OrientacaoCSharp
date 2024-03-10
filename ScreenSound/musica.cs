class Musica
{
   public String nome;
   public String artista;
   public int duracao;
   public bool disponivel;

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