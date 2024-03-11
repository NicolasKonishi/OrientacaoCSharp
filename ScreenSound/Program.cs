// Desafio final do curso abaixo:
Episodio ep1 = new(1, 45, "Hello");
ep1.AdicionarConvidados("Nicolas");
ep1.AdicionarConvidados("Vitor");

Episodio ep2 = new(2, 45, "world");
ep2.AdicionarConvidados("Nicolas");
ep2.AdicionarConvidados("Vitor");
ep2.AdicionarConvidados("Gustavo");

Podcast podcast = new("Paulo","Podcast legal");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);

podcast.ExibirDetalhes();


// Desafio feito com os instrutores durante o curso abaixo: 
Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(queen, "Love Of My Life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 300,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

 Genero genero = new Genero();
genero.Nome = "Rock";

musica1.ExibirListaTecnica();
musica2.ExibirListaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();
genero.ExibirGenero();