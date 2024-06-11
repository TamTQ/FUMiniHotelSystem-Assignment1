using BusinessObjects;
using DataAccessLayer.DTO.Request;
using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IBookingHistoryService
    {
        Task<BookingReservation?> GetBookingById(int id);
        Task<List<BookingHistoryDTO>> GetBookingByCusId(int id);
        BookingReservation CreateBooking(BookingDTO booking);
        Task UpdateBooking(BookingHistoryDTO booking);
        int CountBookings();
        decimal? CalcRevenue();
    }
}
