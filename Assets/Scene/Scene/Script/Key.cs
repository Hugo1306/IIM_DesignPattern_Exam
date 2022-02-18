using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour, ILootable
{

    [SerializeField] GameObject gate;
    [SerializeField] GameObject keyObj;

    public GameObject MainObj => keyObj;

    public void TakeObject()
    {
        gate.SetActive(false);
        keyObj.SetActive(false);
    }
}
