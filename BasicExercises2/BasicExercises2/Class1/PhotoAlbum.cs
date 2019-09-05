using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.Class
{
    class PhotoAlbum
    {
        private int numberOfPages;        // vị trí khai báo trong 1 class : 1 - biến , 2 - consutructor , 3 - phuơng thức

        public PhotoAlbum()           
        {
            NumberOfPages = 16;
           // Console.WriteLine(NumberOfPages);
        }

        public PhotoAlbum(int NumberOfPages)
        {
            numberOfPages = NumberOfPages;           
        }

        public int NumberOfPages { get => numberOfPages; set => numberOfPages = value; }  // phím tắt ctrl R E.



        /*public int GetNumberOfPages()
        {
            return NumberOfPages;
        }*/
    }
    class BigPhotoAlbum 
    {
        private int NumberPages;
        public BigPhotoAlbum()
        {
            NumberPages1 = 64;
           
        }

        public int NumberPages1 { get => NumberPages; set => NumberPages = value; }
    }
    class AlbumTest
    {
        static void Main()
        {
            PhotoAlbum myAlbum1 = new PhotoAlbum();           
            Console.WriteLine(myAlbum1.NumberOfPages);

            PhotoAlbum myAlbum2 = new PhotoAlbum(24);           
            Console.WriteLine(myAlbum2.NumberOfPages);

            BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.NumberPages1);
        }

    }
}
