using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private int attack = 5;
    private int durability = 5;
    private Axe axe;
    private Dummy dummy;
    
    [SetUp]
    public void SetUp()
    {
        axe = new Axe(attack,durability);
        dummy = new Dummy(5,6);
    }


    [Test]
    public void When_AxeattackAndDurbility_ShouldBeSetCorrectly()
    {
        
        Assert.AreEqual(axe.AttackPoints, attack);
        Assert.AreEqual(axe.DurabilityPoints, durability);

    }
    [Test]
    public void When_AxeAttackLooseDurabilityPOint()
    {
        axe.Attack(dummy);
        Assert.AreEqual(axe.DurabilityPoints, durability - 1);
    }
    [Test]
    public void When_AxeDurabilityPointsAreZero_ShouldThrowException() 
    {
        dummy = new Dummy(5000, 5000);
        InvalidOperationException ex=Assert.Throws<InvalidOperationException>(() =>
        {
            for (int i = 0; i < 7; i++)
            {
                axe.Attack(dummy);
            }
        });

        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }
}