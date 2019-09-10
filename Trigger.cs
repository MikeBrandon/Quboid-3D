using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
