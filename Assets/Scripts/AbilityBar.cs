using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AbilityBar : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Button _damage;
    [SerializeField] private Button _heal;

    private void Start()
    {
        _damage.onClick.AddListener(Damage);
        _heal.onClick.AddListener(Heal);
    }

    private void Heal()
    {
        _healthBar.TakeHeal(10);
    }

    private void Damage()
    {
        
        _healthBar.TakeDamage(10);
        
    }
    

}
