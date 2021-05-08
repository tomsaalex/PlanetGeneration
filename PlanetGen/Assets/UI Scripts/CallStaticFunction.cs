using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallStaticFunction : MonoBehaviour
{
    public void CallGetPath(string path)
    {
        SaveSystem.GetPath(path);
    }
}
