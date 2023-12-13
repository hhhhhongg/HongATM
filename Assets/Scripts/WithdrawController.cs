using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WithdrawController : MonoBehaviour
{
    [SerializeField] private TMP_InputField withdrawInputField;
    private ATMManager atm;

    private void Start()
    {
        atm = FindObjectOfType<ATMManager>();
    }

    public void OnWithdrawButtonClick()
    {
        int withdrawAmount = int.Parse(withdrawInputField.text);
        if (withdrawAmount <= atm.balance)
        {
            atm.balance -= withdrawAmount;
            atm.cash += withdrawAmount;
            atm.UpdateBalanceAndCashText(atm.balance, atm.cash);
        }
        else
        {
            atm.ShowInsufficientBalanceUI();
        }
        withdrawInputField.text = "";
    }
    public void TenThousandWithdrawBtnClick()
    {
        if (atm.balance >= 10000)
        {
            atm.cash += 10000;
            atm.balance -= 10000;
            atm.UpdateBalanceAndCashText(atm.balance, atm.cash);
        }
        else
        {
            atm.ShowInsufficientBalanceUI();
        }
    }
    public void ThirtyThousandWithdrawBtnClick()
    {
        if (atm.balance >= 30000)
        {
            atm.cash += 30000;
            atm.balance -= 30000;
            atm.UpdateBalanceAndCashText(atm.balance, atm.cash);
        }
        else
        {
            atm.ShowInsufficientBalanceUI();
        }
    }
    public void FiftyThousandWithdrawBtnClick()
    {
        if (atm.balance >= 50000)
        {
            atm.cash += 50000;
            atm.balance -= 50000;
            atm.UpdateBalanceAndCashText(atm.balance,atm.cash);
        }
        else
        {
            atm.ShowInsufficientBalanceUI();
        }
    }
}
