using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class RoomType
    {
        public int RoomTypeId { get; set; }

        public string RoomTypeName { get; set; } = null!;

        public string? TypeDescription { get; set; }

        public string? TypeNote { get; set; }

        public virtual ICollection<RoomInformation> RoomInformations { get; set; } = new List<RoomInformation>();
    }
}
