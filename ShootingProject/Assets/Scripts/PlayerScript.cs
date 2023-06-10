using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // 플레이어 이동 속도
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(h, 0);
        if (transform.position.x < -3)
        {
            transform.position = new Vector2(-3, transform.position.y);
        }
        else if (transform.position.x > 3) 
        {
            transform.position = new Vector2(3, transform.position.y);
        }
        else
        {
            transform.position += dir * speed * Time.deltaTime;
        }
    }
}
