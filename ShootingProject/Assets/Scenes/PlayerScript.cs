using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // 플레이어 이동 속도
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(0, v, 0);
        if (transform.position.y < -5)
        {
            transform.position = new Vector2(transform.position.x, -5);
        }
        else if (transform.position.y > 5) 
        {
            transform.position = new Vector2(transform.position.x, 5);
        }
        else
        {
            transform.position += dir * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("OverScene");
    }
}
