using System;
using System.Collections.Generic;
using System.Text;
using WorkHours.Data.Models;

namespace WorkHours.Data.Repositories
{
    public interface IShiftsRepository
    {
        void AddShift(Shift shift);
        void RemoveShift(Shift shift);

        IEnumerable<Shift> GetAllShifts();
        Shift GetShift(int Id);
    }
}
