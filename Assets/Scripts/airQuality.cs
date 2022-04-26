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
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
       slider = mainSlider.GetComponent<Slider>();

        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject Cube = GameObject.FindGameObjectWithTag("Pollution");

        float dist = Vector3.Distance(player.transform.position, Cube.transform.position);
        Debug.Log("Distance to other: " + dist);

        slider.value = dist;

    }
}
