using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour

{

  private void OnTriggerEnter(Collider other)

  {

    if (other.CompareTag("Player"))

    {
      GerenciadorMissoes.instancia.ColetouMaca();

      Destroy(gameObject);

    }

  }

}
