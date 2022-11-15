Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
Console.WriteLine(File.ReadAllText("draw2.txt"));

Thread.Sleep(3000);

Console.Clear();


tela.montarLinhaHor(12,2,79);
tela.centralizar(12,8,79,"Viu? era vc ali, quero 10 kkkkk");

Thread.Sleep(3000);
CRUDlivros CRUDlivros = new CRUDlivros();
List<string> menu = new List<string>();
bool run = true;
string prompt = " \n Use as setas para navegar";
string[] options = {
    "Pesquisar Livro","Fazer uma Doação","Fazer Empréstimo Livro","Fazer uma Devolução","Ver Todos Livros Disponíveis","Sair"
    };
Navegar navegar = new Navegar(options, prompt);

while (run)
{
    int _selectedIndex = navegar.run();
    switch (_selectedIndex)
    {
        case 0:
            CRUDlivros.fazerPesquisa();
            break;
        case 1:
            CRUDlivros.doarLivro();
            break;
        case 2:
            CRUDlivros.alugarLivros();
            break;
        case 3:
            CRUDlivros.devLivro();
            break;
        case 4:
            CRUDlivros.listDisp();
            break;
        case 5:
                run = false;
                break;

            //     if (opcao == "1") CRUDlivros.fazerPesquisa();
            //     if (opcao == "2") CRUDlivros.doarLivro();
            //     if (opcao == "3") CRUDlivros.alugarLivros();
            //     if (opcao == "4") CRUDlivros.devLivro();
            //     if (opcao == "5") CRUDlivros.listDisp();
    }
}














// Console.WriteLine(File.ReadAllText("draw2.txt"));

// Thread.Sleep(3000);

// Console.Clear();


// tela.montarLinhaHor(12,2,79);
// tela.centralizar(12,8,79,"Viu? era vc ali, quero 10 kkkkk");

// Thread.Sleep(3000);

// menu do sistema
// menu.Add("1 - pesquisar livro             ");
// menu.Add("2 - fazer uma doação            ");
// menu.Add("3 - fazer empréstimo livro      ");
// menu.Add("4 - fazer uma devolução         ");
// menu.Add("5 - ver todos livros disponíveis");
// menu.Add("0 - Sair                        ");

Console.WriteLine(File.ReadAllText("draw2.txt"));

Thread.Sleep(3000);

Console.Clear();


tela.montarLinhaHor(12,2,79);
tela.centralizar(12,8,79,"Viu? era vc ali, quero 10 kkkkk");

Thread.Sleep(3000);

// while (true)
// {
//     tela.montarTelaGeral();
//     tela.montarLinhaHor(2,0,77);
//     tela.centralizar(1,0,79,"Filipe's Biblioteca");
//     opcao = tela.mostrarMenu(30,10,menu);

//     if (opcao == "0") break;
//     if (opcao == "1") CRUDlivros.fazerPesquisa();
//     if (opcao == "2") CRUDlivros.doarLivro();
//     if (opcao == "3") CRUDlivros.alugarLivros();
//     if (opcao == "4") CRUDlivros.devLivro();
//     if (opcao == "5") CRUDlivros.listDisp();


//}
Console.Clear();