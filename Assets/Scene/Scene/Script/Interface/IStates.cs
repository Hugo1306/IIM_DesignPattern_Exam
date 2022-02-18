using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public interface IStates
{

    event UnityAction OnStateChange;

    void ChangeState();
}
