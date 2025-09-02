using UnityEngine;

public class PlayerController : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {
    float inputX = Input.GetAxisRaw("Horizontal");
    float inputY = Input.GetAxisRaw("Vertical");

    Vector2 movement = Vector2.right * inputX
                     + Vector2.up * inputY;

    transform.Translate(movement * 0.02f);
  }
}