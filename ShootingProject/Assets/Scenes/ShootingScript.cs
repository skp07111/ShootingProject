using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletFactory; // bullet ����
    public GameObject shootingLocation; // bullet ���� ��ġ
    Vector2 dir; // ���콺 ���� �����ϴ� ����
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
            bullet.gameObject.GetComponent<Rigidbody2D>().AddForce(dir, ForceMode2D.Impulse);
        }
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        dir = mousePos - (Vector2)transform.position;
        transform.up = dir.normalized;
    }
}
