using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour
{
    public Slider mySlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnSliderValueChange(float value)
    {
        Debug.Log("Slider Value: " + value);
    }

}
