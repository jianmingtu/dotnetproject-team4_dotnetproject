﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class Movie : BaseEntity
    {
        public string Overview { get; private set; }
        public string PosterPath { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string Title { get; private set; }
        public int MovieId { get; private set; }      
        public int GenreId { get; private set; }       
        public int CategoryId { get; private set; }

        public virtual MovieCategory MovieCategory { get; set; }

        public Movie(string title,
            int movieId,
                     string overview,
                     DateTime releaseDate,
                     int genreId,
                     string posterPath,
                     int categoryId)
        {
            GenreId = genreId;
            MovieId = movieId;
            Overview = overview;
            PosterPath = posterPath;
            ReleaseDate = releaseDate;
            Title = title;                  
            CategoryId = categoryId;
        }
    }
}