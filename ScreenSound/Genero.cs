class Genero
{
    private List<Genero> generos = new List<Genero>(); 
    public string Nome { get; set; }
    public void AdicionarAlbum(Genero genero)
    {
        generos.Add(genero);

    }
    public void ExibirGenero()
    {
        Console.WriteLine($"O Genero da música é: {Nome}");
    }

}
