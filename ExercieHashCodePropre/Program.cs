internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, HashSet<string>> hashList = new Dictionary<int, HashSet<string>>();
        Random random = new Random();
        string[] resultat = null;
        int HashCode = 0;

        while (resultat == null)
        {
            string s = random.Next(0x40000000).ToString("x8");
            HashCode = s.GetHashCode();

            if (!hashList.TryGetValue(HashCode, out var listString))
                hashList[HashCode] = new HashSet<string> { s };

            else if (listString.Add(s) && listString.Count == 3)
                resultat = listString.ToArray();
        }

        foreach (var item in resultat)
        {
            Console.WriteLine($"La chaine {item} hashcode :  {item.GetHashCode()}");

        }

        Console.WriteLine($"Méme HashCode {HashCode}");
    }
}