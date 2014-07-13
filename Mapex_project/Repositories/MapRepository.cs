using Mapex_project.Models;

namespace Mapex_project.Repositories
{
    public class MapRepository
    {
        public Map GetById(int id)
        {
            return new Map
            {
                Name = "Places",
                Zoom = 1,
                LatLng = new LatLng { Latitude = 0.0, Longitude = 0.0, },
                Locations =
                           {
                               new Location
                               {
                                   Name = "St. Julians, Sevenoaks, UK",
                                   LatLng = new LatLng { Latitude = 51.25136, Longitude = 0.21992 }
                               },
                               new Location
                               {
                                   Name = "Sendai, Japan",
                                   LatLng = new LatLng { Latitude = 38.296441, Longitude = 140.831809 },
                               },
                               new Location
                               {
                                   Name = "Brunswick Square, Brighton, UK",
                                   LatLng = new LatLng { Latitude = 50.824342, Longitude = -0.158647 },
                               },
                               new Location
                               {
                                   Name = "Sydney, Australia",
                                   LatLng = new LatLng { Latitude = -33.881749, Longitude = 151.215485 },
                               }
                           }
            };
        }
    }
}