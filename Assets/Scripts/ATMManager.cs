using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    public static ATMManager instance;

    [SerializeField] private GameObject mainUI;
    [SerializeField] private GameObject depositUI;
    [SerializeField] private GameObject withdrawUI;
    [SerializeField] private GameObject InsufficientCashUI;
    [SerializeField] private GameObject InsufficientBalanceUI;

    [SerializeField] private TextMeshProUGUI cashText;
    [SerializeField] private TextMeshProUGUI balanceText;

    public int balance = 50000; // �ʱ� �ܾװ�
    public int cash = 100000; // �ʱ� ���ݰ�

    private void Awake()
    {
        instance = this;
        cashText.text = string.Format("{0:N0}", cash);
        balanceText.text = string.Format("{0:N0}", balance);
        BackToMainUI();
    }

    public void UpdateBalanceAndCashText(int balance, int cash)
    {
        balanceText.text = string.Format("{0:N0}", balance);
        cashText.text = string.Format("{0:N0}", cash);
    }
    
    public void GoDepositUI()
    {
        depositUI.SetActive(true);
        mainUI.SetActive(false);
        withdrawUI.SetActive(false);
    }

    public void GoWithdrawUI()
    {
        withdrawUI.SetActive(true);
        mainUI.SetActive(false);
        depositUI.SetActive(false);
    }

    public void BackToMainUI()
    {
        mainUI.SetActive(true);
        withdrawUI.SetActive(false);
        depositUI.SetActive(false);
    }

    // �ܾ� ����, ���� ���� UI ����
    public void ShowInsufficientCashUI()
    {
        InsufficientCashUI.SetActive(true);
        Invoke("HideInsufficientCashUI", 1f); // 1�ʵڿ� UI�� ��������� ����
    }

    public void ShowInsufficientBalanceUI()
    {
        InsufficientBalanceUI.SetActive(true);
        Invoke("HideInsufficientBalanceUI", 1f); // 1�ʵڿ� UI�� ��������� ����
    }

    public void HideInsufficientBalanceUI()
    {
        InsufficientBalanceUI.SetActive(false);
    }

    public void HideInsufficientCashUI()
    {
        InsufficientCashUI.SetActive(false);
    }


}
