using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{

    public GameObject upgradeUi;
    public void UpgradeMenuOpener()
    {
        if(upgradeUi.activeSelf == false)
        {
            upgradeUi.SetActive(true);
        }
        else if (upgradeUi == true)
        {
            upgradeUi.SetActive(false);
        }
    }
}
