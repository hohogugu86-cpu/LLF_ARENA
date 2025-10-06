using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class HeroController : MonoBehaviour
{
    public float speed = 5f;
    CharacterController cc;
    void Start(){ cc = GetComponent<CharacterController>(); }
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h,0,v);
        if (move.magnitude > 0.1f) cc.SimpleMove(move.normalized * speed);
    }
}
