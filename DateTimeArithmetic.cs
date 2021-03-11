using System;
using System.Collections.Generic;
using System.Text;
using SerializeTutorial.Entities;

namespace SerializeTutorial
{
    /// <summary>
    /// Defines the integer values to indicate whether CanoeTrainingData.UtcDateTime is 
    /// earlier than/the same as/or later than the 10min timeLapse, to say that The 10min has expired
    /// </summary>
    public enum TimeComparison
    {
        EarlierThan = -1,
        TheSameAs = 0,
        LaterThan = 1
    }

    public class DateTimeArithmetic
    {
        /// <summary>
        /// Followed this example using TimeSpan: 
        /// https://docs.microsoft.com/en-us/dotnet/standard/datetime/performing-arithmetic-operations#comparisons-and-arithmetic-operations-with-datetimeoffset-values
        /// </summary>
        public string CompareUtcNowWithElapsedTime()
        {
            CanoeTrainingProgram trainingProgram = new CanoeTrainingProgram();

            trainingProgram.GetCanoeTrainingData();

            CanoeTrainingData exerciseList = trainingProgram.GetCanoeTrainingData();

            //UtcDateTimeNow from when GetCanoeTrainingData was run
            DateTime dateTimeUtcNowExerciseList = exerciseList.UtcDateTimeNow;

            //UtcDateTimeNow just now
            DateTime saveUtcNow = DateTime.UtcNow;

            //To set that after 10min, readin the .xml file has expired
            TimeSpan maxElapsedTime = new TimeSpan(0, 10, 0);

            //Calculate how many minutes have passed since UtcDateTimeNow was saved in GetCanoeTrainingData
            int trainingDataUtcNowMinusSaveNow = (saveUtcNow - dateTimeUtcNowExerciseList).Minutes;

            string timeComparison = Enum.GetName(typeof(TimeComparison), dateTimeUtcNowExerciseList.CompareTo(saveUtcNow));
            //TimeComparison valueTimeComparison = Enum.GetValues(typeof(TimeComparison), trainingDataUtcNow.CompareTo(saveUtcNow));

            //TimeComparison valueTimeComparison = Enum.Parse(typeof(TimeComparison), LaterThan.CompareTo(saveUtcNow));

            //TimeComparison timeComparison1 = (TimeComparison)int.Parse(Enum.GetName(typeof(TimeComparison), trainingDataUtcNow.CompareTo(saveUtcNow)));

            Console.WriteLine("Difference between saveUtcNow and trainingDataUtcNow : {0}:1:D2 hours",
                              trainingDataUtcNowMinusSaveNow);
            Console.WriteLine("The CanoeTrainingData Utc time is {0} Utc time taken now.",
                              timeComparison);

            //if (timeComparison == TimeComparison.LaterThan)
            //{

            //}
            return timeComparison;


        }
        

        

    }
}
