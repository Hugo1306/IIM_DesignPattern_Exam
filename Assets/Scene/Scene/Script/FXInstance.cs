using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXInstance : MonoBehaviour
{

    void Awake()
    {
        Destroy(gameObject, 1f);
    }

}
