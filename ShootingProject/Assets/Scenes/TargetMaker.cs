using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMaker : MonoBehaviour
{
    float currentTime;
    public float createTime = 10.0f;
    public GameObject targetFactory;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float random = Random.Range(-4.0f, 4.0f);

        currentTime += Time.deltaTime;

        if (currentTime > createTime)
        {
            GameObject target = Instantiate(targetFactory);
            target.transform.position = transform.position;
            target.transform.position = new Vector3(-9.0f, random, 0);
            currentTime = 0;
        }
    }
}
