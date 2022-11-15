class CRUDlivros
{    
    List<Livros> livros = new List<Livros>();
    public CRUDlivros()
    {
        this.livros.Add(new Livros(881232678,"Harry Potter","Ficção","Harry vai em busca do crack filosofal"));
        this.livros.Add(new Livros(1324213412,"Manseira Lindo me da 10","Motivacional","Uma historia de um aluno em busca do 10"));
    }

    int posicao;
    // this.livros.Add(1324213412,"Manseira Lindo me da 10","Motivacional","Uma historia de um aluno em busca do 10");
    // livros.Add(new Livros(881232678,"Harry Potter","Ficção","Harry vai em busca do crack filosofal"));
    
    public void fazerPesquisa()
    {   
        int resp;
        Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
        tela.limparArea(0,0,80,30);
        tela.montarMoldura(0,0,79,2);
        tela.centralizar(1,0,79,"Filipe's Biblioteca");
        Console.SetCursorPosition(0,4);
        Console.WriteLine("Insira o ISBN do livro");
        resp = int.Parse(Console.ReadLine());
        if (resp == null)
        {
            Console.WriteLine();
            Console.WriteLine("insira apenas números");
            Thread.Sleep(2000);
            fazerPesquisa();
        }
        

        bool achou = false;
        int x;
        for (x=0; x<this.livros.Count; x++)
        {
            if (this.livros[x].isbn == resp)
            {
                achou = true;
                this.posicao = x;
                break;
            }
        }


        if (achou)
        {
            Console.WriteLine("aqui está o livro que você pesquisou:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O ISBN do livro é: " + livros[x].isbn);
            Console.WriteLine();
            Console.WriteLine("O nome do livro é: " + livros[x].nomeLivro);
            Console.WriteLine();
            Console.WriteLine("A sinopse do livro é: " + livros[x].sinopse);
            Console.WriteLine();
            Console.WriteLine("O gênero do livro é: " + livros[x].genero);
            Console.WriteLine();
            Console.WriteLine("para emprestar este livro, aguarde ir para o menu e vá para alugar livro.");
            Thread.Sleep(5000);
        }   else
                {
                    Console.WriteLine("infelizmente não temos esse livro cadastrado");
                    Console.WriteLine("quer tentar outro? (S/N)");
                    
                    string resps = Console.ReadLine();

                    if (resps.ToUpper()=="S")
                    {
                        fazerPesquisa();
                    
                    }
                }   
    }

    public void doarLivro()
    {
        string resp;
        Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
        tela.limparArea(0,0,80,30);
        tela.montarMoldura(0,0,79,2);
        tela.centralizar(1,0,79,"Filipe's Biblioteca");
        Console.SetCursorPosition(0,4);
        Console.WriteLine("Insira o ISBN do livro: ");
        int isbn = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o nome do livro: ");
        string nomeLivro =  Console.ReadLine();
        Console.WriteLine("Insira a sinopse: ");
        string sinopse = Console.ReadLine();
        Console.WriteLine("Insira o gênero: ");
        string genero = Console.ReadLine();


        Console.WriteLine("Os dados estão corretos: (S/N)");

        resp = Console.ReadLine();

            if (resp.ToUpper()=="S")
            {
                livros.Add(new Livros(isbn,nomeLivro,genero,sinopse));
                Console.WriteLine();
                Console.WriteLine("Obrigado pela doação <3");
                Thread.Sleep(2000);
            }else
                {
                    Console.WriteLine();
                    Console.WriteLine("TENTE NOVAMENTE");
                    Thread.Sleep(1500);
                    doarLivro();
                }
        
    }


    public void alugarLivros()
    {
        Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
        Livros alugLi = new Livros();
        int resp;
        tela.limparArea(0,0,80,30);
        tela.montarMoldura(0,0,89,2);
        tela.centralizar(1,0,79,"Filipe's Biblioteca");
        Console.SetCursorPosition(0,4);
        Console.WriteLine("Insira o ISBN do livro que você quer:");
        resp = int.Parse(Console.ReadLine());
        
        if (resp.ToString() == "")
        {
            Console.WriteLine("digita alguma coisa aí, filho");
        }

        bool achou = false;
        int x;
        for (x=0; x<this.livros.Count; x++)
        {
            if (livros[x].isbn == resp)
            {
                achou = true;
                this.posicao = x;
                break;
            }
        }


        if (achou)
        {
            
            Console.WriteLine("aqui está os dados do seu livro");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O ISBN do livro é: " + livros[x].isbn);
            Console.WriteLine();
            Console.WriteLine("O nome do livro é: " + livros[x].nomeLivro);
            Console.WriteLine();
            Console.WriteLine("A sinopse do livro é: " + livros[x].sinopse);
            Console.WriteLine();
            Console.WriteLine("O gênero do livro é: " + livros[x].genero);
            Console.WriteLine();
            Console.WriteLine("Confirmar empréstimo? (S/N) :");
            string resps = Console.ReadLine();

            if (resps.ToUpper()=="S")
                    {
                        this.livros.RemoveAt(this.posicao);
                        Console.WriteLine("seu livro foi tirado do historico de livros");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Console.WriteLine("cuidado, livros te deixam esperto :P");
                        Thread.Sleep(3000);
                    }

        } else
              {
                Console.WriteLine("Esse ISBN não consta, tente novamente");
              }


    }

    public void devLivro()
    {
        string resp;
        Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
        tela.limparArea(0,0,80,30);
        tela.montarMoldura(0,0,79,2);
        tela.centralizar(1,0,79,"Filipe's Biblioteca");
        Console.SetCursorPosition(0,4);
        Console.WriteLine("Insira o ISBN do livro: ");
        int isbn = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o nome do livro: ");
        string nomeLivro =  Console.ReadLine();
        Console.WriteLine("Insira a sinopse: ");
        string sinopse = Console.ReadLine();
        Console.WriteLine("Insira o gênero: ");
        string genero = Console.ReadLine();


        Console.WriteLine("Os dados estão corretos: (S/N)");

        resp = Console.ReadLine();

            if (resp.ToUpper()=="S")
            {
                livros.Add(new Livros(isbn,nomeLivro,genero,sinopse));
                Console.WriteLine();
                Console.WriteLine("ansioso pela proxima aventura?");
                Thread.Sleep(2000);
            }else
                {
                    Console.WriteLine();
                    Console.WriteLine("TENTE NOVAMENTE");
                    Thread.Sleep(1500);
                    doarLivro();
                }
        
    }


    public void listDisp()
    {
        string resp;
        int x = 0;
        Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
        tela.limparArea(0,0,80,30);
        tela.montarMoldura(0,0,79,2);
        tela.centralizar(1,0,79,"Filipe's Biblioteca");
        Console.SetCursorPosition(0,4);
        Console.WriteLine("Aqui estão todos os livros adicionados:");
        Console.WriteLine();

        for (x=0; x<livros.Count; x++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("O ISBN do livro é: " + livros[x].isbn);
                Console.WriteLine();
                Console.WriteLine("O nome do livro é: " + livros[x].nomeLivro);
                Console.WriteLine();
                Console.WriteLine("A sinopse do livro é: " + livros[x].sinopse);
                Console.WriteLine();
                Console.WriteLine("O gênero do livro é: " + livros[x].genero);
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("deseja voltar ao menu? (S/N)");
            resp = Console.ReadLine();

            if (resp.ToUpper()=="S")
            {
                
            }else
                {
                 listDisp();   
                }
            

    }

    
}