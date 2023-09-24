using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    public class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            Console.WriteLine("Starting the Album program!");
            Console.WriteLine();
            ReadAndSaveAlbumData();
            Console.WriteLine();
            DisplayAlbumInfo();
        }

        public void ReadAndSaveAlbumData()
        {
            ReadAlbum();
            ReadArtist();
            ReadNumOfTracks();
        }

        private void ReadAlbum()
        {
            Console.WriteLine("What's the name of your favorite music album?");
            albumName = Console.ReadLine();
        }

        private void ReadArtist()
        {
            Console.WriteLine($"What is the name of the artist or band for \"{albumName}\"?");
            artistName = Console.ReadLine();
        }

        private void ReadNumOfTracks()
        {
            Console.WriteLine($"How many tracks does \"{albumName}\" have?");
            numOfTracks = int.Parse(Console.ReadLine());
        }

        public void DisplayAlbumInfo()
        {
            Console.WriteLine($"Album Name: {albumName}");
            Console.WriteLine($"Artist/Band: {artistName}");
            Console.WriteLine($"Number of Tracks: {numOfTracks}");
            Console.WriteLine("Enjoy listening!");
        }
    }
}
