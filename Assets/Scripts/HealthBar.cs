using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class   HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float fillSpeed = 0.5f;
    
    private int _currentValue;

    public void TakeDamage(int damage)
    {
        _currentValue = (int)Mathf.Clamp(_currentValue - damage, _slider.minValue, _slider.maxValue);
        StartCoroutine(ChangeValue());
    }
     
    public void TakeHeal(int heal)
    {
        _currentValue = (int)Mathf.Clamp(_currentValue + heal, _slider.minValue, _slider.maxValue);
        StartCoroutine(ChangeValue());
    }

    private void Start()
    {
        _currentValue = (int)_slider.value;
    }

    private IEnumerator ChangeValue()
    {
        // float newValue = Mathf.Clamp(_currentValue + amount, _slider.minValue, _slider.maxValue);
        
        // float newHealth = Mathf.Max(0, _health - value);
        
        // while (_currentValue != newHealth)
        // {
        //     _currentValue -= fillSpeed * Time.deltaTime;
        //     _slider.value = _currentValue;
        yield return null;
        // }
        //
        // _currentValue = newHealth;
    }
}