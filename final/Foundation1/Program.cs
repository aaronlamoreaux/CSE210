using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();
        Video video1 = new Video("The Greatest Easter Story Ever Told | Gary E. Stevenson | April 2023 General Conference", "Gary E. Stevenson", 851.4);
        video1.NewComment("@patrickrose567", "No more death. greatest Easter story the manifestation to fullness the entirety of the gospel. The church of Jesus Christ of latter day saints. To know Jesus Christ in this life  , Another testament of Jesus Christ");
        video1.NewComment("@JohnPaulConteh-uy6vu", "Josh lives he lives to comforte");
        video1.NewComment("@recursosyvaloreshumanos9582", "wonderful..the book of mormon testifies of the atonement of the LORD....i love him and Easter");
        videos.Add(video1);

        Video video2 = new Video("Never Give Up an Opportunity to Testify of Christ | Bonnie H. Cordon | April 2023 General Conference", "Bonnie H. Cordon", 669);
        video2.NewComment("@mmc7695", "A wonderful reminder to always testify of our Savior <3");
        video2.NewComment("@happylatter-daysaint3503", "This talk answered a prayer of mine. <3");
        video2.NewComment("@jaredssublimelife", "I\'m grateful for Sister Cordon and her testimony of Christ.  I\'ve always enjoyed her talks and will miss hearing her thoughts of the Savior.  I know that Jesus is the Christ and that he provided a way for us to return to be with our Heavenly Father again.  So grateful for the Savior and his Atonement!!");
        videos.Add(video2);

        Video video3 = new Video("Just Keep Going—with Faith | Carl B. Cook | April 2023 General Conference", "Carl B. Cook ", 662.4);
        video3.NewComment("@joseflores-mz2rl", "This talk was an answer to my prayers. Thank you Heavenly Father for inspired leaders and prophets of our day! <3");
        video3.NewComment("@a-aron5508", "Wonderful talk! For someone who has anxiety and depression it's wonderful to know God and Jesus Christ have made way's for us to succeed. Those who are struggling \"Just Keep Going!\" <3");
        video3.NewComment("@melanieball8736", "After this talk ….Was anyone else waiting for someone to say \"and now we will hear from elder cook again\"");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}