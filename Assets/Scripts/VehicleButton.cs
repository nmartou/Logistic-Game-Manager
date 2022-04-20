using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleButton : MonoBehaviour
{
    public GameObject lockedVue;
    public GameObject unlockedVue;
    public GameObject specificVehicleVue;
    public bool isLocked = true;

    private void Start()
    {
        if(isLocked)
        {
            lockedVue.SetActive(true);
            unlockedVue.SetActive(false);
        }
        else
        {
            lockedVue.SetActive(false);
            unlockedVue.SetActive(true);
        }
    }

    public void OnClickVehicleButton()
    {
        if (isLocked)
        {
            isLocked = false;
            lockedVue.SetActive(false);
            unlockedVue.SetActive(true);
            GameManager.Instance.WithdrawTotalMoney(15000);
        }
        else
        {
            specificVehicleVue.SetActive(true);
        }
    }
}
