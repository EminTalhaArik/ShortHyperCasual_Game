using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    private float movement = 0f;

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward * -1, movement * Time.fixedDeltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("GameScene");
    }
}
