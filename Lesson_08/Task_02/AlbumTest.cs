using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_02
{
    class AlbumTest
    {
        public void Main()
        {
            PhotoAlbum album1 = new PhotoAlbum();
            PhotoAlbum album2 = new PhotoAlbum(24);
            BigPhotoAlbum album3 = new BigPhotoAlbum();

            Console.WriteLine($"Number of pages of album 1: {album1.GetNumberOfPages()}");
            Console.WriteLine($"Number of pages of album 2: {album2.GetNumberOfPages()}");
            Console.WriteLine($"Number of pages of album 3: {album3.GetNumberOfPages()}");
        }
    }
}
