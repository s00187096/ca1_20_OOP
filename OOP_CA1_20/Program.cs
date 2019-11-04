using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CA1_20
{
    class Program
    {

        enum Genre
        {
            Rock,
            Pop,
            Dance,
            other
        }

        Program()
        {
            Console.WriteLine("Constructor Called");
        }

        
        static void Main(string[] args)
        {
            List<Artist> artist = new List<Artist>();
            Artist EdSheeran = new Artist("Ed Sheeran");
            Artist tonesandi = new Artist("Tones & I");
            Artist Redgard = new Artist("Redgard");
            Artist Postmalone = new Artist("Post Malone");

            artist.Add(EdSheeran);
            artist.Add(tonesandi);
            artist.Add(Redgard);
            artist.Add(Postmalone);

            Display(artist);

            

            Program Song = new Program();


           // Console.WriteLine(Song.title);
           // Console.WriteLine(Song.duration);
        }

        private static void Display(List<Artist> artist)
        {
            throw new NotImplementedException();
        }

        public string DisplaySongTable()
        {
            return string.Format($"{Title,-15}{Artist,-7}{duration,-7}{Genre,-7}");
        }
        //public List<Playlist>()
        //{

        // }
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = .Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
