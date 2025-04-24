using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    private bool isDragging = false;  // 是否正在拖動
    private Vector3 offset;          // 滑鼠與物件之間的偏移量
    private Camera mainCamera;       // 主攝影機引用

    void Start()
    {
        // 獲取主攝影機
        mainCamera = Camera.main;
    }

    void Update()
    {
        // 檢查滑鼠左鍵是否按下並點擊該物件
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // 判斷射線是否擊中當前物件
            if (Physics.Raycast(ray, out hit) && hit.transform == transform)
            {
                isDragging = true;

                // 計算滑鼠點擊位置與物件位置的偏移量
                offset = transform.position - GetMouseWorldPosition();
            }
        }

        // 當滑鼠左鍵放開時停止拖動
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        // 如果正在拖動，更新物件位置
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    // 將滑鼠螢幕座標轉換為世界座標
    Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.WorldToScreenPoint(transform.position).z; // 保持物件的深度
        return mainCamera.ScreenToWorldPoint(mousePosition);
    }
}