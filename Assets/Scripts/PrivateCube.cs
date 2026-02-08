using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.GraphicsBuffer;

public class PrivateCube : MonoBehaviour
{
    // public float size = 1.0f;
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private TextMeshProUGUI errorMessage;

    private float localSize = 1;


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
        errorMessage.text = "The value you want to change is set to private";
    }

}