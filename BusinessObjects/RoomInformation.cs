using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class RoomInformation
    {
        public int RoomId { get; set; }

        public string RoomNumber { get; set; } = null!;

        public string? RoomDetailDescription { get; set; }

        public int? RoomMaxCapacity { get; set; }

        public int RoomTypeId { get; set; }

        public byte? RoomStatus { get; set; }

        public decimal? RoomPricePerDay { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

        public virtual RoomType RoomType { get; set; } = null!;
    }

}
