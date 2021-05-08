using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickEnableAndDisable : MonoBehaviour
{
    private void OnEnable()
    {
        GameObject.FindWithTag("GameManager").GetComponent<UpdateUIFromJSON>().FindChildWithTag(this.gameObject.transform, "GeneralSettings").gameObject.SetActive(true);
        GameObject.FindWithTag("GameManager").GetComponent<UpdateUIFromJSON>().FindChildWithTag(this.gameObject.transform, "ShapeSettings").gameObject.SetActive(true);

        GameObject.FindWithTag("GameManager").GetComponent<UpdateUIFromJSON>().UpdateUI();

        GameObject.FindWithTag("GameManager").GetComponent<UpdateUIFromJSON>().FindChildWithTag(this.gameObject.transform, "GeneralSettings").gameObject.SetActive(false);
        GameObject.FindWithTag("GameManager").GetComponent<UpdateUIFromJSON>().FindChildWithTag(this.gameObject.transform, "ShapeSettings").gameObject.SetActive(false);
    }
}
