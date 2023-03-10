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
        // 스와이프의 길이 구하기 (추가)
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 '클릭' 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 '뗀' 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // 스와이프 길이 => 처음 속도 변경
            this.speed = swipeLength / 700.0f;

            // 효과음 재생
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);  // 이동
        this.speed *= 0.98f;                    // 감속
    }
}
