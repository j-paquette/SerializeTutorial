using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeTutorial.Entities
{
    public class StrengthExercises
    {
        /// <summary>
        /// Where the weight training exercises are stored
        /// Similar to AccountWebServiceStatsInfo
        /// </summary>
        public int ExerciseID { get; set; }
        public string CanoeLedge { get; set; }
        public string Plank { get; set; }
        public string WoodChops { get; set; }
        public string BenchPulls { get; set; }
        public string BenchPress { get; set; }
        public string DeadLifts { get; set; }
    }
}
