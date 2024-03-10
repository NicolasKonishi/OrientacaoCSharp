Album albumKendrickLamar = new Album();
albumKendrickLamar.Nome = "DAMN";


Musica musica1 = new Musica();
musica1.Nome = "BLOOD";
musica1.Duracao = 213;


Musica musica2 = new Musica();
musica2.Nome = "DNA";
musica2.Duracao = 300;

albumKendrickLamar.AdicionarMusica(musica1);
albumKendrickLamar.AdicionarMusica(musica2);

Genero genero = new Genero();
genero.Nome = "Rap";

Banda queen = new Banda();
queen.Nome = "Kendrick Lamar";
queen.AdicionarAlbum(albumKendrickLamar);
queen.ExibirDiscografia();
genero.ExibirGenero();
