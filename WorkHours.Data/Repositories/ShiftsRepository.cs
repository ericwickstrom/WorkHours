using System;
using System.Collections.Generic;
using System.Text;
using WorkHours.Data.Models;

namespace WorkHours.Data.Repositories
{
    public class ShiftsRepository : IShiftsRepository
    {
        private List<Shift> _repo;

        public ShiftsRepository()
        {
            _repo = new List<Shift>();
            populate();
        }

        private void populate()
        {
        }

        public void AddShift(Shift shift)
        {
            _repo.Add(shift);
        }

        public void RemoveShift(Shift shift)
        {
            _repo.Remove(shift);
        }

        public Shift GetShift(int Id)
        {
            return _repo.Find(s => s.Id == Id);
        }


        public IEnumerable<Shift> GetAllShifts()
        {
            return _repo;
        }
    }
}
