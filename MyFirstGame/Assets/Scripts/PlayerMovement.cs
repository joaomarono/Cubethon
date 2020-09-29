using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movingForward = 500f;
    public float movingSides = 500f;
    

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, movingForward * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(movingSides * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-movingSides * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
