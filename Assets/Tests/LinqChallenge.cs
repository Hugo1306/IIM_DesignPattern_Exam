using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class LinqChallenge
{
    Health CreateHealth(int maxHealth, int startHealth)
        => new GameObject("Health GameObject")
            .AddComponent<Health>()
            .SetField("_maxHealth", maxHealth)
            .SetField("_startHealth", startHealth)
            .CallAwake();


    [Test]
    public void Even()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42, 9000 };

        // Act
        IEnumerable<int> Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act().ToList();

        // Assert 
        Assert.True(queryResult[0] == 12);
        Assert.True(queryResult[1] == 90);
        Assert.True(queryResult[2] == 22);
        Assert.True(queryResult[3] == 42);
        Assert.True(queryResult[4] == 9000);
    }

    [Test]
    public void EvenLess1000()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42, 9000, 998, 1002 };

        // Act
        IEnumerable<int> Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act().ToList();

        // Assert 
        Assert.True(queryResult[0] == 12);
        Assert.True(queryResult[1] == 90);
        Assert.True(queryResult[2] == 22);
        Assert.True(queryResult[3] == 42);
        Assert.True(queryResult[4] == 998);
    }

    [Test]
    public void Times2()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        IEnumerable<int> Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act().ToList();

        // Assert 
        Assert.True(queryResult[0] == 24);
        Assert.True(queryResult[1] == 6);
        Assert.True(queryResult[2] == 180);
        Assert.True(queryResult[3] == 44);
        Assert.True(queryResult[4] == 84);
    }

    [Test]
    public void Times3Even()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        IEnumerable<int> Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act().ToList();

        // Assert 
        Assert.True(queryResult[0] == 36);
        Assert.True(queryResult[1] == 270);
        Assert.True(queryResult[2] == 66);
        Assert.True(queryResult[3] == 126);
    }

    [Test]
    public void Order()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        IEnumerable<int> Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act().ToList();

        // Assert 
        Assert.True(queryResult[0] == 3);
        Assert.True(queryResult[1] == 12);
        Assert.True(queryResult[2] == 22);
        Assert.True(queryResult[3] == 42);
        Assert.True(queryResult[4] == 90);
    }

    [Test]
    public void OrderAndThenIsEven()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        IEnumerable<bool> Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act().ToList();

        // Assert 
        Assert.True(queryResult[0] == false);
        Assert.True(queryResult[1] == true);
        Assert.True(queryResult[2] == true);
        Assert.True(queryResult[3] == true);
        Assert.True(queryResult[3] == true);
    }

    [Test]
    public void TupleWithTimes2()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        IEnumerable<(int, int)> Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act().ToList();

        // Assert 
        Assert.True(queryResult[0] == (12, 24));
        Assert.True(queryResult[1] == (3, 6));
        Assert.True(queryResult[2] == (90, 180));
        Assert.True(queryResult[3] == (22, 44));
        Assert.True(queryResult[4] == (42, 84));
    }

    [Test]
    public void Average()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        double Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act();

        // Assert 
        Assert.IsTrue(queryResult == 33.8);
    }

    [Test]
    public void Min()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        int Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act();

        // Assert 
        Assert.IsTrue(queryResult == 3);
    }

    [Test]
    public void Max()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        int Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act();

        // Assert 
        Assert.IsTrue(queryResult == 90);
    }

    [Test]
    public void Sum()
    {
        // Arrange 
        List<int> values = new List<int>() { 12, 3, 90, 22, 42 };

        // Act
        int Act()
        {
            // Return la query linq ici
            throw new NotImplementedException();
        }
        var queryResult = Act();

        // Assert 
        Assert.IsTrue(queryResult == 169);
    }

}