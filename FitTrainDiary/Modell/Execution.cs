using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FitTrainDiary.Modell
{
    [XmlRoot]
    public class Execution
    {
        private List<int> repeats = new List<int>();

        [DataMember]
        public int Weight { get; set; }

        [DataMember]
        public List<int> Repeats
        {
            get => repeats;
            set => repeats = value;
        }

    }
}