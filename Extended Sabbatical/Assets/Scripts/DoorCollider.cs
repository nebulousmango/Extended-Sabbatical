using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{
    [SerializeField] GameObject TurnThisOn1;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Enter.");
        TurnThisOn1.SetActive(true);
    }

}
