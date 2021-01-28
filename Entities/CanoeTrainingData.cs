using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;


namespace SerializeTutorial.Entities
{
    [XmlRoot(ElementName = "CanoeTraining")]
    public class CanoeTrainingData
    {
        public List<CanoeTrainingExercise> CanoeTrainingExercises { get; set; }

        [XmlAttribute("Importance")]
        public int OtherValue { get; set; }
    }
}
