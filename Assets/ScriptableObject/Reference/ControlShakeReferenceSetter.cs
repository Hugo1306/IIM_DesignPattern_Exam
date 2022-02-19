using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Reference/ControlShakeReference")]
public class ControlShakeReferenceSetter : MonoBehaviour
{
    [SerializeField] ControlShake _entity;
    [SerializeField] ControlShakeReference _controlShakeRef;

    void Awake()
    {
        (_controlShakeRef as IReferenceSetter<ControlShake>).SetInstance(_entity);
    }
}
