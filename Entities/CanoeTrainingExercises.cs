using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SerializeTutorial.Entities
{
    [Serializable]
    public class CanoeTrainingExercises
    {
        /// <summary>
        /// Where the canoe training object is stored
        /// Similar to ClientEntry
        /// </summary>
        public int CanoeExerciseID { get; set; }
        public string Endurance { get; set; }
        public string Stretching { get; set; }
        public string CoreWork { get; set; }
        public List<StrengthExercises> StrengthExercisesList { get; set; } = new List<StrengthExercises>();
    }
}
