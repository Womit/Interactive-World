using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airQuality : MonoBehaviour
{
    private float dist;
    private float value;
    private float minValue;
    private float maxValue;

    public void submitSliderSetting() {
        Debug.Log(mainSlider.value);
    }
    public airQuality mainSlider;
    // Start is called before the first frame update
    void Start()
    {
        mainSlider.minValue = 1;
        mainSlider.maxValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
