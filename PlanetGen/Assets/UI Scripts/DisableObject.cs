using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject attachedObject;
    public void Disable()
    {
        attachedObject.SetActive(false);
    }
}
