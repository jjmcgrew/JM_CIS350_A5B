/*
 * Josh McGrew
 * Assignment 5B
 * shoot
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    //for muzzle flash
    public ParticleSystem muzzleFlash;

    public float hitForce = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hitInfo;
        //if something is hit with the ray
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            //Debug.Log(hitInfo.transform.gameObject.name);

            //get the target script off of the hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            //if the target script was found, make the target take damage
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            //add force to object rigidbody
            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }
        }
    }
}
