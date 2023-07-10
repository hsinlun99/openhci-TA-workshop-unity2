using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 50; //��l��t

    // Update is called once per frame
    void Update() // �C�@�V
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed); //�Hy�b���� ���@��եΤ@��
    }

    public void ChangeSpeed(float NewSpeed)
    {
        this.speed = NewSpeed;
    }
}
