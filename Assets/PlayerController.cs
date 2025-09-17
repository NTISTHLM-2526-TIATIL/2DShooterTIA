using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float speed = 0.02f;

  [SerializeField]
  GameObject boltPrefab;

  float timeSinceLastShot = 0;
  [SerializeField]
  float timeBetweenShots = 0.5f;

  void Update()
  {
    float inputX = Input.GetAxisRaw("Horizontal");
    float inputY = Input.GetAxisRaw("Vertical");

    Vector2 movement = Vector2.right * inputX
                     + Vector2.up * inputY;

    transform.Translate(movement * speed * Time.deltaTime);

    // =========================================================================
    // Skjuta
    // -------------------------------------------------------------------------

    timeSinceLastShot += Time.deltaTime;

    if (Input.GetAxisRaw("Fire1") > 0 && timeSinceLastShot > timeBetweenShots)
    {
      AudioSource speaker = GetComponent<AudioSource>();

      speaker.Play();

      // GetComponent<AudioSource>().Play();

      Instantiate(boltPrefab, transform.position, Quaternion.identity);
      timeSinceLastShot = 0;
    }
  }
}