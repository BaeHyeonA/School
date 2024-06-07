using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 관련 네임스페이스 추가

public class SituationBox : MonoBehaviour
{
    public GameObject situationBox; // SituationBox 객체
    public GameObject day1; // Day1 객체
    public GameObject day2; // Day2 객체

    public Button btnSituation; // Btn_Situation 버튼
    public Button btnDay1; // Btn_Day1 버튼
    public Button btnDay2; // Btn_Day2 버튼
    public Button btnClose; // Btn_Close 버튼 추가

    // Start is called before the first frame update
    void Start()
    {
        // 초기에는 모두 비활성화
        situationBox.SetActive(false);
        day1.SetActive(false);
        day2.SetActive(false);

        // 버튼 클릭 이벤트 등록
        btnSituation.onClick.AddListener(ActivateSituationBox);
        btnDay1.onClick.AddListener(ActivateDay1);
        btnDay2.onClick.AddListener(ActivateDay2);
        btnClose.onClick.AddListener(DeactivateSituationBox); // Btn_Close 클릭 이벤트 등록
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
