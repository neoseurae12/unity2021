using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))        // 마우스 왼쪽 버튼 클릭하면
        {
            this.speed = 0.2f;                  // 처음 속도
        }

        transform.Translate(this.speed, 0, 0);  // 이동
        this.speed *= 0.98f;                    // 감속
    }
}
