using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapUIManager : MonoBehaviour
{

    [SerializeField]
    private Button[] levelBtn;  //关卡按钮列表

    [SerializeField]
    private GameObject[] imgObg;
    public static int[] maxLevelList= { 0,0,0,0,0,0,0,0,0,0,0,0};   //不同课题最大关卡数组
    public static int curMaxLevel;
    public static int levelNum;  //当前关卡数

    public static int levelCount=1;
    void Start()
    {
        curMaxLevel = maxLevelList[MainOptionManager.curCourseNum];
        for(int i = 0; i < 10; i++)
        {
          levelBtn[i].interactable = false;
        }

        for (int i = 0; i <= curMaxLevel; i++)
        {
            levelBtn[i].interactable = true;
        }

        for (int i = 1; i < imgObg.Length; i++)
        {
             imgObg[i].SetActive(false);
        }
    }


    //最大关卡数
   public  void OpenLevel()
    {
        for(int i = 0; i <= curMaxLevel; i++)
        {
            levelBtn[i].interactable = true;
        }
    }

    //不同关卡处理
    public void LevelShow(int num)
    {
        SceneManager.LoadScene("Level" + num);
        levelNum = num;
    }
    void Update()
    {
        //是否开启下一关
        if (Answer.isNextLevel)
        {
            OpenLevel();
            Answer.isNextLevel = false;
        }

        for(int i = 0; i <= curMaxLevel; i++)
        {
            imgObg[i].SetActive(true);
        }
    }

    
}
