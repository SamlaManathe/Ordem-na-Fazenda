using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoAnimais : MonoBehaviour

{

  public float velocidade = 5f;

  private Rigidbody rb;

  void Start()

  {

    rb = GetComponent<Rigidbody>();

  }

  void FixedUpdate()

  {

    float horizontal = Input.GetAxis("Horizontal");

    float vertical = Input.GetAxis("Vertical");

    Vector3 movimento = new Vector3(horizontal, 0, vertical);

    rb.velocity = new Vector3(

      movimento.x * velocidade,

      rb.velocity.y,

      movimento.z * velocidade

    );

  }

}