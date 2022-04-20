using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private static int _totalMoney = 15000;
    private static int _totalVehicleCanPurchase = 1;
    private static int _totalVehicle = 1;

    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("Game Manager is Null !");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void TotalMoney(int money)
    {
        _totalMoney = money;
    }

    public void AddTotalMoney(int money)
    {
        _totalMoney += money;
    }
    public void WithdrawTotalMoney(int money)
    {
        _totalMoney -= money;
    }

    public int MyTotalMoney()
    {
        return _totalMoney;
    }

    public void AddVehicleCanPurchase()
    {
        _totalVehicleCanPurchase += 1;
    }

    public int TotalVehicleCanPurchase()
    {
        return _totalVehicleCanPurchase;
    }

    public void SetTotalVehicle(int number)
    {
        _totalVehicle = number;
    }

    public int TotalVehicle()
    {
        return _totalVehicle;
    }
}
