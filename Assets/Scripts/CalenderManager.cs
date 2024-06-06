using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalenderManager : MonoBehaviour
{
    private int questNum;
    private QuestList questData;

    public GameObject day;
    public List<GameObject> faces;
    public List<TMP_Text> texts;
    public TMP_Text firstQuest;
    public TMP_Text firstDetail;
    public TMP_Text secondQuest;
    public TMP_Text secondDetail;
    public TMP_Text thirdQuest;
    public TMP_Text thirdDetail;
  
    void Start()
    {
        foreach(GameObject face in faces)
            face.GetComponent<RectTransform>().anchoredPosition = day.GetComponent<RectTransform>().anchoredPosition;
        faces[questNum].SetActive(true);
        LoadQuestData();
        OnQuestButtonClick(int.Parse(day.name));
    }  

    void LoadQuestData()
    {
        TextAsset jsonData = Resources.Load<TextAsset>("QuestFile");
        questData = JsonUtility.FromJson<QuestList>(jsonData.text);
    }   

    void OnQuestButtonClick(int id)
    {
        Quest quest = FindQuestById(id);
        if (quest != null)
        {
            firstQuest.text = quest.first;
            firstDetail.text = quest.first_Detail;
            secondQuest.text = quest.second;
            secondDetail.text = quest.second_Detail;
            thirdQuest.text = quest.third;
            thirdDetail.text = quest.third_Detail;
        }
    }
    Quest FindQuestById(int id)
    {
        foreach (Quest quest in questData.questList)
        {
            if (quest.id == id)
                return quest;
        }
        return null;
    }

    public void SuccessQuest()
    {
        faces[questNum].SetActive(false);
        questNum++;
        faces[questNum].SetActive(true);
    }

    public void CheckQuest(int num)
    {
        texts[num-1].text = "O";
    }
}