using UnityEngine;

public class plyrcollission : MonoBehaviour
{
    public PlyrMove move;
    public GameObject failmusic;
    public GameObject bgmusic;
    public GameObject engine;
    public GameObject kicksound;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            kicksound.SetActive(true);
            engine.SetActive(false);
            bgmusic.SetActive(false);
            failmusic.SetActive(true);
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
