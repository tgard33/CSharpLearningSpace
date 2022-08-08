﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    internal class GetterAndSetterEX
    {
        public string title;
        public string director;
        private string rating;

        public GetterAndSetterEX(string aTitle, string aDirector, string aRating)
        { 
            title = aTitle;
            director = aDirector;   
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else 
                {
                    rating = "NR";
                }
            }
        }
    }
}
