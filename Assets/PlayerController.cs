using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  Rigidbody2D rb;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  void Update()
  {

  }

  void OnJump(InputValue value)
  {
    print("JUMP");
    rb.AddForce(Vector2.up * 2000);
  }
}
