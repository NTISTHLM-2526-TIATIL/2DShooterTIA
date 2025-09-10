using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed;

  void Start()
  {
    Vector2 newPos = new();
    newPos.x = Random.Range(-7f, 7f);
    newPos.y = Camera.main.orthographicSize + 1;

    transform.position = newPos;
  }

  // Update is called once per frame
  void Update()
  {
    Vector2 movement = Vector2.down * speed;
    transform.Translate(movement * Time.deltaTime);

    if (transform.position.y < -Camera.main.orthographicSize - 1)
    {
      Destroy(this.gameObject);
    }
  }
}
