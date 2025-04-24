using UnityEngine;
using UnityEngine.UI; // 如果使用 UI Image，請加入這行

public class ImageAnimationController : MonoBehaviour
{
    // Animator 控制器變量
    public Animator animator;

    // 用於檢查滑鼠是否在圖片上
    private bool isMouseOver = false;

    void Start()
    {
        // 確保 Animator 被正確分配
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void Update()
    {
        // 如果滑鼠不在圖片上，啟動動畫
        if (!isMouseOver)
        {
            animator.SetBool("isAnimating", true); // 設置動畫參數
        }
        else
        {
            animator.SetBool("isAnimating", false); // 停止動畫
        }
    }

    // 滑鼠進入圖片時觸發
    void OnMouseEnter()
    {
        isMouseOver = true;
    }

    // 滑鼠離開圖片時觸發
    void OnMouseExit()
    {
        isMouseOver = false;
    }
}