using System;
using System.Xml.Linq;

namespace Lab10_Movie_Database
{
	public class Movies
	{
		//Properties
        public string Title { get; set; }
        public string Category { get; set; }

        //Constructor
        public Movies(string _title, string _category)
		{
            Title = _title;
            Category = _category;
		}

        //Methods
        public string GetGenreMovies()
        {
            return "- " + Title;

        }
    }
}
