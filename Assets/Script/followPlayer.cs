using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 7f;
    public float distanceWithPlayer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 distance = player.transform.position - transform.position;
        if (distance.magnitude >= distanceWithPlayer)
        {
            Vector3 targetPoint = player.transform.position - distance.normalized * distanceWithPlayer;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, speed * Time.deltaTime);
        }
    }
}

