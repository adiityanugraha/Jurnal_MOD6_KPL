using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300063
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(String username)
        {
            Random rand = new Random();
            this.id = rand.Next(1000, 9999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.playCount;
            }
            return total;
        }

        public void PrinAllVideoPlaycount()
        {
            Console.WriteLine($"User : {username}");
            int count = 1;
            foreach (var video in uploadedVideos)
            {
                Console.WriteLine($"Video {count} : {video.title}");
                count++;
            }
        }
    }
}
