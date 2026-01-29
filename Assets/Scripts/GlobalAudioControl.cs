using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAudioControl : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0 : 1;
            Debug.Log("Tắt tiếng: " + isMuted);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isPaused)
            {
                AudioListener.pause = true;
                isPaused = true;
                Debug.Log("Đã tạm dừng: " + isPaused);
            }
            else
            {
                AudioListener.pause = false;
                isPaused = false;
                Debug.Log("Đã tiếp tục phát: " + isPaused);
            }
        }
    }
}

