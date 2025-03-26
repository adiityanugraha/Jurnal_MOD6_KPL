using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300063
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Debug.Assert(title != null, "Judul video tidak boleh null");
            Debug.Assert(title.Length <= 200, "Judul video tidak boleh lebih dari 200");

            Random rand = new Random();
            this.id = rand.Next(1000, 9999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count > 0, "Jumlah penambahan play count harus positif");
            Debug.Assert(count <= 25000000, "Jumlah penambahan play count maksimal 25.000.000");
            Debug.Assert((long)playCount + count <= int.MaxValue, "Total play count tidak boleh melebihi batas integer max");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: play count melebihi batas max");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public String GetTitle()
        {
            return title;
        }
    }
}
