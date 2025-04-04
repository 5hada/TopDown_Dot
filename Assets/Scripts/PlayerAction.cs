using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public float Speed;

    Rigidbody2D rigid;
    float h;
    float v;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rigid.linearVelocity = new Vector2(h, v)*Speed;
    }
}
