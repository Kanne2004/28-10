using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewExample : MonoBehaviour
{
    public ScrollRect myScrollRect;

    // Start is called before the first frame update
    void Start()
    {
        myScrollRect.verticalNormalizedPosition = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
