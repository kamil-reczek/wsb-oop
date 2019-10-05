using System;

namespace Zadanie0
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public int Year
        {
            get => year;
            set => year = value;
        }

        public int Month
        {
            get => month;
            set => month = value;
        }

        public int Day
        {
            get => day;
            set => day = value;
        }

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string getInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{year}-{month:D2}-{day:D2}";
        }
    }
}