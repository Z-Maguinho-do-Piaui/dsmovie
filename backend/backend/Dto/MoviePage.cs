using Backend.Domain.Entities.Movie;
using System;
using System.Collections.Generic;

namespace Backend.Dto
{
    public class MoviePage
    {
        public MoviePage(List<Movie> movies, int totalElements, int size, int actualPage)
        {
            SetPagination(movies, totalElements, size, actualPage);
        }

        public List<Movie> Content { get; set; }
        public bool Last { get; set; }
        public double TotalPages { get; set; }
        public int TotalElements { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
        public bool First { get; set; }
        
        // Não foram usados pelo Nélio
        public int NumberOfElements { get; set; }
        public bool Empty { get; set; }

        private void SetPagination(List<Movie> movies, int totalElements, int size, int actualPage)
        {
            Content = movies;
            Size = size;
            Number = actualPage;
            TotalElements = totalElements;
            TotalPages = Math.Ceiling(TotalElements / (double)Size);

            if (Number == 1)
                First = true;
            else
                First = false;

            if (Number == TotalPages)
                Last = true;
            else
                Last = false;
        }

    }
}
