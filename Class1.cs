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
            if(tittle == null || tittle.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh null dan tidak boleh lebih dari 100 huruf");
            }
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.tittle = tittle;
            this.playCount = 0;
        }

        public void increasePlayCount(int count)
        {
            if(count < 0 || count > 10000000)
            {
                throw new ArgumentException("Inputan Tidak Valid");
            }

            checked 
            {
                playCount += count;
            }
            
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
