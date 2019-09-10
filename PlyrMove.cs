using UnityEngine;

public class PlyrMove : MonoBehaviour
{
    // such declared values can be changed in unity
    // declarations are to be public
    public Rigidbody rb;
    public float ForwardForce = 500f;
    public float SidewaysForce = 500f;
    public GameObject failmusic;
    public GameObject bgmusic;
    public GameObject engine;
    public GameObject fallsound;
    //float values are denoted with an f at the end because unity will complain
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // USing fixedupdate instead of update because it is a physics related code
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            // This Checks for Input from the 'd' key and creates a force towards right if 'd' is pressed.
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            // This Checks for Input from the 'a' key and creates a force towards left if 'a' is pressed.
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f)
        {
            engine.SetActive(false);
            bgmusic.SetActive(false);
            failmusic.SetActive(true);
            fallsound.SetActive(true);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
