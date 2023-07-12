using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class knock : MonoBehaviour
{
    public float knockbackForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Apply the knockback operation by determining the direction and force
                Vector3 direction = (collision.transform.position - transform.position).normalized;
                rb.AddForce(direction * knockbackForce, ForceMode.Impulse);
            }
        }
    }
}
