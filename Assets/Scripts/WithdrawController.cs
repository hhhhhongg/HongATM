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
        atm = ATMManager.instance;
        withdrawInputField.characterValidation = TMP_InputField.CharacterValidation.Integer;
    }

    public void OnWithdrawButtonClick()
    {
        if (int.TryParse(withdrawInputField.text, out int withdrawAmount))
        {
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
        }
        else
        {
            Debug.Log("입금액을 올바르게 입력하세요.");
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
