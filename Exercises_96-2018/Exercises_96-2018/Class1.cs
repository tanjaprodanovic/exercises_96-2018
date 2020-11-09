using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_96_2018
{
    class ExerciseResult
    {
        public ExerciseResult(int id, string studentName, string studentIndex, int point)
        {
            Id = id;
            StudentName = studentName;
            StudentIndex = studentIndex;
            Point = point;
        }

        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int Point { get; set; }
        public override string ToString()
        {
            return "Id:" + Id + "Student:" + StudentName + "Index:" + StudentIndex + "Points:" + Point;
        }

    }
}
