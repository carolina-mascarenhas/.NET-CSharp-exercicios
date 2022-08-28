// using Xunit;
// using FluentAssertions;

// namespace variable.Test;

// public class UnitTest1
// {
//     [Fact]
//     public void TestVariableCreation()
//     {
//         Class1 instance = new();

//         var response = instance.someString is string;
//         response.Should().Be(true);
//     }
// }

// using Xunit;
// using FluentAssertions;

// namespace variable.Test;

// public class UnitTest1
// {
//     [Fact]
//     public void TestVariableConversion()
//     {
//         Class1 instance = new();

//         instance.intEntry.Should().Be(42);
//         var intTypeCheck = instance.intEntry is int;
//         intTypeCheck.Should().Be(true);

//         instance.Transform();

//         instance.doubleResponse.Should().Be(42.0);
//         var floatTypeCheck = instance.doubleResponse is double;
//         floatTypeCheck.Should().Be(true);
//     }
// }

using Xunit;
using FluentAssertions;

namespace variable.Test;

public class UnitTest1
{
    [Fact]
    public void TestVariableConversion()
    {
        Class1 instance = new();

        instance.strEntry.Should().Be("42");
        var strTypeCheck = instance.strEntry is string;
        strTypeCheck.Should().Be(true);

        instance.DoConversion();

        instance.intResponse.Should().Be(42);
        var intTypeCheck = instance.intResponse is int;
        intTypeCheck.Should().Be(true);
    }
}