using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Health : MonoBehaviour, IHealth, IStates
{
    // Champs
    [SerializeField] int _startHealth;
    [SerializeField] int _maxHealth;
    [SerializeField] bool _shielded = false;
    [SerializeField] GameObject _shield;
    [SerializeField] ControlShakeReference _controlShakeRef;
    [SerializeField] UnityEvent<int> _onDamage;
    [SerializeField] UnityEvent _onDeath;

    // Propriétés
    public int CurrentHealth { get; private set; }
    public int MaxHealth => _maxHealth;
    public bool IsDead => CurrentHealth <= 0;
    public bool IsShielded { get; private set; }

    // Events
    public event UnityAction OnSpawn;
    public event UnityAction<int> OnDamage { add => _onDamage.AddListener(value); remove => _onDamage.RemoveListener(value); }
    public event UnityAction OnDeath { add => _onDeath.AddListener(value); remove => _onDeath.RemoveListener(value); }

    // Methods
    void Awake() => Init();

    void Init()
    {
        CurrentHealth = _startHealth;
        IsShielded = _shielded;
        OnSpawn?.Invoke();
    }

    public void TakeDamage(int amount)
    {
        if (amount < 0) throw new ArgumentException($"Argument amount {nameof(amount)} is negativ");

        if (!IsShielded)
        {
            var tmp = CurrentHealth;
            CurrentHealth = Mathf.Max(0, CurrentHealth - amount);
            var delta = CurrentHealth - tmp;
            _onDamage?.Invoke(delta);

            ChangeState();
        }
        

    }

    [Button("test")]
    void MaFonction()
    {
        var enumerator = MesIntPrefere();

        while(enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }
    }


    List<IEnumerator> _coroutines;

    IEnumerator<int> MesIntPrefere()
    {

        //

        var age = 12;

        yield return 12;


        //

        yield return 3712;

        age++;
        //

        yield return 0;



        //
        yield break;
    }

    public void ReloadThisScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void UpdateHealthBar()
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        Slider healthBar = canvas.gameObject.GetComponentInChildren<Slider>();
        healthBar.value = (float)CurrentHealth / MaxHealth;
    }

    public void Heal(int amount)
    {
        CurrentHealth += amount;

        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }

        UpdateHealthBar();

    }

    public void Shield()
    {
        IsShielded = !IsShielded; 
        _shield.SetActive(IsShielded);
    }

    public void ChangeState()
    {
        if (CurrentHealth <= 0)
        {
            _onDeath?.Invoke();
        }
    }

    public void ScreenShake()
    {
        _controlShakeRef.Instance.LaunchScreenShake();
    }
}
