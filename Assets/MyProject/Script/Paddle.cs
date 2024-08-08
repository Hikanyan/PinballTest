using UnityEngine;


public class Paddle : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _addForce = 10f;


    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontal * _speed * Time.deltaTime));
    }

    private void OnCollisionEnter(Collision other)
    {
        // Ballに当たった時に跳ね返る
        if (other.gameObject.CompareTag("Ball"))
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * _addForce, ForceMode.Impulse);
        }
    }
}