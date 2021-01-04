using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnableObject : MonoBehaviour
{
    public GameObject attachedObject;
    public void Enable()
    {
        attachedObject.SetActive(true);
    }
}
