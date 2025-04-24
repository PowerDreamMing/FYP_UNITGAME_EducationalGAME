using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour
{
    float timeValue=0;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.right * 80 * Time.deltaTime);
        if (transform.localPosition.x >= 1000)
        {
            timeValue += Time.deltaTime;
            if (timeValue >= 3)
            {
                transform.localPosition = new Vector3(-1000, -400, 0);
                timeValue = 0;
            }
        }
    }
}
