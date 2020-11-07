using System;
using System.Collections.Generic;
using Logic.Entities;

namespace Business.DTOS
{
    public class CustomerDto
    {
        public long Id { get; set; }
        
        public  string Name { get; set; }
        
        public  string Email { get; set; }
        
        public  CustomerStatus Status { get; set; }

        public  DateTime? StatusExpirationDate { get; set; }

        public  decimal MoneySpent { get; set; }

        public  List<PurchasedMovieDto> PurchasedMovies { get; set; }
    }
}