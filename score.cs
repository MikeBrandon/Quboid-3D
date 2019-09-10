using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Vector3 balance;
    public Vector3 rebalance;

    void Start()
    {
        balance = balance + player.position;
    }
    // Update is called once per frame
    void Update()
    {
        balance = balance + player.position;
        scoreText.text = balance.z.ToString("0");
        balance = rebalance;
        // The 0 after to string rounds off to 0
        // the to string converts the float to a string
    }
}
