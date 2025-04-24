using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBg : MonoBehaviour
{
    [SerializeField]
    private Sprite[] gameBg;

    private Image bg;


    void Start()
    {
        bg = GetComponent<Image>();
        GameBGRandom();
    }
    public void GameBGRandom()
    {
        int num = Random.Range(0, 3);

        bg.sprite = gameBg[num];
    }
}
