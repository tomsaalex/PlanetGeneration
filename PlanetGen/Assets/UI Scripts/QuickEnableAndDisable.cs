using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickEnableAndDisable : MonoBehaviour
{
    GameObject GameManager;
    UpdateUIFromJSON niceComponent;
    private void OnEnable()
    {
        GameManager = GameObject.FindWithTag("GameManager");
        niceComponent = GameManager.GetComponent<UpdateUIFromJSON>();
        niceComponent.FindChildWithTag(this.gameObject.transform, "GeneralSettings").gameObject.SetActive(true);
        niceComponent.FindChildWithTag(this.gameObject.transform, "ShapeSettings").gameObject.SetActive(true);

        niceComponent.UpdateUI();
        niceComponent.FindChildWithTag(this.gameObject.transform, "GeneralSettings").Find("GeneratePlanet").gameObject.GetComponent<GeneratePlanet>().Generate();

        niceComponent.FindChildWithTag(this.gameObject.transform, "GeneralSettings").gameObject.SetActive(false);
        niceComponent.FindChildWithTag(this.gameObject.transform, "ShapeSettings").gameObject.SetActive(false);
    }
}
