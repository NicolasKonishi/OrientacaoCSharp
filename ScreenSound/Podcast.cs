class Podcast
{
    private List<Episodio> Episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        this.nome = nome;
    }

    public String Host { get; }
    public String nome { get; }
    public int TotalEpisodios => Episodios.Count;

    public void AdicionarEpisodios(Episodio episodio)
    {
        Episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {nome} apresentado por {Host}\n");
        foreach(Episodio episodio in Episodios.OrderBy(e => e.Ordem )) {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Possui {TotalEpisodios} episódios");
    }
}