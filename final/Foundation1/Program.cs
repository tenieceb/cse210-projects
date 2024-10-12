using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();
        
        Video video1 = new Video();
        video1._videoTitle ="Video Title 1";
        video1._videoAuthor = "Video Author 1";
        video1._videoLength = 50;
        video1.NumberOfComments();
        List<string> video1Comments = new List<string>()
        {
            "Commenter 1, comment 1",
            "Commenter 2, comment 2",
            "Commenter 3, comment 3",
            "Commenter 4, comment 4"
        };
        video1.CreateCommentList(video1Comments);


        Video video2 = new Video();
        video2._videoTitle ="Video Title 2";
        video2._videoAuthor = "Video Author 2";
        video2._videoLength = 75;
        video2.NumberOfComments();
        List<string> video2Comments = new List<string>()
        {
            "Commenter 1, comment 1",
            "Commenter 2, comment 2",
            "Commenter 3, comment 3"
        };
        video2.CreateCommentList(video2Comments);

        Video video3 = new Video();
        video3._videoTitle ="Video Title 3";
        video3._videoAuthor = "Video Author 3";
        video3._videoLength = 23;
        video3.NumberOfComments();
        List<string> video3Comments = new List<string>()
        {
            "Commenter 1, comment 1",
            "Commenter 2, comment 2",
            "Commenter 3, comment 3"
        };
        video3.CreateCommentList(video3Comments);
        

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}