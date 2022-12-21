namespace Tests;

public delegate bool Chief(bool isFoodReady);
public delegate string EatTheFood(string food);
public delegate int PayForTheFood(int price);


public class DelegateUnitTest
{

    public static bool MakeFood(bool isFoodReady)
    {
        return isFoodReady;
    }

    public static string Consume(string food)
    {
        return $"I ate the {food}";
    }

    public static int Payment(int price)
    {
        return price;
    }

    [Test]
    public void WhenBoolIsSent_ThenDelegateReturnsTheValue()
    {
        var chiefTestDelegate = new Chief(MakeFood);
        var result = chiefTestDelegate(true);

        //assert
        Assert.AreEqual(true, result);
    }

    [Test]
    public void WhenStringIsSent_ThenDelegateExecutesTheReferenceMethodAndReturnsTheNewString()
    {
        var eatTheFoodTestDelegate = new EatTheFood(Consume);
        var result = eatTheFoodTestDelegate("pancake");

        //assert
        Assert.AreEqual("I ate the pancake", result);
    }

    [Test]
    public void WhenIntegerIsSent_ThenDelegateExecutesTheReferenceMethodAnReturnsTheIntegerValue()
    {
        var eatTheFoodTestDelegate = new PayForTheFood(Payment);
        var result = eatTheFoodTestDelegate(10);

        //assert
        Assert.AreEqual(10, result);
    }


}