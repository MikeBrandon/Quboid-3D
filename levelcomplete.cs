using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete : MonoBehaviour
{
    public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
