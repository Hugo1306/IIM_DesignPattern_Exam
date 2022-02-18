using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, ITouchable
{
    public void Touch()
    {
        Destroy(gameObject);
    }
}
