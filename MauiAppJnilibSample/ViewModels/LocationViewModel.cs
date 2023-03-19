﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Location = MauiAppJnilibSample.Models.Location;

namespace MauiAppJnilibSample.ViewModels
{
    public class LocationViewModel: BaseViewModel
    {
        public LocationViewModel(Location loc) : base("Location") 
        { 
            _location = loc;
        }

        private readonly Location _location;

        public float Latitude => _location.Latitude;
        public float Longitude => _location.Longitude;
    }
}
