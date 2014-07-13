using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mapex_project.Repositories;

namespace Mapex_project.Models
{
    public class SiteDB
    {
    }
    
    public class Map
    {
        public string Name { get; set; }
        public LatLng LatLng { get; set; }
        public int Zoom { get; set; }

        private List<Location> locations = new List<Location>();

        public List<Location> Locations
        {
            get { return locations; }
            set { locations = value; }
        }
    }

    public class Location
    {
        public string Name { get; set; }
        public LatLng LatLng { get; set; }
    }

    public class LatLng
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}