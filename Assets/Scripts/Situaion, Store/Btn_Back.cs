using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro 라이브러리 추가

public class Btn_Back : MonoBehaviour
{
    // GameManager에 대한 참조
    public GameManager gameManager;
    public Button Btn_Day1Back;
    public Button Btn_Day2Back;
    public GameObject Day1;
    public GameObject Day2;
    public GameObject Day2_Unlock;

    // TextMeshPro 오브젝트 참조
    public TextMeshProUGUI totalPointText;


    // Start is called before the first frame update
    void Start()
    {
        // GameManager 인스턴스에 대한 참조 가져오기
        gameManager = GameManager.Instance;

        // Day1Back 버튼에 리스너 추가
        Btn_Day1Back.onClick.AddListener(OnDay1BackClicked);
        // Day2Back 버튼에 리스너 추가
        Btn_Day2Back.onClick.AddListener(OnDay2BackClicked);
    }

    void OnDay1BackClicked()
    {
        // Day1 오브젝트를 비활성화
        Day1.SetActive(false);
        // Day2_Unlock 오브젝트를 활성화
        Day2_Unlock.SetActive(true);

        // GameManager의 sticker를 증가시키고 업데이트된 값을 텍스트로 표시
        gameManager.stickerUp();
        UpdateTotalPointText(gameManager.sticker);
    }

    void OnDay2BackClicked()
    {
        // Day2 오브젝트를 비활성화
        Day2.SetActive(false);

        // GameManager의 sticker를 증가시키고 업데이트된 값을 텍스트로 표시
        gameManager.stickerUp();
        UpdateTotalPointText(gameManager.sticker);
    }

    // totalPointText 업데이트 메서드
    void UpdateTotalPointText(int totalPoint)
    {
        totalPointText.text = totalPoint.ToString();
    }
}
