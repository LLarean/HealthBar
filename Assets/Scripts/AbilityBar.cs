using UnityEngine;
using UnityEngine.UI;

public class AbilityBar : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Button _damage;
    [SerializeField] private Button _heal;

    [SerializeField] private int _healPower = 10;
    [SerializeField] private int _damagePower = -10;

    private void Start()
    {
        _damage.onClick.AddListener(Damage);
        _heal.onClick.AddListener(Heal);
    }

    private void Heal()
    {
        _healthBar.TakeHeal(_healPower);
    }

    private void Damage()
    {
        _healthBar.TakeDamage(_damagePower);
    }
}
