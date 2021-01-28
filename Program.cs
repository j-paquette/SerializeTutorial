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
            WriteXml();
            
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
            //CanoeTrainingProgram trainingProgram = new CanoeTrainingProgram();

            //List<CanoeTrainingExercises> exerciseList = trainingProgram.GetExerciseList();

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

           

            ////To read the file, create a FileStream.
            //var myFileStreamDeserialize = new FileStream("ExerciseList.xml", FileMode.Open);

            ////Call the Deserialize method and cast to the object type.
            //trainingProgram = (CanoeTrainingProgram)mySerializer.Deserialize(myFileStreamDeserialize);

            //Console.WriteLine(trainingProgram);
        }

        public static void WriteXml()
        {
            CanoeTrainingProgram trainingProgram = new CanoeTrainingProgram();

            List<CanoeTrainingExercises> exerciseList = trainingProgram.GetExerciseList();

            //Insert code to set properties and fields of the object
            XmlSerializer myWriter = new XmlSerializer(typeof(List<CanoeTrainingExercises>));

            StreamWriter file = new StreamWriter(@"C:\FileStream\ExerciseList.xml");

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//ExerciseList.xml";
            //FileStream file = File.Create(path);

            myWriter.Serialize(file, exerciseList);
            file.Close();
        }

        public void ReadXml()
        {

            //WriteXml();

            //CanoeTrainingProgram trainingProgram = new CanoeTrainingProgram();
            //List<CanoeTrainingExercises> exerciseList = trainingProgram.GetExerciseList();

            //Insert code to set properties and fields of the object
            XmlSerializer myReader = new XmlSerializer(typeof(List<CanoeTrainingExercises>));

            StreamReader file = new StreamReader(@"C:\FileStream\ExerciseList.xml");

            List<CanoeTrainingExercises> exerciseList = (List<CanoeTrainingExercises>)myReader.Deserialize(file);
            file.Close();

            Console.WriteLine(exerciseList);
        }
    }
}
