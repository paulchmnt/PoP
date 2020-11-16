using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_02
{
    class PhotoAlbum
    {
        // Attribute
        private int numberOfPages;

        // Constructors
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        // Functions
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
