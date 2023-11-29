using Domain.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Flight
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

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
