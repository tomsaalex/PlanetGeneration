using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateFromSlider : MonoBehaviour
{
    TextMeshProUGUI textToUpdate;
    public Slider sliderToTakeFrom;
    public Planet p;

    void Awake()
    {
        textToUpdate = this.GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

    public void UpdateText()
    {
        Debug.Log(sliderToTakeFrom.value);
        Debug.Log(sliderToTakeFrom.maxValue);
        Debug.Log(textToUpdate.text);
        textToUpdate.text = $"{sliderToTakeFrom.value} / {sliderToTakeFrom.maxValue}";
    }
}
