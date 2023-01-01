using UnityEngine;

public class gamePlayCamController : MonoBehaviour
{
    public Transform Player;
    Vector3 targetCamPos;
    public float top;
    public float bottom;
    public float left;
    public float right;
    // Start is called before the first frame update
    void Start()
    {
        Player = Player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        targetCamPos = new Vector3(Player.position.x, Player.position.y, transform.position.z);
        processtargetCamPos();
        transform.position = Vector3.MoveTowards(transform.position, targetCamPos, 1f);
    }

    void processtargetCamPos()
    {
        if (Player.position.x > right)
            targetCamPos.x = right;
        if (Player.position.y > top)
            targetCamPos.y = top;

        if (Player.position.x < left)
            targetCamPos.x = left;
        if (Player.position.y < bottom)
            targetCamPos.y = bottom;

    }
}
