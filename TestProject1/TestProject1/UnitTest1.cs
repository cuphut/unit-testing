using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getLetterScore_C()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "TranVanA";
            s.Age = 21;
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void getLetterScore_D()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "TranVanA";
            s.Age = 21;
            s.Score = 4.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void getLetterScore_A()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "TranVanA";
            s.Age = 21;
            s.Score = 9;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void getLetterScore_B()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "TranVanA";
            s.Age = 21;
            s.Score = 7.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void ScoreGreaterThan10_ShowException()
        {
            Student s = new Student();
            bool exceptionOccured = false;
            try
            {
                s.Score = 100;
            }
            catch(SystemException e)
            {
                exceptionOccured = true;
            }
            Assert.AreEqual(true, exceptionOccured);
        }

        
    }
}