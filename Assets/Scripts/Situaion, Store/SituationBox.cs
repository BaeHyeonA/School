using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���� ���ӽ����̽� �߰�

public class SituationBox : MonoBehaviour
{
    public GameObject situationBox; // SituationBox ��ü
    public GameObject day1; // Day1 ��ü
    public GameObject day2; // Day2 ��ü

    public Button btnSituation; // Btn_Situation ��ư
    public Button btnDay1; // Btn_Day1 ��ư
    public Button btnDay2; // Btn_Day2 ��ư
    public Button btnClose; // Btn_Close ��ư �߰�

    // Start is called before the first frame update
    void Start()
    {
        // �ʱ⿡�� ��� ��Ȱ��ȭ
        situationBox.SetActive(false);
        day1.SetActive(false);
        day2.SetActive(false);

        // ��ư Ŭ�� �̺�Ʈ ���
        btnSituation.onClick.AddListener(ActivateSituationBox);
        btnDay1.onClick.AddListener(ActivateDay1);
        btnDay2.onClick.AddListener(ActivateDay2);
        btnClose.onClick.AddListener(DeactivateSituationBox); // Btn_Close Ŭ�� �̺�Ʈ ���
    }

    void ActivateSituationBox()
    {
        situationBox.SetActive(true);
    }

    void ActivateDay1()
    {
        day1.SetActive(true);
        situationBox.SetActive(false);
    }

    void ActivateDay2()
    {
        day2.SetActive(true);
        situationBox.SetActive(false);
    }

    void DeactivateSituationBox()
    {
        situationBox.SetActive(false);
    }
}
