using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private int _animationFrameCount = 30;
    private Coroutine _coroutine;

    public void Init(float emptyHealth, float fullHealth)
    {
        _slider.minValue = emptyHealth;
        _slider.maxValue = fullHealth;
        _slider.value = fullHealth;
    }

    public void StartChangeValue(float currentValue)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
        
        _coroutine = StartCoroutine(ChangeValue(currentValue));
    }
    
    private IEnumerator ChangeValue(float currentValue)
    {
        float value = _slider.value;
        
        float animationPath = currentValue - _slider.value;
        float animationStep = animationPath / _animationFrameCount;
        
        WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
        
        for (int i = 0; i < _animationFrameCount; i++)
        {
            value += animationStep;
            _slider.value = value;
            yield return waitForEndOfFrame;
        }
        
        _slider.value = currentValue;
        _coroutine = null;
    }
}