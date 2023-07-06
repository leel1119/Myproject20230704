using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    float lv = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = transform.position;
        lv+= Input.GetAxis("Horizontal");
        v.x = lv; 



    }
}
