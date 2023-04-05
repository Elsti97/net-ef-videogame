using net_ef_videogame.Models;


var context = new VideogameContext();
var manager = new VideogameManager(context);

bool exit = false;

while (!exit)
{
    Console.WriteLine("Scegli una di queste opzioni:");
    Console.WriteLine("inserire un nuovo videogioco (1)");
    Console.WriteLine("ricercare un videogioco per id (2)");
    Console.WriteLine("ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input (3)");
    Console.WriteLine("cancellare un videogioco (4)");
    Console.WriteLine("Inserisci una nuova software house (5)");
    Console.WriteLine("chiudere il programma ('esci')");
    string input = Console.ReadLine() ?? "";
    Console.WriteLine();

    switch (input)
    {
        case "1":
            Console.Write("Inserisci il nome del videogioco: ");
            string nome = Console.ReadLine() ?? "";
            Console.Write("Inserisci l'id della software house: ");
            long shId = long.Parse(Console.ReadLine() ?? "");
            Videogame vg = new Videogame() { Name = nome, SoftwareHouseId = shId };
            manager.InserisciVideogame(vg);
            break;
        case "2":
            Console.Write("Inserisci l'id del videogioco: ");
            long id = long.Parse(Console.ReadLine() ?? "");
            Videogame? result = manager.CercaVideogameId(id);
            Console.WriteLine(result != null ? $"Videogioco trovato: {result.Name}" : "Videogioco non trovato");
            break;
        case "3":
            Console.Write("Inserisci la stringa di ricerca: ");
            string searchString = Console.ReadLine() ?? "";
            List<Videogame> results = manager.CercaVideogameNome(searchString);
            foreach (var game in results)
            {
                Console.WriteLine($"Videogioco trovato: {game.Name} Id: {game.Id}");
            }
            break;
        case "4":
            Console.Write("Inserisci l'id del videogioco da cancellare: ");
            long deleteId = long.Parse(Console.ReadLine() ?? "");
            manager.CancellaVideogame(deleteId);
            break;
        case "5":
            Console.Write("Inserisci il nome della software house: ");
            string shName = Console.ReadLine() ?? "";
            SoftwareHouse sh = new SoftwareHouse() { Name = shName };
            long shIdInserted = manager.InserisciSoftwareHouse(sh);
            Console.WriteLine($"Software house inserita con id: {shIdInserted}");
            break;
        case "esci":
            exit = true;
            break;
        default:
            Console.WriteLine("Errore, riprova");
            break;
    }
}

