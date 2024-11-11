using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    private float ejex;
    private float ejey;
    // Start is called before the first frame update
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        ejex = Input.GetAxis("Horizontal");
        ejey = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(ejex, ejey);
    }
}