using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NHLAPI.API.Controllers;
using NHLAPI.Domain;
using System.Web.Http;

namespace NHLAPI.Tests;

public class Controllers 
{
    private NHLAPIController _controller;
    private Mock<ILogger<NHLAPIController>> _logger;

    public Controllers()
    {
        _logger = new Mock<ILogger<NHLAPIController>>();
        _controller = new NHLAPIController(_logger.Object);
    }


    [Fact]
    public async Task GetAllTeams_ReturnsTeams_WhenMethodIsCalled()
    {

        //act
        var result = await _controller.GetAllTeams();

        OkObjectResult OKObject = (OkObjectResult)result.Result;
        //assert
        OKObject.Value.Should().BeOfType<Teams>();
    }

    [Fact]
    public async Task GetAllTeams_ReturnsSuccessfully_WhenMethodIsCalled()
    {

        //act
        var result = await _controller.GetAllTeams();

        
        OkObjectResult OKObject = (OkObjectResult) result.Result;
        //assert
        OKObject.StatusCode.Should().Be(200);
    }
}