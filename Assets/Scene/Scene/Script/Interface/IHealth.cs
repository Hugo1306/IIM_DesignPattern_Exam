using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IHealth 
{
    int CurrentHealth { get; }
    int MaxHealth { get; }
    bool IsDead { get; }
    bool IsShielded { get; }

    event UnityAction OnSpawn;
    event UnityAction<int> OnDamage;
    event UnityAction OnDeath;

    void TakeDamage(int amount);

}
