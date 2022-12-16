using KnoxLogic.Responses;
using FluentAssertions;
using KnoxLogic.Validator;
using KnoxLogic;

namespace KnoxTest;


public class Knot_Unit_Test
{
    [TestMethod]
    public async Task IsSuccessTrue()
    {
        var initialResult = new Knot_API_Response();
        var finalResult = initialResult.IsAPIMessageSuccessful;
        finalResult.Should().Be(true);
    }
    [TestMethod]
    public async Task IsError()
    {
        var initialResult = new Knot_API_Response_Error();
        var finalResult = initialResult.IsResponseSuccessful;
        finalResult.Should().Be(true);
    }
    [TestMethod]
    public async Task DisplaySuccessMessage()
    {
        var initialResult = new Knot_API_Response();
        var finalResult = initialResult.APIResponseMessage;
        finalResult.Should().Be("Success");
    }
    [TestMethod]
    public async Task ErrorMessage()
    {
        var initialResult = new Knot_API_Response_Error();
        var finalResult = initialResult.ResponseMessage;
        finalResult.Should().Be("Success");
    }
    [TestMethod]
    public void CheckValidation()
    {
        var checkValidation = new Knot_SignUp_API_Validator();
        Assert.IsTrue(checkValidation.ValidateAsync)
    }
    [TestMethod]
    public void GenerateRandomNumber()
    {
        var randomNumber = Toolbox.generateId();
        for(int i=0; i < 10; i++)
        {
           
        }
    }
    public
}
