using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private AbilityBar _abilityBar;
    
    private float _emptyHealth = 0;
    private float _fullHealth = 100;
    private int _damagePower = 10;
    private int _healPower = 10;
    private float _currentHealth;

    public void TakeDamage() => ChangeHealth(-_damagePower);

    public void TakeHeal() => ChangeHealth(_healPower);

    private void Start()
    {
        _healthBar.Init(_emptyHealth, _fullHealth);
        _currentHealth = _fullHealth;
    }

    private void ChangeHealth(float amount)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + amount, _emptyHealth, _fullHealth);
        _healthBar.StartChangeValue(_currentHealth);
    }
}