using System;
using System.Collections.Generic;
using System.Text;
using WorkHours.Data.Models;

namespace WorkHours.Data.Repositories
{
    public class ShiftsRepository
    {
        private List<Shift> _repo;

        public ShiftsRepository()
        {
            _repo = new List<Shift>();
            populate();
        }

        private void populate()
        {
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
            _repo.Add(new Shift { ScheduledStart = DateTime.Now, ScheduledEnd = DateTime.Now, ActualStart = DateTime.Now, ActualEnd = DateTime.Now });
        }

        public void AddShift(Shift shift)
        {
            _repo.Add(shift);
        }

        public List<Shift> GetAllShifts()
        {
            return _repo;
        }
    }
}
