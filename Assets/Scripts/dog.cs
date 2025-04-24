using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour
{
    float timeValue=0;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.right * 120 * Time.deltaTime);
        if (transform.localPosition.x >= 950)
        {
            timeValue += Time.deltaTime;
            if (timeValue >= 3)
            {
                transform.localPosition = new Vector3(-1000, -480, 0);
                timeValue = 0;
            }
        }
    }
}
