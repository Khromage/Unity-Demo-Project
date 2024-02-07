using UnityEngine;

public class SimpleEnemyMovement : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    public float speed = 0.5f;

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 2);
        transform.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, time);
    }
}
