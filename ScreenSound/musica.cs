class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public String Nome { get;}
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A música{Nome} pertence a bana {Artista}";

    public void ExibirListaTecnica()
    {
        Console.WriteLine($"NOME: {Nome}");
        Console.WriteLine($"ARTISTA: {Artista.Nome}");
        Console.WriteLine($"DURAÇÂO: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano+\n");
        }

    }
    public void ExibirNomeArtista()
    {
        Console.WriteLine($"Nome/artista: {Nome}-{Artista}");

    }

  
}