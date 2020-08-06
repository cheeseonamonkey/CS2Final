using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


    class Date : IComparable
    {
        int month, day, year;

        public int Month
        {
            get => month;
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                {
                    month = 1;
                    //Write($"Month {value} is invalid, setting to default January.\n");
                }
            }
        }
        public int Day
        {
            get => day;
            set
            {
                int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (Month == 2 && IsLeap())
                {
                    if (value >= 1 && value <= 29)
                        day = value;
                    else
                    {
              //          Write($"Day {value} is invalid for leap month {Month}, setting to default 1.\n");
                        day = 1;
                    }
                }
                else if (value >= 1 && value <= monthDays[Month - 1])
                    day = value;
                else
                {
                    day = 1;
                   // Write($"Day {value} is invalid for month {Month}, setting to default 1.\n");
                }
            }
        }
        public int Year
        {
            get => year;
            set
            {
                if (value < 100)
                {
                    year = value + 2000;
                }
                else if (value >= 1800 && value <= 2200)
                    year = value;
                else
                {
                    year = 2001;
                    //Write($"Year of {value} is invalid, setting to default 2001.\n");
                }
            }
        }

        public Date(int m, int d, int y)
        {
            Month = m;
            Year = y;
            Day = d;
        }

        public int CompareTo(object obj)
        {
            Date other = obj as Date;
            if (Year < other.Year)
            {
                return -1;
            }
            else if(Year > other.Year)
            {
                return 1;
            }
            else //(Year == other.Year)
            {
                if (Month < other.Month)
                {
                    return -1;
                }
                else if (Month > other.Month)
                {
                    return 1;
                }
                else //(Month == other.Month)
                {
                    if (Day < other.Day)
                    {
                        return -1;
                    }
                    else if (Day > other.Day)
                    {
                        return 1;
                    }
                    else //(Day == other.Day)
                    {
                        return 0;
                    }
                }
            }
        }

        public static Date operator +(Date lhs, int rhs)
        {
            Date d = new Date(lhs.Month, lhs.Day, lhs.Year);
            for(int i=0;i<rhs;i++)
            {
                d.AddDay();
            }

            return d;
        }
        
        public bool IsLeap()
        {
            if (Year % 4 == 0)
                return true;
            else
                return false;
        }

        public void AddDay()
        {
            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (Month == 2 && IsLeap() && Day == 29) //leap day
            {
                Day += 1;
                Month += 1;
           //      Write("AAA");

            }
            else if (Month == 2 && IsLeap()==false && Day == 28) //non leap day
            {
                Day++;
                Month++;
            //     Write("BBB");

            }
            else if (Day == 31 && Month == 12) //end of year
            {
                Day += 1;
                Month = 1;
                Year += 1;
            //     Write("CCC");
            }
            else if (Day == monthDays[Month - 1] && IsLeap()==false) //other months
            {
                Day += 1;
                Month += 1;

              //    Write("DDD");
            }
            else if (Day == monthDays[Month - 1] && Month != 2 && IsLeap()) //other months
            {
                Day += 1;
                Month += 1;

         //       Write("EEE");
            }
            else
            {
                Day += 1;
            }
        }

        public void Display() => Write($"The date is: {this.ToString()}\n\n");
        public override string ToString() => $"{Month,2}/{Day,2}/{Year}";

}

