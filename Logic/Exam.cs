
namespace Logic
{
    public class Exam
    {
        private string teacher;
        private DateTime date;
        private float coef;
        private float note;
        private bool isAbsent;

        public string Teacher
        {
            get => teacher;
            set
            {
                if (value == null) throw new Exception("The teacher mustn't be null");
                teacher = value;
            }
        }
        public DateTime Date { get; set; }
        public float Coef
        {
            get => coef;
            set
            {
                if (value <= 0) throw new Exception("The coef must be >0");
                coef = value;
            }
        }
        public float Note
        {
            get => note;
            set
            {
                if (note < 0 || note > 20) throw new Exception("The note must be between 0 and 20");
                note = value;
            }
        }
        public bool IsAbsent
        {
            get => isAbsent;
            set
            {
                isAbsent = value;
                if (value == true) Note = 0;
            }
        }
    }
}
