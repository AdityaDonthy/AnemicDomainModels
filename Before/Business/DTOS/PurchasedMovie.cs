using System;


namespace Business.DTOS
{
    public class PurchasedMovieDto
    {
        public  long MovieId { get; set; }

        public  MovieDto Movie { get; set; }

        public  long CustomerId { get; set; }

        public  decimal Price { get; set; }

        public  DateTime PurchaseDate { get; set; }

        public  DateTime? ExpirationDate { get; set; }
    }
}