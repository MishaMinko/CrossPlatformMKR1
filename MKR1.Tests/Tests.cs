using CrossPlatformMKR1;

namespace MKR1.Tests
{
    public class Tests
    {
        private Main lab = null!;

        [SetUp]
        public void Setup()
        {
            lab = new Main();
        }

        //checkArr method
        [Test]
        public void checkArrCorrect()
        {
            string[] arr = { "ABC", "abc" };
            Assert.IsFalse(lab.checkArr(arr));
        }

        [Test]
        public void checkArrNull()
        {
            string[] arr = null!;
            Assert.IsTrue(lab.checkArr(arr));
        }

        [Test]
        public void checkArrNotTwoLength()
        {
            string[] arr = { "Hello" };
            Assert.IsTrue(lab.checkArr(arr));
        }

        //chooseAppropriateResult method
        [Test]
        public void chooseAppropriateResultResShorter()
        {
            string res1 = "Abc";
            string res2 = "Abcde";
            Assert.That(lab.chooseAppropriateResult(res1, res2), Is.EqualTo(res1));
        }

        [Test]
        public void chooseAppropriateResultResLonger()
        {
            string res1 = "Abcde";
            string res2 = "Abc";
            Assert.That(lab.chooseAppropriateResult(res1, res2), Is.EqualTo(res2));
        }

        [Test]
        public void chooseAppropriateResultResEqual()
        {
            string res1 = "Abb";
            string res2 = "Agg";
            Assert.That(lab.chooseAppropriateResult(res1, res2), Is.EqualTo(res2));
        }

        //checkName method
        [Test]
        public void checkNameCorrect()
        {
            string name = "Abc";
            Assert.IsFalse(lab.checkName(name));
        }

        [Test]
        public void checkNameCorrectLonger()
        {
            string name = "Abc";
            for (int i = 0; i < 997; i++)
                name += "d";
            Assert.IsTrue(lab.checkName(name));
        }

        [Test]
        public void checkNameCorrectShorter()
        {
            string name = "A";
            Assert.IsTrue(lab.checkName(name));
        }

        //cutName method
        [Test]
        public void cutNameCorrect()
        {
            string name = "Abcd";
            int index = 2;
            Assert.That(lab.cutName(name, index), Is.EqualTo("Ab"));
        }
    }
}