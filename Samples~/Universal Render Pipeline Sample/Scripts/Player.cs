using UnityEngine;

namespace Arena.Samples
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        public float moveSpeed = 5f;

        private Rigidbody rb;
        private Vector3 movement;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            movement = new Vector3(moveX, 0f, moveZ) * moveSpeed;
        }

        void FixedUpdate()
        {
            rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);
        }
    }
}
