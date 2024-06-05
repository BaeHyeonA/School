using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro ���̺귯�� �߰�

public class BuyItem : MonoBehaviour
{
    // TextMeshPro ������Ʈ ����
    public TextMeshProUGUI totalPointText;

    // ����Ʈ ����
    public int totalPoint;

    // ��ư ������Ʈ ����
    public Button btnHat;
    public Button btnRibbon;
    public Button btnPlant;
    public Button btnFish;

    // Warning ������Ʈ ����
    public GameObject warningObject;

    void Start()
    {
        warningObject.SetActive(false);
        UpdateText();

        btnHat.onClick.AddListener(Buy);
        btnRibbon.onClick.AddListener(Buy);
        btnPlant.onClick.AddListener(Buy);
        btnFish.onClick.AddListener(Buy);
    }

    void Buy()
    {
        if (totalPoint >= 5)
        {
            totalPoint -= 5;
            UpdateText();
        }
        else
        {
            // Warning �޽��� ǥ��
            StartCoroutine(ShowWarningMessage());
        }
    }

    IEnumerator ShowWarningMessage()
    {
        warningObject.SetActive(true); // Warning ������Ʈ Ȱ��ȭ
        yield return new WaitForSeconds(2.0f); // 2�� ���
        warningObject.SetActive(false); // Warning ������Ʈ ��Ȱ��ȭ
    }

    void UpdateText()
    {
        totalPointText.text = totalPoint.ToString();
    }
}
