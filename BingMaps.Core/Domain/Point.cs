using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMaps.Core.Domain
{
    public class Point : Entity
    {
        public string Address { get; protected set; }
        public double Latitude { get; protected set; }
        public double Longitude { get; protected set; }

            protected Point()
            {
            }

            protected Point(string address, double latitude, double longitude)
            {
                Create = DateTime.UtcNow;
                UpdatedAt = DateTime.UtcNow;
                SetAdress(address);
                SetLatitude(latitude);
                SetLongitude(longitude);
            }

            private void SetAdress(string address)
            {
                if (string.IsNullOrWhiteSpace(address))
                {
                    throw new Exception("Adress is empty.");
                }

                Address = address;
                UpdatedAt = DateTime.UtcNow;
            }

            private void SetLongitude(double longitude)
            {
                if (double.IsNaN(longitude))
                {
                    throw new Exception("Longitude must be a number.");
                }
                if (Longitude == longitude)
                {
                    return;
                }

                Longitude = longitude;
                UpdatedAt = DateTime.UtcNow;
            }

            private void SetLatitude(double latitude)
            {
                if (double.IsNaN(Latitude))
                {
                    throw new Exception("Latitude must be a number.");
                }
                if (Latitude == latitude)
                {
                    return;
                }

                Latitude = latitude;
                UpdatedAt = DateTime.UtcNow;
            }
        }
}
