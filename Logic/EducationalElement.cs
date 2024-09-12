
namespace Logic
{
    public class EducationalElement
    {
        private string name;
        private float coef;

        public string Name
        {
            get => name;
            set
            {
                if (value == null) throw new Exception("The name mustn't be null");
                name = value;
            }
        }
        public float Coef
        {
            get => coef;
            set
            {
                if (value <= 0) throw new Exception("The coef must be >0");
                coef = value;
            }
        }
    }
}
