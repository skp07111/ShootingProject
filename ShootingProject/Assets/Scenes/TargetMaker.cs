using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMaker : MonoBehaviour
{
    float currentTime;
    public float createTime = 1;
    public GameObject targetFactory;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float random = Random.Range(-3.0f, 3.0f);

        currentTime += Time.deltaTime;

        if (currentTime > createTime)
        {
            GameObject target = Instantiate(targetFactory);
            target.transform.position = transform.position;
            target.transform.position = new Vector3(random, 4.0f, 0);
            currentTime = 0;
        }
    }
}
