using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SerializeTutorial
{
    [Serializable]
    public class Tutorial
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
