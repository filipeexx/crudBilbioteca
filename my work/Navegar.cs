class Navegar
{
    Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
    private int _selectedIndex;
    private string[] _options;
    private string _prompt;

    public Navegar(string[] options, string prompt)
    {
        this._selectedIndex = 0;
        this._options = options;
        this._prompt = prompt;
    }

    private void displayOptions()
    {
         tela.montarMoldura(0,0,89,2);
        tela.centralizar(1,0,79,"Filipe's Biblioteca");
        Console.WriteLine("");
        Console.WriteLine("");

        for (int i = 0; i < _options.Length; i++)
        {
            string currentOption = _options[i];

            string prefix;

            if (i == _selectedIndex)
            {
                prefix = "-> ";
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                prefix = "-";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine($"{prefix}{currentOption}");

        }
        Console.ResetColor();

    }

    public int run()
    {
        ConsoleKey keyPressed;

        do
        {
            Console.Clear();
            displayOptions();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {
                _selectedIndex--;
                if (_selectedIndex == -1)
                {
                    _selectedIndex = _options.Length - 1;
                }
            }

            else if (keyPressed == ConsoleKey.DownArrow)
            {
                _selectedIndex++;
                if (_selectedIndex == _options.Length)
                {
                    _selectedIndex = 0;
                }
            }
        } while (keyPressed != ConsoleKey.Enter);

        return _selectedIndex;
    }
}
