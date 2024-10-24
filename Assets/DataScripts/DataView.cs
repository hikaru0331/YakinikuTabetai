using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestView : MonoBehaviour
{
    [SerializeField] Data data;

    int a, b;
    string str;
    void Start()
    {
        a = data.num_a;
        b = data.num_b;
        str = data.str_a;

        Debug.Log(a + " " + b + " " + str);
    }
}
