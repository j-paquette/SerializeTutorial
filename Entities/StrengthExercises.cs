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
        public string Circuits { get; set; }
        public string Bodyweight { get; set; }
        public string FreeWeights { get; set; }
        public string Resistance { get; set; }
    }
}
