using najwiekszyWspolnyPodciag_08_01;

public class Program
{
    public static void Main(string[] args)
    {
        string s1 = "babab";
        string s2 = "abaabbaaa";
        string s3 = "KALIMALBA";
        string s4 = "ALIBABA";
        NajwiekszyWspolnyPodciag NWP = new NajwiekszyWspolnyPodciag(s1, s2);
        NWP.WyswietlMacierzZLiterami();
        Console.WriteLine("Długość najwiekszego wspólnego podciągu: " + NWP.Dlugosc());
        Console.WriteLine("Podciąg góra: " + NWP.PodciagGora());
        Console.WriteLine("Podciąg lewo: " + NWP.PodciagLewo());
    }
}
