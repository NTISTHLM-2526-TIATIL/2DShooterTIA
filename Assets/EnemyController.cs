using UnityEngine;


public class EnemyController : MonoBehaviour
{
  void Start()
  {
    Vector2 newPos = new();
    newPos.x = Random.Range(-7f, 7f);
    newPos.y = Random.Range(-4f, 4f);

    transform.position = newPos;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
