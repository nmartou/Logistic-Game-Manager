using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VehicleClass;

public class VehiclePage : MonoBehaviour
{
    Vehicle[] vehicles;
    public GameObject contentScrollView;
    Transform[] content;

    public GameObject mainVue;
    public GameObject vehicleVue;
    public GameObject specificVehicleVue;

    public Text money;

    void Start()
    {
        specificVehicleVue.SetActive(false);
        /*content = GetComponentsInChildren<Transform>();
        for(int i = 0; i < GameManager.Instance.TotalVehicle(); i++)
        {
            vehicles[i] = new Vehicle();
            Debug.Log(content[i]);
        }*/

    }

    private void Update()
    {
        money.text = "$" + GameManager.Instance.MyTotalMoney().ToString();
    }

    public void OnClickExit()
    {
        mainVue.SetActive(true);
        vehicleVue.SetActive(false);
    }

    public void OnClickExitSecondPanelVehicle()
    {
        specificVehicleVue.SetActive(false);
    }
}
