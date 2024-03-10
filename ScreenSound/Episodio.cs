class Episodio
{
    private List<string> Convidados = new();
    public Episodio( int ordem,int duracao, string titulo)
    {
        Ordem = ordem;
        Duracao = duracao;
        Titulo = titulo;
    }

    public int Duracao { get;}
    public int Ordem { get; }
    public String Titulo { get; }
    public String Resumo => $"{Ordem}. {Titulo}({Duracao}min) - {string.Join(",", Convidados)} ";
 

    public void AdicionarConvidados(string Convidado)
    {
        Convidados.Add(Convidado);
    }
}