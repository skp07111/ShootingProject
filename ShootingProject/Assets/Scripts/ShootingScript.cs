using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletFactory; // bullet 공장
    public GameObject shootingLocation; // bullet 생성 위치
    Vector2 dir; // 마우스 방향 저장하는 변수
    Camera cam; // Main Camera

    private void Start() 
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetMouseButtonDown(0)) {// 마우스 클릭 시
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = shootingLocation.transform.position;
            bullet.gameObject.GetComponent<Rigidbody2D>().AddForce(dir, ForceMode2D.Impulse);
        }
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        dir = mousePos - (Vector2)transform.position;
        transform.up = dir.normalized;
    }
}
