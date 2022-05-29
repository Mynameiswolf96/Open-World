using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float _angle;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,_angle,0);
    }
}
