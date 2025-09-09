using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float speed = 0.02f;

  [SerializeField]
  GameObject boltPrefab;

  void Update()
  {
    float inputX = Input.GetAxisRaw("Horizontal");
    float inputY = Input.GetAxisRaw("Vertical");

    Vector2 movement = Vector2.right * inputX
                     + Vector2.up * inputY;

    transform.Translate(movement * speed * Time.deltaTime);

    if (Input.GetAxisRaw("Fire1") > 0)
    {
      Instantiate(boltPrefab, transform.position, Quaternion.identity);
    }
  }
}