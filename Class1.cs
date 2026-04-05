using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul6_103082400023
{
    class SayaTubeVideo
    {
        private int id;
        private string tittle;
        private int playCount;
        public SayaTubeVideo(string tittle)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.tittle = tittle;
            this.playCount = 0;
        }

        public void increasePlayCount(int count)
        {
            playCount += count;
        }
        public void printVideoDetails()
        {
            Console.WriteLine("Berikut nama Video:");
            Console.WriteLine("Tittle:" + tittle);
            Console.WriteLine("id:" + id);
            Console.WriteLine("Jumlah Pemutaran" + playCount);
        }

    }
}
