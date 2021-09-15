using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            float movH = Input.GetAxis("Horizontal");
            float movV = Input.GetAxis("Vertical");

            Vector2 movimiento = new Vector2(movH * Time.deltaTime * speed, movV * Time.deltaTime * speed);

            transform.Translate(movimiento);
        
    }
}
