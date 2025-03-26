using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(username != null, "Username tidak boleh null");
            Debug.Assert(username.Length <= 100, "Username tidak boleh lebih dari 100");

            Random rand = new Random();
            this.id = rand.Next(1000, 9999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "Video tidak boleh null");

            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void PrinAllVideoPlaycount()
        {
            Console.WriteLine($"User : {username}");
            int count = 1;
            foreach (var video in uploadedVideos)
            {
                Console.WriteLine($"Video {count} : {video.GetTitle()}");
                count++;
            }
        }
    }
}
