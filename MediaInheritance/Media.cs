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

        string newLine = Environment.NewLine;
        private string studio;
        protected int length;

        public override string ToString()
        {
            return String.Format($"Name: {title}{newLine}Release year: {release_year}{newLine}Director: {creator}{newLine}Runtime: {length}{newLine}Studio: {studio}{newLine}{newLine}");
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

        string newLine = Environment.NewLine;
        private string publisher;
        protected int length;

        public override string ToString()
        {
            return String.Format($"Name: {title}{newLine}Release year: {release_year}{newLine}Author: {creator}{newLine}Number of pages: {length}{newLine}Publisher: {publisher}{newLine}{newLine}");
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

        string newLine = Environment.NewLine;
        private bool multiplayer;
        private string publisher;
        string genre;
        public override string ToString()
        {
            return String.Format($"Name: {title}{newLine}Genre: {genre}{newLine}Release year: {release_year}{newLine}Multiplayer: {multiplayer}{newLine}Studio: {creator}{newLine}Publisher: {publisher}{newLine}{newLine}");
        }
    }
}
