using KnoxLogic;

namespace KnoxTest;

[TestClass]
public class KnotUnitTest
{
    [TestMethod]
    public void TestUserCredentials()
    {
        string userName = "John";
        string userPwd = "123";
        string correctUserName = Knot.UserName("John");
        string correctUserPassword = Knot.UserPassword("123");
        Assert.AreEqual(userName, correctUserName);
        Assert.AreEqual(userPwd, correctUserPassword);
    }
}
