using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public AudioClip clip;

    int maxBounces = 3;
    int currentBounces;
    public void Shot()
    {
        GetComponent<Rigidbody>().AddForce((transform.forward + Vector3.up * Random.Range(-0.3f, .3f)) * 100.0f);
    }

    private void OnCollisionEnter(Collision collision) 
    {
        AudioSource.PlayClipAtPoint(clip, collision.contacts[0].point);
        currentBounces++;
        if (currentBounces >= maxBounces)
        {
            Destroy(gameObject);
        }

    }
}
