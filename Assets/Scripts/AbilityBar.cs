using UnityEngine;
using UnityEngine.UI;

public class AbilityBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Button _damage;
    [SerializeField] private Button _heal;

    private void Start()
    {
        _damage.onClick.AddListener(Damage);
        _heal.onClick.AddListener(Heal);
    }

    private void Damage()
    {
        _player.TakeDamage();
    }

    private void Heal()
    {
        _player.TakeHeal();
    }
}