﻿namespace BusinessObjects
{
    public partial class BookingDetail
    {
        public int BookingReservationId { get; set; }

        public int RoomId { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public decimal? ActualPrice { get; set; }

        public virtual BookingReservation BookingReservation { get; set; } = null!;

        public virtual RoomInformation Room { get; set; } = null!;
    }
}
