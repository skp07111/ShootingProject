using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.down; // ����
        transform.position += dir * speed * Time.deltaTime; // �̵�
    }
}
