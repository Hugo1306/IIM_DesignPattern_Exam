using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyToggle : MonoBehaviour, ITouchable, IStates
{
    // Je veux ouvrir un �v�nement pour les designers pour qu'ils puissent set la couleur du sprite eux m�me
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] Color _onToggleOn;
    [SerializeField] Color _onToggleOff;
    [SerializeField] Gate _gate;

    public bool IsActive { get; private set; }


    public void Touch()
    {
        IsActive = !IsActive;

        if (IsActive)
            sprite.color = _onToggleOn;
        else
            sprite.color = _onToggleOff;
    }

    public void ChangeState()
    {
        _gate.CheckToggles();
    }
}
