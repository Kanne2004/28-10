using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider mySlider;
    public float initialValue = 50;
    void Start()
    {
        mySlider.value = initialValue;
    }

    public void OnSliderValueChanged(float newValue)
    {
        Debug.Log("Giá trị mới của slider: " + newValue);
    }
}
