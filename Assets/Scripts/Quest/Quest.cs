[System.Serializable]
public class Quest
{
    public int id;
    public string first;
    public string first_Detail;
    public string second;
    public string second_Detail;
    public string third;
    public string third_Detail;
}

[System.Serializable]
public class QuestList
{
    public Quest[] questList;
}