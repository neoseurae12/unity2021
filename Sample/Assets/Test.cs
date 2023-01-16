using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = { 83, 99, 52, 93, 15 };

        int sum = 0;
        for(int i=0; i<points.Length; i++)
        {
            sum += points[i];
        }

        int avgInt1 = sum / points.Length;
        Debug.Log(avgInt1); // 68

        float avgInt2 = sum / points.Length;
        Debug.Log(avgInt2); // 68

        float avgFloat = 1.0f * sum / points.Length;
        Debug.Log(avgFloat); // 68.4
    }
}
