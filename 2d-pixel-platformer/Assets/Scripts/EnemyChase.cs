using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    public float forceStrength;     // How fast we move
    public Transform target;        // The thing you want to chase

    private Rigidbody2D ourRigidbody;   // The rigidbody attached to this object


    void Awake()
    {
        // Get the rigidbody that we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // Move in the direction of our target

        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
