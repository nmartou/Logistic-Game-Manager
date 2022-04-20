using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Text Money;
    public GameObject MyVehiclesCanva;
    public GameObject MainCanva;
    public GameObject ContractsCanva;
    // Start is called before the first frame update
    void Start()
    {
        Money.text = "$" + GameManager.Instance.MyTotalMoney().ToString();
        MyVehiclesCanva.SetActive(false);
        MainCanva.SetActive(true);
        ContractsCanva.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyVehiclesButton()
    {
        MyVehiclesCanva.SetActive(true);
        MainCanva.SetActive(false);
        ContractsCanva.SetActive(false);
    }

    public void ContractsButton()
    {
        MainCanva.SetActive(false);
        ContractsCanva.SetActive(true);
        MyVehiclesCanva.SetActive(false);
    }
}
