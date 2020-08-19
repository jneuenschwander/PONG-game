using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
/// <summary>
/// Moves ball within a 2D space for pong game
/// Author: Sebastian Gomez Rosas
/// </summary>

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Vector2 _velocity;
    [SerializeField] private float movementForce = 1f;
    
    private void Awake()
    
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        var direction = new Vector3(Random.Range(0f, 360f), Random.Range(0f, 360f), 0f);
        _rigidbody2D.AddForce(direction.normalized * movementForce, ForceMode2D.Impulse);
    }
    void Update()
    {
        _velocity = _rigidbody2D.velocity;
        if (transform.position.x >= 6.25)
        {
            transform.position = new Vector3(0f,0f,0f); // aqui deberia enviarse la señal de gano un punto
        }else if(gameObject.transform.position.x <= -6.25) {
            transform.position = new Vector3(0f,0f,0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        var speed = _velocity.magnitude;
        var newDirection = Vector3.Reflect(_velocity.normalized, other.contacts[0].normal); //lógica del rebote
        _rigidbody2D.velocity = newDirection * Mathf.Max(speed, 0f);
        
        
    }
}
