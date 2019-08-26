using System;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.baitap3.Model;

namespace BasicExercises2.baitap3
{
    public class Book : IBook
    {
        private int id;
        private string name;
        private string publishDate;
        private string author;
        private string language;
        private double averagePrice;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Language { get => language; set => language = value; }
        public double AveragePrice { get => averagePrice; }

        public void Display()
        {
            foreach( var booksItem in ArrayList)
            {
                if (booksItem != null)
                {
                    Console.WriteLine("Name: {0}, PublishDate: {1}, Author: {2}, Language: {3}, AveragePrice: {4} ",
                        booksItem.Name, booksItem.PublishDate, booksItem.Author, booksItem.Language, booksItem.AveragePrice);
                }
            }     
        }

        public int[] PriceList = new int[5];
        public BooksItem[] ArrayList = new BooksItem[100];

        public void Calculate()
        {
            var total = 0;
            for(int i=0;i < PriceList.Length;i++)
            {
                total += PriceList[i];
            }
            averagePrice = (double)(total / PriceList.Length);
        }

        public void InsertBook(int index)
        {
            Calculate();
            var booksItem = new BooksItem()
            {
                Id = id,
                Name = name,
                PublishDate = publishDate,
                Author = author,
                Language = language,
                AveragePrice = averagePrice
            };
            ArrayList[index] = booksItem;
        }

    }  
}
