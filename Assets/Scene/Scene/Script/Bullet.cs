using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed;
    [SerializeField] float _collisionCooldown = 0.5f;
    [SerializeField] FXInstance _fxPrefab;
    [SerializeField] UnityEvent _instanceFXPrefabEvent;

    public Vector3 Direction { get; private set; }
    public int Power { get; private set; }
    float LaunchTime { get; set; }

    public event UnityAction InstanceFXPrefabAction { add => _instanceFXPrefabEvent.AddListener(value); remove => _instanceFXPrefabEvent.RemoveListener(value); }

    internal Bullet Init(Vector3 vector3, int power)
    {
        Direction = vector3;
        Power = power;
        LaunchTime = Time.fixedTime;
        return this;
    }

    void FixedUpdate()
    {
        _rb.MovePosition((transform.position + (Direction.normalized * _speed)));
    }
    
    void LateUpdate()
    {
        transform.rotation = EntityRotation.AimPositionToZRotation(transform.position, transform.position + Direction);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Time.fixedTime < LaunchTime + _collisionCooldown) return;

        collision.GetComponent<IHealth>()?.TakeDamage(Power);
        collision.GetComponent<IStates>()?.ChangeState();

        if (collision.GetComponent<IStates>() == null)
            collision.GetComponent<ITouchable>()?.Touch();

        if (collision.GetComponent<ObjectTrigger>() == null && collision.GetComponent<Potion>() == null)
        {
            _instanceFXPrefabEvent?.Invoke();
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Time.fixedTime < LaunchTime + _collisionCooldown) return;

        collision.collider.GetComponent<IHealth>()?.TakeDamage(Power);
        collision.collider.GetComponent<IStates>()?.ChangeState();

        Destroy(gameObject);
    }

    private void Health_OnDamage(int arg0)
    {
        throw new NotImplementedException();
    }

    public void InstanceFXPrefab()
    {
        Instantiate(_fxPrefab, gameObject.transform.position, Quaternion.identity, null);
    }
}
