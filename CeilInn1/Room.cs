﻿using System;

namespace CeilInn1
{
    [Serializable]
    public class Room
    {
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string BedType { get; set; }
        public double Rate { get; set; }
        public string OccupancyStatus { get; set; }

        public override bool Equals(object obj)
        {
            Room rm = (Room)obj;

            if (rm.RoomNumber == RoomNumber)
                return true;
            else
                return false;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}