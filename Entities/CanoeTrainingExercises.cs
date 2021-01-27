using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeTutorial.Entities
{
    public class CanoeTrainingExercises
    {
        /// <summary>
        /// Where the canoe training object is stored
        /// Similar to ClientEntry
        /// </summary>
        public int CanoeTrainingID { get; set; }
        public string CanoeErg { get; set; }
        public string XcSkiing { get; set; }
        public string Running { get; set; }
        public List<StrengthExercises> StrengthExercisesList { get; set; } = new List<StrengthExercises>();
    }
}
