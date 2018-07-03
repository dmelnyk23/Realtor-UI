using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALUI.Models
{
    public class UserUI
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string PhoneNumber { get; set; }
        public List<int> Favourite { get; set; }
        public ICollection<LotUI> Lots { get; set; }
    }
}
