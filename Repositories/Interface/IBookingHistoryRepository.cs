using BusinessObjects;
using DataAccessLayer.DTO;
using DataAccessLayer.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IBookingHistoryRepository
    {
        Task<BookingReservation?> GetBookingById(int id);
        Task<List<BookingHistoryDTO>> GetBookingByCusId(int id);
        BookingReservation CreateBooking(BookingDTO booking);
        Task UpdateBooking(BookingHistoryDTO booking);
        Task UpdateBooking(BookingReservation booking);
        int CountBookings();
        decimal? CalcRevenue();
    }
}
