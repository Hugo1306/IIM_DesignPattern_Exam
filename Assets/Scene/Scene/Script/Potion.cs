using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour, ILootable
{
    [SerializeField] GameObject potionObj;
    [SerializeField] int healAmount;
    [SerializeField] PlayerReference _playerRef;

    public GameObject MainObj => potionObj;  

    public void TakeObject()
    {
        _playerRef.Instance.Health.Heal(healAmount);
        potionObj.SetActive(false);
    }


}
