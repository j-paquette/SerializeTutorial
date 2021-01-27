using System;
using System.Collections.Generic;
using System.Text;
using SerializeTutorial.Entities;

namespace SerializeTutorial
{
    [Serializable]
    public class CanoeTrainingProgram
    {
        public List<CanoeTrainingExercises> GetExerciseList()
        {
            List<CanoeTrainingExercises> canoeTrainingExercises = new List<CanoeTrainingExercises>();

            UpdateListWithCanoeTrainingExercises(canoeTrainingExercises);

            return canoeTrainingExercises;
        }

        /// <summary>
        /// This method updates canoeTrainingList with values
        /// </summary>
        /// <param name="canoeTrainingList"></param>
        public void UpdateListWithCanoeTrainingExercises(List<CanoeTrainingExercises> canoeTrainingList)
        {
            CanoeTrainingExercises exercises;

            exercises = new CanoeTrainingExercises()
            {
                CanoeExerciseID = 1,
                Endurance = "cross-country skiing",
                CoreWork = "Boat pose",
                Stretching = "Downward dog"
            };

            canoeTrainingList.Add(exercises);

            exercises.StrengthExercisesList.Add(new StrengthExercises()
            {
                Circuits = "Pyramid 1-2-3-2-1",
                Bodyweight = "Pushups",
                FreeWeights = "150lb deadlifts",
                Resistance = "WoodChops"
            });
        }
    }
}
