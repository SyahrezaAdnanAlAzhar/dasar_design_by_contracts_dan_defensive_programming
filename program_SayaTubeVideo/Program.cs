public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }
    public void PrintVideoDetail()
    {
        Console.WriteLine("Informasi Video");
        Console.WriteLine($"ID         : {this.id}");
        Console.WriteLine($"Title      : {this.title}");
        Console.WriteLine($"Play Count : {this.playCount}");
    }
}

public class main
{
    public static void Main(string[] args)
    {
        SayaTubeVideo STV = new SayaTubeVideo("Tutorial Design By Contract - SYAHREZA ADNAN AL AZHAR");
        STV.IncreasePlayCount(10000001);
        STV.PrintVideoDetail();
    }
}