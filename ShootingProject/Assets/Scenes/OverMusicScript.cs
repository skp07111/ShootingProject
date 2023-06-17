using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverMusicScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }
}
