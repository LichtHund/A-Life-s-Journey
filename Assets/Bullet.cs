using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20;
    public Rigidbody2D rigidbody2D;

    private Vector2 bulletStart;


    void Start() {

        bulletStart = rigidbody2D.position;

        rigidbody2D.velocity = transform.right * speed;

    }

    public void Update() {

        if ((bulletStart - rigidbody2D.position).sqrMagnitude > 300) {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {

        Destroy(gameObject);

        Debug.Log(hitInfo.name);
    }

}
