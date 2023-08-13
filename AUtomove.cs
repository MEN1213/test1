using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//一定範囲内を往復
public class AUtomove : MonoBehaviour
{
    private float MoveSpeed = 3.0f;
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * MoveSpeed, 0, 0);
    }
}
