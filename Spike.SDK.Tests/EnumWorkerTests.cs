
namespace Spike.SDK.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using General.Enums;
    using Component = System.ComponentModel;

    public enum TestEnum
    {
        [Component.Description("None")]
        Undefined = 0,

        [Component.Description("First Seletion")]
        SelectionOne =1,

        [Component.Description("Second Selection")]
        SelectionTwo =2,

        [Component.Description("Third Selection")]
        SelectionThree =3
    }

    [TestClass]
    public class EnumWorkerTests
    {
        [TestMethod]
        public void GetEnumDescriptionValue()
        {
            var listOfOptions = TestEnum.SelectionThree.ToDescription();

            Assert.AreEqual("Third Selection", listOfOptions);
        }

        [TestMethod]
        public void GetEnumValueFromString()
        {
            var thirdOption = EnumWorker.ParseEnum<TestEnum>("Third Selection");

            Assert.AreEqual(TestEnum.SelectionThree, thirdOption);
        }
    }
}
