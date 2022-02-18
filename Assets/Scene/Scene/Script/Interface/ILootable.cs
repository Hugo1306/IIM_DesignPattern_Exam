using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface ILootable
{
    GameObject MainObj { get; }

    //event UnityAction OnCollision;

    void TakeObject();
}
