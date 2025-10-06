using UnityEngine;
public class AIController : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed = 2f;
    int idx = 0;
    void Update()
    {
        if (patrolPoints.Length==0) return;
        Transform target = patrolPoints[idx];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target.position) < 0.2f) idx = (idx+1)%patrolPoints.Length;
    }
}
