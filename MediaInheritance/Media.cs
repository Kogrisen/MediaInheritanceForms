using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaInheritance
{
    internal abstract class Media
    {
        protected string title;
        protected string release_year;
        //The creator is in case of a book the author, and for films it is the director. For games it's the studio
        protected string creator;
    }

    internal class Film : Media
    {
        public Film(string title, string release_year, string director, int length, string studio)
        {
            this.title = title;
            this.release_year = release_year;
            this.creator = director;
            this.length = length;
            this.studio = studio;
        }
        private string studio;
        protected int length;

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                "Release year: {1}\n" +
                "Director: {2}\n" +
                "Runtime: {3}\n" +
                "Studio: {4}\n", title, release_year, creator, length, studio);
        }
    }

    internal class Book : Media
    {
        public Book(string title, string release_year, string author, int pages, string publisher)
        {
            this.title = title;
            this.release_year = release_year;
            this.creator = author;
            this.length = pages;
            this.publisher = publisher;
        }

        private string publisher;
        protected int length;

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                "Release year: {1}\n" +
                "Author: {2}\n" +
                "Number of pages: {3}\n" +
                "Publisher: {4}\n", title, release_year, creator, length, publisher);
        }
    }

    internal class Game : Media
    {
        public Game(string title, string genre, string release_year, bool multiplayer, string studio, string publisher)
        {
            this.title = title;
            this.genre = genre;
            this.release_year = release_year;
            this.creator = studio;
            this.multiplayer = multiplayer;
            this.publisher = publisher;
        }
        private bool multiplayer;
        private string publisher;
        string genre;
        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                "Genre: {1}" +
                "Release year: {2}\n" +
                "Multiplayer: {3}\n" +
                "Studio: {4}\n" +
                "Publisher: {5}\n", title, genre, release_year, multiplayer, creator, publisher);
        }
    }
}
