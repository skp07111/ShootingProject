using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletFactory; // bullet ����
    public GameObject shootingLocation; // bullet ���� ��ġ
    float speed = 5.0f; // bullet �ӵ�
    Vector3 dir; // ���콺 ���� �����ϴ� ����
    Camera cam; // Main Camera

    private void Start() 
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetMouseButtonDown(0)) {// ���콺 Ŭ�� ��
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = shootingLocation.transform.position;
            bullet.gameObject.GetComponent<Rigidbody2D>().AddForce(dir * speed, ForceMode2D.Impulse);
        }
        dir = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -cam.transform.position.z));
    }
}
