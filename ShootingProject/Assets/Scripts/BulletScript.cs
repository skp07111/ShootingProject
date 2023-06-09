using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.up; // 방향
        transform.position += dir * speed * Time.deltaTime; // 이동
        if (transform.position.y < -6.0f || transform.position.y > 6.0f || transform.position.x < -4.0f || transform.position.x > 4.0f)
        {
            Destroy(gameObject); // 화면 밖으로 나갔을 때 오브젝트 삭제
        }
    }
}
