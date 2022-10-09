﻿using System;

namespace CeilInn1
{
    [Serializable]
    public class Occupancy
    {
        public int OccupancyNumber { get; set; }
        public DateTime DateOccupied { get; set; }
        public string ProcessedBy { get; set; }
        public string ProcessedFor { get; set; }
        public string RoomOccupied { get; set; }
        public double RateApplied { get; set; }
        public double PhoneUse { get; set; }

        public override bool Equals(object obj)
        {
            Occupancy rental = (Occupancy)obj;

            if (rental.OccupancyNumber == OccupancyNumber)
                return true;
            else
                return false;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}