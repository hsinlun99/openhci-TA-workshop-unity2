using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 50; //初始轉速

    // Update is called once per frame
    void Update() // 每一幀
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed); //以y軸旋轉 約一秒調用一次
    }

    public void ChangeSpeed(float NewSpeed)
    {
        this.speed = NewSpeed;
    }
}
