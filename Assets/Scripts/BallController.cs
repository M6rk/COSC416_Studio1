using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    public void BallJump(float jumpHeight)
    {
        if (Mathf.Abs(sphereRigidbody.linearVelocity.y) < 0.001f) // check if ball is grounded
        {
            sphereRigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            Debug.Log("Jump!"); // log each time ball jumps
        }
    }

    void Start()
    {

    }

    void Update()
    {
    }
}