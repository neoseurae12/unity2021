using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정함
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 회전 속도만큼 룰렛을 회전시킴
        transform.Rotate(0, 0, this.rotSpeed);

        // 룰렛을 감속시킴 (추가)
        this.rotSpeed *= 0.98f;
    }
}
