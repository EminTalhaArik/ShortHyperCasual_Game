using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexegon : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float shrinkSpeed = 1f;

    private void Start()
    {
        myRigidbody.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    private void Update()
    {
        transform.localScale -= shrinkSpeed * Time.deltaTime * Vector3.one;

        if(transform.localScale.x <= 0.05f)
        {
            Destroy(this.gameObject);
        }
    }
}
