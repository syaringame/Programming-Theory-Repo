using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class PublicCube : MonoBehaviour
{
    // public float size = 1.0f;

    public Slider slider;

    public float localSize = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.onValueChanged.AddListener(OnSliderChanged);
    }


    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * localSize;
    }


    public void OnSliderChanged(float value)
    {
        localSize = value;
    }

}