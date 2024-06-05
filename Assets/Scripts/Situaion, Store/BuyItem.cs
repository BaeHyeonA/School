using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro 라이브러리 추가

public class BuyItem : MonoBehaviour
{
    // TextMeshPro 오브젝트 참조
    public TextMeshProUGUI totalPointText;

    // 포인트 변수
    public int totalPoint;

    // 버튼 오브젝트 참조
    public Button btnHat;
    public Button btnRibbon;
    public Button btnPlant;
    public Button btnFish;

    // Warning 오브젝트 참조
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
            // Warning 메시지 표시
            StartCoroutine(ShowWarningMessage());
        }
    }

    IEnumerator ShowWarningMessage()
    {
        warningObject.SetActive(true); // Warning 오브젝트 활성화
        yield return new WaitForSeconds(2.0f); // 2초 대기
        warningObject.SetActive(false); // Warning 오브젝트 비활성화
    }

    void UpdateText()
    {
        totalPointText.text = totalPoint.ToString();
    }
}
