using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipIntro : MonoBehaviour
{
    public void Skip()
    {
        SceneManager.LoadScene("Game");
    }
}
