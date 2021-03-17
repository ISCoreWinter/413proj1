using System;
using System.Collections.Generic;
using System.Linq;

namespace _413proj1.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(ReservationInformation reservation)
        {
            CartLine line = Lines
                .Where(b => b.Reservation.TourId == reservation.TourId)
                .FirstOrDefault();

            //if (line == null)
            //{
                Lines.Add(new CartLine
                {
                    Reservation = reservation
                });
            //}
            //else
            //{
            //    line.Quantity += qty;
            //}
        }
        public virtual void RemoveLine(ReservationInformation reservation) =>
             Lines.RemoveAll(x => x.Reservation.TourId == reservation.TourId);
        public virtual void Clear() => Lines.Clear();

        //public double ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public ReservationInformation Reservation { get; set; }
            //public int Quantity { get; set; }
        }
    }
}
