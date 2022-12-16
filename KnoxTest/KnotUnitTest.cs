using KnoxLogic.Responses;
using FluentAssertions;

namespace KnoxTest;


public class KnotUnitTest
{
    [TestMethod]
    public async Task IsSuccessTrue()
    {
        var initialResult = new APIResponse();
        var finalResult = initialResult.IsAPIMessageSuccessful;
        finalResult.Should().Be(true);
    }
    [TestMethod]
    public async Task IsError()
    {
        var initialResult = new ApiResponseError();
        var finalResult = initialResult.IsResponseSuccessful;
        finalResult.Should().Be(true);
    }
    [TestMethod]
    public async Task DisplaySuccessMessage()
    {
        var initialResult = new APIResponse();
        var finalResult = initialResult.APIResponseMessage;
        finalResult.Should().Be("Success");
    }
    [TestMethod]
    public async Task ErrorMessage()
    {
        var initialResult = new ApiResponseError();
        var finalResult = initialResult.ResponseMessage;
        finalResult.Should().Be("Success");
    }
}
