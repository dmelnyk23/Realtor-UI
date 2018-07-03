using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALUI.Models
{
    public class PhotoUI
    {
        public int ID { get; set; }

        public string Path { get; set; }

        public LotUI Lot { get; set; }

    }
}
