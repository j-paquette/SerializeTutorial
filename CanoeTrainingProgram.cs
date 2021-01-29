using System;
using System.Collections.Generic;
using System.Text;
using SerializeTutorial.Entities;

namespace SerializeTutorial
{
    [Serializable]
    public class CanoeTrainingProgram
    {
        /// <summary>
        /// Replaced List<CanoeTrainingExercise> by a new class: CanoeTrainingData.
        /// This allows more flexibility, in case I decide to add more properties later.
        /// It allows for customizing the format of the xml field/property headers 
        /// from <ArrayOfCanoeTrainingExercises></ArrayOfCanoeTrainingExercises> in ExerciseList.xml to 
        /// a name that is more relevant, that we choose.
        /// Also allows to add additional xml attributes.
        /// </summary>
        /// <returns>data</returns>
        public CanoeTrainingData GetCanoeTrainingData()
        {
            List<CanoeTrainingExercise> canoeTrainingExercise = new List<CanoeTrainingExercise>();

            UpdateListWithCanoeTrainingExercise(canoeTrainingExercise);
           
            //return new CanoeTrainingData {CanoeTrainingExercises = canoeTrainingExercise};
            //The following code does the same thing as the line above, just more detailed to show the process
            var data = new CanoeTrainingData();

            data.CanoeTrainingExercises = canoeTrainingExercise;

            return data;
        }

        /// <summary>
        /// This method updates canoeTrainingList with values
        /// </summary>
        /// <param name="canoeTrainingList"></param>
        public void UpdateListWithCanoeTrainingExercise(List<CanoeTrainingExercise> canoeTrainingList)
        {
            CanoeTrainingExercise exercises;

            exercises = new CanoeTrainingExercise()
            {
                CanoeExerciseID = 1,
                Endurance = "cross-country skiing",
                CoreWork = "Boat pose",
                Stretching = "Downward dog"
            };

            canoeTrainingList.Add(exercises);

            exercises.StrengthExercises.Add(new StrengthExercise()
            {
                Circuits = "Pyramid 1-2-3-2-1",
                Bodyweight = "Pushups",
                FreeWeights = "150lb deadlifts",
                Resistance = "WoodChops"
            });
        }
    }
}
