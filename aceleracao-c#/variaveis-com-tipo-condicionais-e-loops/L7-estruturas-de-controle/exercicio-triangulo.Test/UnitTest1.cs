using Xunit;
using FluentAssertions;

namespace exercicio_triangulo.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve classificar um triangulo")]
    [InlineData(2,2,2, "Triângulo Equilátero")]
    [InlineData(5,6,6, "Triângulo Isóscele")]
    [InlineData(6,2,6, "Triângulo Isóscele")]
    [InlineData(6,6,2, "Triângulo Isóscele")]
    [InlineData(1,2,3, "Triângulo Escaleno")]
    public void TestIdentifyTriangle(double xSide, double ySide, double zSide, string name)
    {
        var resultName = Triangle.IdentifyTriangle(xSide, ySide, zSide);

        resultName.Should().Be(name);
    }
}   