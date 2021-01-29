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
            TrainingData trainingData = new TrainingData();
            trainingData.WriteXml();
            trainingData.ReadXml();
        }

       

 
    }
}
