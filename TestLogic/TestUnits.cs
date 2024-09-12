using Logic;

namespace TestLogic
{
    public class TestUnits
    {
        [Fact]
        public void EducationalElement()
        {
            EducationalElement edcElm = new EducationalElement();

            Assert.Equal("Qualité", edcElm.Name = "Qualité");
            Assert.Throws<Exception>(() => { edcElm.Name = null; });

            Assert.Equal(0.6f, edcElm.Coef = 0.6f);
            Assert.Throws<Exception>(() => { edcElm.Coef = -3.14f; });
        }
    }
}