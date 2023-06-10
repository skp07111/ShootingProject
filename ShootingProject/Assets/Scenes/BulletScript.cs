using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.left; // 방향
        transform.position += dir * speed * Time.deltaTime; // 이동
        if (transform.position.y < -5.0f || transform.position.y > 5.0f || transform.position.x < -10.0f || transform.position.x > 10.0f)
        {
            Destroy(gameObject); // 화면 밖으로 나갔을 때 오브젝트 삭제
        }
    }
}
