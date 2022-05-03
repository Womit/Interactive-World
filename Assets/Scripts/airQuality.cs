using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class airQuality : MonoBehaviour
{
    private float dist;
    private float value;
    private float minValue;
    private float maxValue;
    private Slider slider;
    public GameObject mainSlider;

    public float fogStrength;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
       slider = mainSlider.GetComponent<Slider>();

       RenderSettings.fog = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject Cube = GameObject.FindGameObjectWithTag("Pollution");

        float dist = Vector3.Distance(player.transform.position, Cube.transform.position);
        Debug.Log("Distance to other: " + dist);

        slider.value = dist;
        
        //RenderSettings.fogDensity = 0.02f;

        float fogStrength = Vector3.Distance(player.transform.position, Cube.transform.position);
        if (dist < 70f )
        {
            RenderSettings.fogDensity = 0.02f;
        } else if (dist > 70f)
        {
            RenderSettings.fogDensity = 0f;
        }

        if (dist < 20f)
        {
            RenderSettings.fogDensity = 0.1f;
        }
    }
}
