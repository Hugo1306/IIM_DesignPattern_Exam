using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyToggle : MonoBehaviour, ITouchable, IStates
{
    // Je veux ouvrir un évènement pour les designers pour qu'ils puissent set la couleur du sprite eux même
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] Color _onToggleOn;
    [SerializeField] Color _onToggleOff;
    [SerializeField] UnityEvent _onStateChange;
    [SerializeField] Gate _gate;

    public bool IsActive { get; private set; }


    public event UnityAction OnStateChange { add => _onStateChange.AddListener(value); remove => _onStateChange.RemoveListener(value); }


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
        _onStateChange.Invoke();
        Touch();
        _gate.CheckToggles();
    }
}
