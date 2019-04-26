using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField]
    private GameObject weapon;

    private Rigidbody2D rb;
    [SerializeField]
    private float _movementSpeed = 5f;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        // Weapon Angle
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float angle = Utilities.AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
        weapon.transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));

        // Show Weapon
        if(Input.GetMouseButton(0)) {
            weapon.SetActive(true);
        } else {
            weapon.SetActive(false);
        }

        // Movement
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (move.magnitude > 1.0f) {
            move = move.normalized;
        }
        rb.velocity = move * _movementSpeed;
    }
}
