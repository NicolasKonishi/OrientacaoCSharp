﻿//duração, artista, nome, disponivel
Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "the police";
musica1.duracao = 273;
musica1.disponivel = true;

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.disponivel = false;

musica1.ExibirListaTecnica();
musica2.ExibirListaTecnica();
