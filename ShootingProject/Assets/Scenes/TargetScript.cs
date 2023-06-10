using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 2;
    Vector3 dir;
    
    void Start()
    {
        dir = Vector3.down; // πÊ«‚
        GameObject player = GameObject.Find("Player");
        dir = player.transform.position - transform.position;
        dir.Normalize();
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
