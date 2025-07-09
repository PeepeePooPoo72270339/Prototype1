using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float TurnSpeed;
    public float HorizontalInput;
    public float ForwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        //Move car based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
        //Move car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * HorizontalInput);
    }
}
