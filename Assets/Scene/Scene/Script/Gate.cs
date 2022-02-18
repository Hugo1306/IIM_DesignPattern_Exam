using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    public List<MyToggle> toggles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckToggles()
    {
        int iterator = 0;

        foreach(MyToggle toggle in toggles)
        {
            if (toggle.IsActive)
                iterator++;
        }

        if (iterator == toggles.Count)
            gameObject.SetActive(false);
    }
}
