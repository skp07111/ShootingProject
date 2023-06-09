using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.up; // ����
        transform.position += dir * speed * Time.deltaTime; // �̵�
        if (transform.position.y < -6.0f || transform.position.y > 6.0f || transform.position.x < -4.0f || transform.position.x > 4.0f)
        {
            Destroy(gameObject); // ȭ�� ������ ������ �� ������Ʈ ����
        }
    }
}
