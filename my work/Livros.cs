class Livros
{
    public int isbn {get;set;}
    public string nomeLivro {get;set;}
    public string sinopse {get;set;}
    public string genero {get;set;}
  
    public Livros()
    {
        this.isbn = 0;
        this.nomeLivro = "";
        this.genero = "";
        this.sinopse = "";
    }
    public Livros(int isbn, string nomeLivro, string genero, string sinopse)
    {
        this.isbn = isbn;
        this.nomeLivro = nomeLivro;
        this.genero = genero;
        this.sinopse = sinopse;
    }
}