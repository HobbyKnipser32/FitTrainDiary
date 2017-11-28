using System;
using System.Collections.Generic;

namespace FitTrainDiary.Modell
{
    public class Day
    {
        public DateTime TrainigsDay { get; set; }

        public List<Exercise> Exercises { get; set; }
    }
}