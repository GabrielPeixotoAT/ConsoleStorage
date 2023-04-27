using ConsoleStorage.Data;
using ConsoleStorage.Menus;
using ConsoleStorage.Menus.ConcreteMenus;
using ConsoleStorage.Models.Product;

List<string> options = new List<string>
{
    "Produtos",
    "Fornecedores",
    "Lojas",
    "Clientes"
};

IGUI gui = new Main(options, 15);

int index = 0;

do
{
    index = gui.Render();
    switch (index)
    {
        case 0:
            Console.Clear();
            Console.WriteLine("Produtos");
            break;
        case 1:
            Console.Clear();
            Console.WriteLine("Fornecedores");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Lojas");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Produto");
            break;
    }
} while (index != 4);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Done");
