using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DepositController : MonoBehaviour
{
    [SerializeField] private TMP_InputField depositInputField;
    private ATMManager atm;

    private void Start()
    {
        atm = ATMManager.instance;
        depositInputField.characterValidation = TMP_InputField.CharacterValidation.Integer;
    }

    public void OnDepositButtonClick()
    {
        if (int.TryParse(depositInputField.text, out int depositAmount))
        {
            if (depositAmount <= atm.cash)
            {
                atm.cash -= depositAmount;
                atm.balance += depositAmount;
                atm.UpdateBalanceAndCashText(atm.balance, atm.cash);
            }
            else
            {
                atm.ShowInsufficientCashUI();
            }
        }
        else
        {
            Debug.Log("입금액을 올바르게 입력하세요.");
        }
            
        depositInputField.text = "";
    }

    public void TenThousandDepositBtnClick()
    {
        if (atm.cash >= 10000)
        {
            atm.balance += 10000;
            atm.cash -= 10000;
            atm.UpdateBalanceAndCashText(atm.balance, atm.cash);
        }
        else
        {
            atm.ShowInsufficientCashUI();
        }
    }

    public void ThirtyThousandDepositBtnClick()
    {
        if (atm.cash >= 30000)
        {
            atm.balance += 30000;
            atm.cash -= 30000;
            atm.UpdateBalanceAndCashText(atm.balance, atm.cash);
        }
        else
        {
            atm.ShowInsufficientCashUI();
        }
    }

    public void FiftyThousandDepositBtnClick()
    {
        if (atm.cash >= 50000)
        {
            atm.balance += 50000;
            atm.cash -= 50000;
            atm.UpdateBalanceAndCashText(atm.balance, atm.cash);
        }
        else
        {
            atm.ShowInsufficientCashUI();
        }
    }
}
