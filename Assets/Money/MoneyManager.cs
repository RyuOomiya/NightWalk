using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    private static MoneyManager _staticMoneyManager;
    public static MoneyManager StaticMoneyManager => _staticMoneyManager;

    private int _currentHaveMoney;
    public int CurrentHaveMoney { get; set; }

    private void Awake()
    {
        if(_staticMoneyManager != null)
        {
            _staticMoneyManager = this;
        }
    }

    public void Buy(int value)
    {
        _currentHaveMoney -= value;
    }

    public void Sell(int value)
    {
        _currentHaveMoney += value;
    }
}
