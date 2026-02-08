using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EncapsulationCube : MonoBehaviour
{
    public Slider slider;

    private float _localSize;
    public float localSize // ENCAPSULATION
    {
        get { return _localSize; }
        private set { _localSize = Mathf.Clamp(value, 0, 10);
            sizeText.text = "size value = " + _localSize;}
    }

    public TextMeshProUGUI sizeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.onValueChanged.AddListener(OnSliderChanged);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * _localSize;
    }


    public void OnSliderChanged(float value)
    {
        localSize = value;
    }
}
