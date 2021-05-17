using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdatePath : MonoBehaviour
{
    private void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = SaveSystem.path;
    }
}
