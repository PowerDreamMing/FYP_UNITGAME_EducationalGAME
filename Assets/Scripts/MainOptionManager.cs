using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainOptionManager : MonoBehaviour
{
    [SerializeField]
    private Button[] courseBtn;

    public static int maxCourse = 0;

    public static int curCourseNum = 0;//当前课题序号
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            courseBtn[i].interactable = true;
        }
        for (int i = 0; i <= maxCourse; i++)
        {
            courseBtn[i].interactable = true;
        }
    }

    public void OpenCourse()
    {
        for (int i = 0; i <= maxCourse; i++)
        {
            courseBtn[i].interactable = true;
        }
    }

    //不同课题的处理

    public void CourseShow(int num)
    {
        if (num >= 0 && num < courseBtn.Length)
        {
            SceneManager.LoadScene("MapScene");
            curCourseNum = num;
        }
    }

    void Update()
    {
        if (Answer.isNextKeTi)
        {
            MapUIManager.levelCount = 0;
            OpenCourse();
            Answer.isNextKeTi = false;
        }
    }
}