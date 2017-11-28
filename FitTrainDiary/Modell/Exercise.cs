namespace FitTrainDiary.Modell
{
    public class Exercise
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Justification Justification { get; set; }

        public Execution Execution { get; set; }
    }
}