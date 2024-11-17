﻿using RunGroop.Data.Enums;
using RunGroop.Models;

namespace RunGroop.ViewModels
{
    public class CreateRaceViewModel
    {
        public int RaceId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IFormFile Image { get; set; }
        //public int AddressId { get; set; }

        public Address Address { get; set; }

        public RaceCategory RaceCategory { get; set; }
    }
}
