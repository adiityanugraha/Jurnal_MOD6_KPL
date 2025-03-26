// See https://aka.ms/new-console-template for more information
using modul6_103022300063;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Aditya");

        string[] filmList =
        {
            "Fire Force", "One Piece", "Naruto", "Dragon Ball", "Black Clover", "Attack on Titan", "Jujutsu Kaisen", "Demon Slayer", "Dr. Stone", "My Hero Academia"
        };

        for (int i = 0; i < filmList.Length; i++)
        {
            string judul = $"Review Film {filmList[i]} oleh Aditya";
            SayaTubeVideo video = new SayaTubeVideo(judul);
            video.IncreasePlayCount(1000000);
            user.AddVideo(video);
        }
        
        user.PrinAllVideoPlaycount();
    }
}