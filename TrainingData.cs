using System;
using System.Collections.Generic;
using System.Text;
using SerializeTutorial.Entities;
using SerializeTutorial;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace SerializeTutorial
{
    public class TrainingData
    {
        /// <summary>
        /// Writes the values collected into CanoeTrainingData to ExerciseList.xml
        /// TODO: Can this be replaced with Designer Serialization (DesignerSerializationManager class)?
        /// </summary>
        public void WriteXml()
        {
            CanoeTrainingProgram trainingProgram = new CanoeTrainingProgram();

            CanoeTrainingData exerciseList = trainingProgram.GetCanoeTrainingData();

            //Insert code to set properties and fields of the object
            XmlSerializer myWriter = new XmlSerializer(typeof(CanoeTrainingData));

            //TODO: maybe use chaining to encrypt/compress/send by network/send to rest api(Json)/new memorystream to make it more secure?
            StreamWriter file = new StreamWriter(@"C:\FileStream\ExerciseList.xml");

            myWriter.Serialize(file, exerciseList);
            file.Close();
        }

        /// <summary>
        /// Reads the values collected into CanoeTrainingData to ExerciseList.xml
        /// TODO: Can this be replaced with Designer Serialization (DesignerSerializationManager class)?
        /// </summary>
        public void ReadXml()
        {

            //Insert code to set properties and fields of the object
            XmlSerializer myReader = new XmlSerializer(typeof(CanoeTrainingData));

            //TODO: maybe use chaining to encrypt/compress/send by network/send to rest api(Json)/new memorystream to make it more secure?
            StreamReader file = new StreamReader(@"C:\FileStream\ExerciseList.xml");

            CanoeTrainingData exerciseList = (CanoeTrainingData)myReader.Deserialize(file);
            file.Close();

            Console.WriteLine(exerciseList);
        }
    }
}
