using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int sticker;
    public TMP_Text tmp;

    void Update()
    {
        UpdateStickerText();
    }

    void UpdateStickerText()
    {
        if (tmp != null)
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
