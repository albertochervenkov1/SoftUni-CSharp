﻿using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy dummy;
    private Dummy deadDummy;
    private const int health = 5;
    private const int experience = 10;
    [SetUp]
    public void SetUp()
    {
        dummy = new Dummy(health, experience);
        deadDummy = new Dummy(-5, experience);
    }
    [Test]
    public void When_HealthIsProvided_ShouldBeSetCorrectly()
    {
        Assert.That(dummy.Health, Is.EqualTo(health));
    }
    [Test]
    public void When_Attacked_ShouldDecreaseHelath()
    {
        int attPoints = 3;
        dummy.TakeAttack(attPoints);
        Assert.That(dummy.Health, Is.EqualTo(health - attPoints));
    }
    [Test]
    public void When_AttackedDeummyIsDead_ShouldThrow()
    {
       
        Assert.That(() =>
        {
            deadDummy.TakeAttack(5);
        }, Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));

    }
    [Test]
    public void When_HealthIsPositive_ShouldBeAlive()
    {
        Assert.That(dummy.IsDead(), Is.EqualTo(false));
    }
    [Test]
    public void When_HealthIsZero_ShouldBeDead()
    {
        dummy = new Dummy(0, experience);
        Assert.That(dummy.IsDead(), Is.EqualTo(true));
    }
    [Test]
    public void When_HealthIsNegative_ShouldBeDead()
    {
        
        Assert.That(deadDummy.IsDead(), Is.EqualTo(true));
    }
    [Test]
    public void When_Dead_ShouldGiveExperience()
    {
        Assert.That(deadDummy.GiveExperience, Is.EqualTo(experience));
    }
    [Test]
    public void When_AliveGiveExperience_ShouldThrow()
    {
        Assert.That(() =>
        {
            dummy.GiveExperience();
        },Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));    
    }

}
