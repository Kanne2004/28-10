using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour
{
    public Slider mySlider;
    float health = 70;

    // Start is called before the first frame update
    void Start()
    {
        mySlider.value = health;
    }

    public void OnSliderValueChange(float value)
    {
        Debug.Log("Slider Value: " + value);
    }
}
