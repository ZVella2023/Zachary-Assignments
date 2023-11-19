using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Flights
    {

        public Guid Id { get; set; }

        public string Rows { get; set; }

        public int Column { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string CountryFrom { get; set; }

        public string CountryTo { get; set; }

        public double WholesalePrice { get; set; }

        public double CommissionRate { get; set; }
    }
}
