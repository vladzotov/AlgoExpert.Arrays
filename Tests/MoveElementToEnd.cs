using MoveElementToEnd;

namespace Tests;

[TestClass]
public class MoveElementToEnd
{
    [TestMethod]
    public void MoveElementToEnd_DefaultCase_ChangedArray()
    {
        //arrange
        List<int> array = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
        int toMove = 2;
        List<int> expectedStart = new List<int> {4, 1, 3};
        List<int> expectedEnd = new List<int> {2, 2, 2, 2, 2};

        //act
        var output = new MoveElementToEndIssue().MoveElementToEnd(array, toMove);
        List<int> outputStart = output.GetRange(0, 3);
        List<int> outputEnd = output.GetRange(3, output.Count - 3);

        //assert
        Assert.IsTrue(outputStart.SequenceEqual(expectedStart));
        Assert.IsTrue(outputEnd.SequenceEqual(expectedEnd));
    }
}
