using UnityEngine;

public class mainMenuCamController : MonoBehaviour
{
    Vector3 pos, pos1, pos2;
    public float speed = 0.008f;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = new Vector3(-2, transform.position.y, transform.position.z);
        pos2 = new Vector3(0, transform.position.y, transform.position.z);
        pos = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pos, speed);
        if (transform.position.x >= pos2.x)
        {
            pos = pos1;
        }
        if (transform.position.x <= pos1.x)
        {
            pos = pos2;
        }
    }
}
