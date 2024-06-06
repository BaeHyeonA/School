using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public List<GameObject> text;
    
    public void Change(int index)
    {
        text[index].SetActive(false);
        text[index + 1].SetActive(true);
    }
}
