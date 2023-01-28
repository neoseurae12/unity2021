using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI를 사용하는 데 필요함

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        // 씬 안의 해당 오브젝트 찾아 넣기
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m"; // 소수점 둘째 자리까지 표시
        } else
        {
            this.distance.GetComponent<Text>().text = "게임 오버!";
        }
    }
}
