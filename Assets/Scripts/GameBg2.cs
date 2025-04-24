using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBg2 : MonoBehaviour
{
    [SerializeField]
    private Sprite[] gameBg;

    private Image bg;
    private int index = 0; // 新增索引變數

    void Start()
    {
        bg = GetComponent<Image>();
        InvokeRepeating("GameBGRandom", 0f, 1f); // 每秒呼叫一次 GameBGRandom
    }

    public void GameBGRandom()
    {
        // 設置背景圖片
        bg.sprite = gameBg[index];

        // 更新索引以形成 1、2、3 無限循環
        index++;
        if (index >= gameBg.Length) // 當索引達到最後一張圖片時重置為 0
        {
            index = 0;
        }
    }
}
