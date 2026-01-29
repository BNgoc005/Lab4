using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            audioSource.Play();
            Debug.Log("Đã nhấn phím Space");
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            audioSource.Stop();
            Debug.Log("Đã nhấn phím S");
        }
    }
}
