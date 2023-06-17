using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 2;
    Vector3 dir;
    
    void Start()
    {
        dir = Vector3.right; // πÊ«‚
        GameObject player = GameObject.Find("swuniz");
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
        Destroy(gameObject, 0.3f);
        GetComponent<ParticleSystem>().Play();
        GetComponent<AudioSource>().Play();
    }    
}
