 using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public float SpawnDelay;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Winner");
    }
    public void EndGame()
    {
        if (gamehasended == false)
        {
            Debug.Log("Game Over");
            gamehasended = true;
            Invoke("restart", SpawnDelay);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
