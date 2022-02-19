using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Reference/PotionsParentReference")]
public class PotionsParentReferenceSetter : MonoBehaviour
{
    [SerializeField] Transform _entity;
    [SerializeField] PotionsParentReference _potionsParentRef;

    void Awake()
    {
        (_potionsParentRef as IReferenceSetter<Transform>).SetInstance(_entity);
    }
}
