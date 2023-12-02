using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        videoList.Add(new Video("Video 1", "Bailey", 2.13));

        videoList[0].AddComment("Willy", "Good video");
        videoList[0].AddComment("Billy", "Good comment");
        videoList[0].AddComment("Silly", "Good work");

        videoList.Add(new Video("Video 2", "Isabella", 3.14));

        videoList[1].AddComment("Fred", "Nice video");
        videoList[1].AddComment("Red", "Nice comment");
        videoList[1].AddComment("Bed", "Nice work");

        videoList.Add(new Video("Video 3", "Sophie", 2.45));

        videoList[2].AddComment("John", "Bad video");
        videoList[2].AddComment("Ron", "Bad comment");
        videoList[2].AddComment("Laun", "Bad work");

        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetAmount()}");
            video.DisplayComments();
            Console.WriteLine("\n");
        }
    }
}