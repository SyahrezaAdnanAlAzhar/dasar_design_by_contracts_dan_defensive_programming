using System.Diagnostics;
using System.Linq.Expressions;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null && title.Length <= 100, "Title tidak sesuai dengan ketentuan");
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.title = checked(title);
        this.playCount = 0;
    }
    public void IncreasePlayCount(int playCount)
    {
        Debug.Assert(playCount > 0 && playCount < 10000000, "Tidak dapat menambah play count terlalu banyak");
        try
        {
            this.playCount = checked(this.playCount + playCount);
        }
        catch (OverflowException)
        {
            throw new OverflowException("Jumlah play count melebihi batas");
        }
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
        // STV.IncreasePlayCount(1000000001);
        int i = 100000;
        while (i >= 0)
        {
            STV.IncreasePlayCount(i);
        }
        STV.PrintVideoDetail();
    }
}