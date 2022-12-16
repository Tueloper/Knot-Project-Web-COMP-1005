using KnoxLogic.Responses;
using FluentAssertions;

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
}
