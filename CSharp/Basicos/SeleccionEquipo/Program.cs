Dictionary<int, string> teamList = new Dictionary<int, string>();

teamList.Add(0, "Alan");
teamList.Add(1, "Amin");
teamList.Add(2, "Beto");
teamList.Add(3, "Carla");
teamList.Add(4, "Fernando");
teamList.Add(5, "Francisco");
teamList.Add(6, "GUillermo");
teamList.Add(7, "Joaquina");
teamList.Add(8, "Jorge");
teamList.Add(9, "Marcela");
teamList.Add(10, "Maribel");
teamList.Add(11, "Miguel");
teamList.Add(12, "Ricardo");
teamList.Add(13, "Irene");
teamList.Add(14, "Jaquie");
teamList.Add(15, "Javier");
teamList.Add(16, "Vianey");

var teamAbsence = DeleteMissingPeople();
PresentRemainingPeople(teamAbsence);
SuggestNextMember();
Console.ReadLine();

void PresentRemainingPeople(string membersToDelete)
{
    string[] memberNumbers = membersToDelete.Split(',');

    foreach (var item in memberNumbers)
    {
        teamList.Remove(Convert.ToInt32(item));
    }
    Console.Clear();
    Console.WriteLine("---- Gente en la reunión ----");
    foreach (var item in teamList)
    {
        Console.WriteLine(item);
    }
}

void SuggestNextMember()
{
    var remainingKeys = teamList.Keys;
    Random r = new Random();

    int randomMember = (remainingKeys.OrderBy(x => r.Next()).Take(1)).Single();
    string memberName = string.Empty;


    var keyExists = teamList.ContainsKey(randomMember);
    if (keyExists)
    {
        memberName = teamList[randomMember];
        Console.Write($"Mi sugerencia para el siguiente miembro es: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(memberName);
        Console.ResetColor();
        Console.WriteLine("Dime el nombre del ID del miembro que quieres eliminar");
        Console.WriteLine("-------------------------------------------------");
        foreach (var item in teamList)
        {
            Console.WriteLine(item);
        }
        int memberKey = Convert.ToInt32(Console.ReadLine());
        DeleteSingleMember(memberKey);
    }
}

void DeleteSingleMember(int memberKey)
{
    teamList.Remove(memberKey);
    Console.Clear();

    if (teamList.Count == 3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solo te quedan 3 miembros");
    }
    else if (teamList.Count == 2)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Solo te quedan 2 miembros");
    }
    else if (teamList.Count == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Solo te queda 1 miembro");
    }
    else if (teamList.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ya no hay más miembros");
        return;
    }
    SuggestNextMember();
}

string DeleteMissingPeople()
{
    Console.WriteLine("Lista completa de miembros");
    foreach (var item in teamList)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Borra a quienes no están en la reunión");
    var deletedMembers = Console.ReadLine();
    return deletedMembers;
}