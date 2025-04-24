using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour
{
    
    string[][] ArrayX;
    string[] lineArray;
    public List<Toggle> toggleList;
    public Text indexText;

    private int topicIndex = 0;

    private int tmIndex = 1;

    public Text TM_Text;

    public Text[] DA_TextList;  

    public Text Atext;  

    public Text wrongPanel;

    public static bool isNextLevel = false;
    public static bool isNextKeTi = false;

    public GameControl gameControl;

    public AudioClip errorAudio;
    GameObject camera;

    public static int enemyCount = 5;
    private void Awake()
    {
        OptionTM();
        TxtCsv();
        LoadAnswer();
        tmIndex = 1;
    }
    void Start()
    {
        toggleList[0].onValueChanged.AddListener((isOn) => AnswerRightWrong(isOn, 0));
        toggleList[1].onValueChanged.AddListener((isOn) => AnswerRightWrong(isOn, 1));
        toggleList[2].onValueChanged.AddListener((isOn) => AnswerRightWrong(isOn, 2));
        toggleList[3].onValueChanged.AddListener((isOn) => AnswerRightWrong(isOn, 3));
        camera = GameObject.Find("Main Camera");
        enemyCount = 5;
    }

    

    public void TxtCsv()
    {
        TextAsset textAsset = Resources.Load("TM"+MainOptionManager.curCourseNum, typeof(TextAsset)) as TextAsset;

        lineArray = textAsset.text.Split('\r');

        ArrayX = new string[lineArray.Length][];
        for(int i = 0; i < lineArray.Length; i++)
        {
            ArrayX[i] = lineArray[i].Split(':');
        }
    }

    public void LoadAnswer()
    {
        for (int i = 0; i < toggleList.Count; i++)
        {
            toggleList[i].isOn = false;
        }
        for (int i = 0; i < toggleList.Count; i++)
        {
            toggleList[i].interactable = true;
        }

       
        TM_Text.text = ArrayX[topicIndex][1];

        int idx = ArrayX[topicIndex].Length - 3;//�м���ѡ��
        for (int x = 0; x < idx; x++)
        {
            DA_TextList[x].text = ArrayX[topicIndex][x + 2];//ѡ��
        }
    }


    public void AnswerRightWrong(bool check,int index)
    {
        if (check)
        {
           
            int idx = ArrayX[topicIndex].Length - 1;
            int n = int.Parse(ArrayX[topicIndex][idx]) - 1;
            int daan = int.Parse(ArrayX[topicIndex][idx]) + 1;

            if (n == index)
            {
               GameControl. isRight = true;
                Atext.text = ArrayX[topicIndex][daan];
                wrongPanel.text = "Correct !";

                
                for (int i = 0; i < toggleList.Count; i++)
                {
                    if (i == n)
                    {
                        continue;
                    }
                    toggleList[i].interactable = false;
                }
            }
            else
            {
                AudioSource.PlayClipAtPoint(errorAudio, camera.transform.position);
                GameControl. isRight = false;
                wrongPanel.text = "Incorrect !";
                Invoke("TiShi", 1f);
            }
        } 
    }

   
    public void TiShi()
    {
        wrongPanel.text = "";
    }


    public void NextTM()
    {
        if (tmIndex < 5)
        {
            topicIndex++;
            tmIndex++;
          
            LoadAnswer();
            Atext.text = "";
            wrongPanel.text = "";
        }
        else
        {
           

            isNextLevel = true;
            if (MapUIManager.maxLevelList[MainOptionManager.curCourseNum] < 9)
            {
                MapUIManager.maxLevelList[MainOptionManager.curCourseNum]++;
                MapUIManager.levelCount++;
            }
            else
            {
                isNextKeTi = true;
                if (MainOptionManager.curCourseNum < 11)
                {
                    MainOptionManager.maxCourse++;
                    MapUIManager.maxLevelList[MainOptionManager.curCourseNum] = 0;
                    MapUIManager.levelCount = 0;
                }
            }
            gameControl.SendMessage("GameWin");
           
        }
    }

    public void OptionTM()
    {
        switch (MapUIManager.levelNum)
        {
            case 0:
                 topicIndex = 0;
                 break;
            case 1:
                topicIndex = 5;
                break;
            case 2:
                topicIndex = 10;
                break;
            case 3:
                topicIndex = 15;
                break;
            case 4:
                topicIndex = 20;
                break;
            case 5:
                topicIndex = 25;
                break;
            case 6:
                topicIndex = 30;
                break;
            case 7:
                topicIndex = 35;
                break;
            case 8:
                topicIndex = 44;
                break;
            case 9:
                topicIndex = 45;
                break;
        }

    }
    
    void Update()
    {

        indexText.text = enemyCount.ToString();

    }
}
