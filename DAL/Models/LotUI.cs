using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALUI.Models
{
    public class LotUI
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public double Square { get; set; }
        public int RoomsCount { get; set; }
        public int Flour { get; set; }
        public bool Apartment { get; set; }
        public bool IsSold { get; set; }
        public bool IsReserved { get; set; }
        public bool House { get; set; }

        public AddressUI Address { get; set; }

        public ICollection<PhotoUI> Photos { get; set; }

        public UserUI User { get; set; }

    }
}
