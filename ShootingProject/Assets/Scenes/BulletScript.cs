using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.left; // ����
        transform.position += dir * speed * Time.deltaTime; // �̵�
        if (transform.position.y < -5.0f || transform.position.y > 5.0f || transform.position.x < -10.0f || transform.position.x > 10.0f)
        {
            Destroy(gameObject); // ȭ�� ������ ������ �� ������Ʈ ����
        }
    }
}
