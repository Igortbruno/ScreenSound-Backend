Episodio ep1 = new(1, "Tecnicas de facilitação", 45);
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, "Tecnicas de aprendizado", 67);
ep1.AdicionarConvidados("Fernando");
ep1.AdicionarConvidados("Marcos");
ep1.AdicionarConvidados("Juliana");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();   


Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the Opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
}; 
musica1.Duracao = 213;

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    
    Duracao = 354,
    Disponivel = false,
};

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();   
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();