namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Capture_The_Result_Of_1_plus_4_In_A_Class_Level_Variable_Named_Sum(){
        var math = new Math();
        Assert.Equal(5, math.Sum);
    }

    [Fact]
    public void Should_Capture_The_Result_Of_5_minus_2_In_A_Class_Level_Variable_Named_Difference(){
        var math = new Math();
        Assert.Equal(3, math.Difference);
    }

    [Fact]
    public void Should_Capture_The_Result_Of_3_multiplied_By_5_In_A_Class_Level_Variable_Named_Product(){
        var math = new Math();
        Assert.Equal(15, math.Product);
    }

    [Fact]
    public void Should_Capture_The_Result_Of_15_divided_By_2_In_A_Variable_Class_Level_Named_Quotient(){
        var math = new Math();
        Assert.Equal(7, math.Quotient);
    }

    [Fact]
    public void Should_Capture_The_Remainder_Of_7_Remainder_Of_2_In_A_Class_Level_Variable_Named_Remainder(){
        var math = new Math();
        Assert.Equal(1, math.Remainder);
    }
}