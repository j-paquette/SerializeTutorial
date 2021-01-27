using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using SerializeTutorial.Entities;
using SerializeTutorial;
using System.Xml;
using System.Xml.Serialization;

namespace SerializeTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            //////Initialize an object
            ////Tutorial obj = new Tutorial();
            ////obj.ID = 1;
            ////obj.Name = ".Net";

            //////Create the filestream
            ////IFormatter formatter = new BinaryFormatter();
            ////Stream stream = new FileStream(@"C:\FileStream\Sample.txt", FileMode.Create, FileAccess.Write);

            //////Serialize the object
            ////formatter.Serialize(stream, obj);
            ////stream.Close();

            ////stream = new FileStream(@"C:\FileStream\Sample.txt", FileMode.Open, FileAccess.Read);
            ////Tutorial objNew = (Tutorial)formatter.Deserialize(stream);

            ////Console.WriteLine(objNew.ID);
            ////Console.WriteLine(objNew.Name);

            //New section
            CanoeTrainingProgram trainingProgram = new CanoeTrainingProgram();

            List<CanoeTrainingExercises> exercises = trainingProgram.GetExerciseList();

            //foreach (CanoeTrainingExercises item in exercises)
            //{
            //    foreach (StrengthExercises strength in item.StrengthExercisesList)
            //    {
            //        StringBuilder strengthStringBuilder = new StringBuilder();

            //        strengthStringBuilder.Append($"{item.CanoeExerciseID},");
            //        strengthStringBuilder.Append($"{strength.Bodyweight},");
            //        strengthStringBuilder.Append($"{strength.Circuits},");
            //        strengthStringBuilder.Append($"{strength.FreeWeights},");
            //        strengthStringBuilder.Append($"{strength.Resistance},");
            //        Console.WriteLine(strengthStringBuilder);
            //    }
            //    Console.WriteLine($"{item.CanoeExerciseID}, {item.CoreWork}, {item.Endurance}, {item.Stretching}");
            //    Console.WriteLine();
            //}

            //Serialize the object
            XmlSerializer mySerializer = new XmlSerializer(typeof(List<CanoeTrainingExercises>));
            StreamWriter myWriter = new StreamWriter("ExerciseList.xml");
            mySerializer.Serialize(myWriter, exercises);
            myWriter.Close();

            //To read the file, create a FileStream.
            var myFileStreamDeserialize = new FileStream("ExerciseList.xml", FileMode.Open);

            //Call the Deserialize method and cast to the object type.
            exercises = (CanoeTrainingProgram)mySerializer.Deserialize(myFileStreamDeserialize);
        }
    }
}
