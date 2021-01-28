using System;
using System.Collections.Generic;
using System.Text;
using SerializeTutorial.Entities;

namespace SerializeTutorial
{
    [Serializable]
    public class CanoeTrainingProgram
    {
        public CanoeTrainingData GetCanoeTrainingData()
        {
            List<CanoeTrainingExercise> canoeTrainingExercise = new List<CanoeTrainingExercise>();

            UpdateListWithCanoeTrainingExercise(canoeTrainingExercise);
            //Allows for future updates, adding new properties to CanoeTrainingData, and customize xml from Array... to CanoeTrainingData 
            //return new CanoeTrainingData {CanoeTrainingExercises = canoeTrainingExercise};

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
