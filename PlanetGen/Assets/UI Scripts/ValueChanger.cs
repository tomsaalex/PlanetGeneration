using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;

public class ValueChanger : MonoBehaviour
{
    public TMP_InputField inputField;

    public void ChangeValue(float valueModifier)
    {
        string text = inputField.text;
        float value = float.Parse(inputField.text, CultureInfo.InvariantCulture);
        value += valueModifier;
     
        inputField.text = value.ToString();
    }
}
