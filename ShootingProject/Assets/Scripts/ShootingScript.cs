using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletFactory; // bullet 공장
    public GameObject shootingLocation; // bullet 생성 위치
    float speed = 5.0f; // bullet 속도
    Vector3 dir; // 마우스 방향 저장하는 변수
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
            bullet.gameObject.GetComponent<Rigidbody2D>().AddForce(dir * speed, ForceMode2D.Impulse);
        }
        dir = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -cam.transform.position.z));
    }
}
