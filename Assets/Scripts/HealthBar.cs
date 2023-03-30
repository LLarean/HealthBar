using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float fillSpeed = 0.5f;
    private float _health;
    
    public void TakeDamage(int damage)
    {
        float newHealth = Mathf.Max(0, _health - damage);
        
        StartCoroutine(ChangeValue(newHealth));
    }

    public void TakeHeal(int heal)
    {
        float newHealth = Mathf.Max(0, _health + heal);
        
        StartCoroutine(ChangeValue(newHealth));
    }

    private void Start()
    {
        _health = _slider.maxValue;
    }

    private IEnumerator ChangeValue(float newHealth)
    {
        // float newHealth = Mathf.Max(0, _health - value);
        
        while (_health > newHealth)
        {
            _health -= fillSpeed * Time.deltaTime;
            _slider.value = _health;
            yield return null;
        }
        
        _health = newHealth;
    }
}