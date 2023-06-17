using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMusicScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }
}
