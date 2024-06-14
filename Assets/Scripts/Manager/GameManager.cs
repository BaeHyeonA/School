using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int sticker;
    public TMP_Text tmp;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        tmp = GameObject.FindWithTag("sticker").GetComponent<TMP_Text>();
    }

    void Update()
    {
        tmp.text = sticker.ToString();
    }

    public void stickerUp()
    {
        sticker++;
    }

    public void stickerDown()
    {
        sticker--;
    }
}
