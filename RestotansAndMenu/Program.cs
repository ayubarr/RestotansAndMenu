using RestotansAndMenu;
using RestouransAndMenu;
public class Program
{
    public static void Main()
    {
        #region Products_Create
        Fruits banana = new Fruits(Fruits.Banana, 100);
        Fruits apple = new Fruits(Fruits.Apple, 120);
        Fruits grape = new Fruits(Fruits.Grape, 110);
        Fruits orange = new Fruits(Fruits.Orange, 130);

        Vegetables tomato = new Vegetables(Vegetables.Tomato, 70);
        Vegetables onion = new Vegetables(Vegetables.Onion, 40);
        Vegetables cucumber = new Vegetables(Vegetables.Cucumber, 50);
        Vegetables lettuce_Leaf = new Vegetables(Vegetables.Lettuce_Leaf, 60);

        Meats cowMeat = new Meats(Meats.Cow_Meat, 500);
        Meats chikenMeat = new Meats(Meats.Chicken_Meat, 400);
        Meats fishMeat = new Meats(Meats.Fish_Meat, 700);
        Meats pigMeat = new Meats(Meats.Pig_Meat, 600);



        List<Product> allProducts = new List<Product>
        {
            banana,
            apple,
            grape,
            cowMeat,
            chikenMeat,
            fishMeat,
            pigMeat,
            tomato,
            onion,
            cucumber,
            lettuce_Leaf
        };
        #endregion

        #region Mealfs_Create
        Dictionary<Product, double> CowKebabProducts = new Dictionary<Product, double>
        {
            {cowMeat, 250 }
        };
        Dictionary<Product, double> ChikenKebabProducts = new Dictionary<Product, double>
        {
            {chikenMeat, 200 }
        };
        Dictionary<Product, double> AssortiKebabProducts = new Dictionary<Product, double>
        {
            {cowMeat, 150 },
            {chikenMeat, 100 }
        };
        Dictionary<Product, double> fruitSaladProducts = new Dictionary<Product, double>
        {
            {banana, 50 },
            {apple, 50 },
            {grape, 50},
            {orange, 50 },
        };
        Mealf cowKebab = new Mealf(Mealf.Cow_Kebab, CowKebabProducts);
        Mealf chikenKebab = new Mealf(Mealf.Chicken_Kebab, ChikenKebabProducts);
        Mealf assortiKebab = new Mealf(Mealf.Assorti_Kebab, AssortiKebabProducts);
        Mealf fruitSalad = new Mealf(Mealf.Fruit_Salad, fruitSaladProducts);
        #endregion

        #region RestoBars_Create
        List<Mealf> SluhiAndPivoMeals = new List<Mealf>
        {
            cowKebab,
            chikenKebab,
            assortiKebab,
            fruitSalad
        };
        RestoBar ShluhiAndPivo = new RestoBar("BitchAndBear", "Bob", SluhiAndPivoMeals);

        List<RestoBar> allRestoBars = new List<RestoBar>()
        {
            ShluhiAndPivo
        };

        /*  foreach (Product product in allProducts)
          {
              product.ViewEveryUsed();
          }
          Console.ReadKey();
        */
        #endregion

        ViewMainMenu(allRestoBars);


    }
    public static void ViewMainMenu(List<RestoBar> allRestoBars)
    {
        string[] keys = new string[]
        {
        //    "X",
            "Z",
            "Ecape"
        };
        Console.WriteLine("MAIN MENU");
        Console.SetCursorPosition(0, 7);
        Console.WriteLine("Z -  Restaurants List\n\n");
        Console.WriteLine("Esc  -  Close Program");

        string choiceButtom = Button(keys);
        switch (choiceButtom)
        {
            case "Z":
                Console.Clear();
                ViewRestoBars(allRestoBars);
                break;
            case "Escape":
                break;
        }

    }
    //public static string NumButton(string[] keys)
    //{
    //    string input;
    //    do
    //    {
    //        input = Console.ReadKey(true).Key.ToString();
    //        input = input[input.Length - 1].ToString();
    //    }
    //    while (!keys.Contains(input));
    //    return input;
    //}
    
    public static string Button(string[] keys)
    {
        string input = "";
        do
        {
            var inputKey = Console.ReadKey(true);
            int keyAscii = (int)inputKey.Key;
            if (keyAscii <= 57 && keyAscii >= 49 || keyAscii >= 97 && keyAscii <= 105)
            {
                input = inputKey.Key.ToString();
                input = input[input.Length - 1].ToString();
                if(keys.Contains(input))
                    return input;
                Button(keys);
            }

            input = inputKey.Key.ToString();
        }
        while (!keys.Contains(input));
        return input;

    }
    public static void ViewRestoBars(List<RestoBar> allRestoBars)
    {

        int indexofRestoBars = 0;
        foreach(var restobar in allRestoBars)
        {
            indexofRestoBars++;
            Console.WriteLine($"{indexofRestoBars} - {restobar.Name} ");
        }
        Console.WriteLine(" ESC - EXIT           BACKSPACE - BACK");
        //TODO: отредачить изменения
        List<string> keys = new List<string>()
        {
            "Backspace",
            "Escape"
        };
        for (int i = 1; i < indexofRestoBars+1; i++)
        {
            keys.Add(i.ToString());
        }
        string choiceButtom = Button(keys.ToArray());
        switch (choiceButtom)
        {
            case "Backspace":
                Console.Clear();
                ViewMainMenu(allRestoBars);
                break;
            case "Escape":
                Environment.Exit(0);
                break;
        }

        int index = Convert.ToInt32(choiceButtom);
        allRestoBars[index-1].ViewRestobarMenu();

        Console.WriteLine(" ESC - EXIT           BACKSPACE - BACK");
        string[] keyss = new string[]
        {
            "Backspace",
            "Escape"
        };
        string choice = Button(keyss);

        switch (choice)
        {
            case "Backspace":
                Console.Clear();
                ViewRestoBars(allRestoBars);
                break;
            case "Escape":
                Environment.Exit(0);
                break;
        }


    }


}

