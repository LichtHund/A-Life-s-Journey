using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;

    private float heldDownTime = 0f;

    void Update() {

        if (Input.GetButtonDown("PS4_Square")) {
            heldDownTime = Time.time;
        }

        if (Input.GetButtonUp("PS4_Square")) {
            heldDownTime = Time.time - heldDownTime;
            Debug.Log("Pressed for : " + heldDownTime + " Seconds");
            Shoot();
        }

    }

    void Shoot() {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
