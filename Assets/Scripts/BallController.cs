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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
