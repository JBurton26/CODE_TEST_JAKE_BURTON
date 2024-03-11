using TextProcessing.SubStringProcessor;

namespace SubStringTest
{
    [TestClass]
    public class SubStringTest
    {
        // Consistent Variable throughout all tests
        string fullString = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

        // Test with known values for substring "Polly"
        [TestMethod]
        public void SubStringTestPollyLeadingUpper()
        {
            string subString = "Polly";
            SubStringProcessor subStringProcessor = new SubStringProcessor(fullString, subString);
            Assert.AreEqual(subStringProcessor.Positions.Count, 3);
            Assert.AreEqual(subStringProcessor.Positions[0], 1);
            Assert.AreEqual(subStringProcessor.Positions[1], 26);
            Assert.AreEqual(subStringProcessor.Positions[2], 51);
        }

        // Test with known values for substring "polly"
        [TestMethod]
        public void SubStringTestPollyAllLower()
        {
            string subString = "polly";
            SubStringProcessor subStringProcessor = new SubStringProcessor(fullString, subString);
            Assert.AreEqual(subStringProcessor.Positions.Count, 3);
            Assert.AreEqual(subStringProcessor.Positions[0], 1);
            Assert.AreEqual(subStringProcessor.Positions[1], 26);
            Assert.AreEqual(subStringProcessor.Positions[2], 51);
        }

        // Test with known values for substring "ll"
        [TestMethod]
        public void SubStringTestLlAllLower()
        {
            string subString = "ll";
            SubStringProcessor subStringProcessor = new SubStringProcessor(fullString, subString);
            Assert.AreEqual(subStringProcessor.Positions.Count, 5);
            Assert.AreEqual(subStringProcessor.Positions[0], 3);
            Assert.AreEqual(subStringProcessor.Positions[1], 28);
            Assert.AreEqual(subStringProcessor.Positions[2], 53);
            Assert.AreEqual(subStringProcessor.Positions[3], 78);
            Assert.AreEqual(subStringProcessor.Positions[4], 82);
        }

        // Test with known values for substring "Ll"
        [TestMethod]
        public void SubStringTestLlLeadingUpper()
        {
            string subString = "Ll";
            SubStringProcessor subStringProcessor = new SubStringProcessor(fullString, subString);
            Assert.AreEqual(subStringProcessor.Positions.Count, 5);
            Assert.AreEqual(subStringProcessor.Positions[0], 3);
            Assert.AreEqual(subStringProcessor.Positions[1], 28);
            Assert.AreEqual(subStringProcessor.Positions[2], 53);
            Assert.AreEqual(subStringProcessor.Positions[3], 78);
            Assert.AreEqual(subStringProcessor.Positions[4], 82);
        }

        // Test with known values for substring "X"
        [TestMethod]
        public void SubStringTestXNoValue()
        {
            string subString = "X";
            SubStringProcessor subStringProcessor = new SubStringProcessor(fullString, subString);
            Assert.AreEqual(subStringProcessor.Positions.Count, 0);
        }

        // Test with known values for substring "12344"
        [TestMethod]
        public void SubStringTest1234NoValue()
        {
            string subString = "12344";
            SubStringProcessor subStringProcessor = new SubStringProcessor(fullString, subString);
            Assert.AreEqual(subStringProcessor.Positions.Count, 0);
        }
    }
}