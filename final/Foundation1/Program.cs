using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();
        
        Video video1 = new Video();
        video1._videoTitle ="Pretty Trees";
        video1._videoAuthor = "Bob Ross";
        video1._videoLength = 50;
        video1.NumberOfComments();
        List<string> video1Comments = new List<string>()
        {
            "Picaso, Not weird enough...",
            "Da vinci, so creative!",
            "FirstTimePainter, I need help...",
            "ArtTroll, Anyone can do that"
        };
        video1.CreateCommentList(video1Comments);


        Video video2 = new Video();
        video2._videoTitle ="Mathy Mathness";
        video2._videoAuthor = "Proff Divider";
        video2._videoLength = 75;
        video2.NumberOfComments();
        List<string> video2Comments = new List<string>()
        {
            "StudentClueless, So we do what with the funny line?",
            "ClassClown, HA you messed up... you fixed it but still....",
            "SoliciterStudent, I offer tudoring for a jollyrancher!"
        };
        video2.CreateCommentList(video2Comments);

        Video video3 = new Video();
        video3._videoTitle ="BoM RPG VideoGame LIVE";
        video3._videoAuthor = "striplingWarrior";
        video3._videoLength = 23;
        video3.NumberOfComments();
        List<string> video3Comments = new List<string>()
        {
            "Sweetness, This is way cooler than expected!",
            "RMissionaryAlberta, Oh Man! I wish I had this before my mission",
            "CuriousBystander, What is BoM?"
        };
        video3.CreateCommentList(video3Comments);
        

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        Console.WriteLine("----------------------------------------------------------");
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}