using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VehicleClass;

public class VehiclePage : MonoBehaviour
{
    Vehicle[] vehicles;
    public GameObject contentScrollView;
    Transform[] content;
    void Start()
    {
        content = GetComponentsInChildren<Transform>();
        for(int i = 0; i < GameManager.Instance.TotalVehicle(); i++)
        {
            vehicles[i] = new Vehicle();
            Debug.Log(content[i]);
        }

    }

    public void VehicleButton()
    {
        Debug.Log("Hello world", contentScrollView);
    }
}
