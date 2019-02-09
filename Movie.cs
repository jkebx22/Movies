using System;

namespace MovieStorage
{
    public class Movie
    {

        public string title;
        public string director;
        public string year;

        public Movie() { }

        public Movie(string theTitle, string theDirector, string theYear)
        {

            theTitle = title;
            theDirector = director;
            theYear = year;
        }

        public string Title
        {
            get { return title; }
            set { Title = title; }
        }

        public string Director
        {
            get { return director; }
            set { Director = director; }
        }

        public string Year
        {
            get { return year; }
            set { Year = year; }
        }

    }
    }