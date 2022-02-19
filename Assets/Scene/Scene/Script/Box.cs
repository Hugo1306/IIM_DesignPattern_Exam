using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, ITouchable
{
    [SerializeField] GameObject _potionPrefab;
    [SerializeField] PotionsParentReference _instanceParent;

    public void Touch()
    {
        int i = Random.Range(1, 3);

        if (i == 1)
        {
            var b = Instantiate(_potionPrefab, gameObject.transform.position, Quaternion.identity, _instanceParent.Instance.transform);
        }

        Destroy(gameObject);
    }
}
