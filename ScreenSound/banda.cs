class Banda
{
    //classe para banda das músicas
    private List<Album> albuns = new List<Album>();
    public Banda(string nome)
    {
        Nome = nome;
    }

    public String Nome { get;}

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);

    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach(Album album in albuns)
        {
            Console.WriteLine( $"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}