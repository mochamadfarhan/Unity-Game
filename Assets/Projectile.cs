using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public GameObject impactEffect;
	public float radius = 1;
	public int damageAmount = 25;
	private void OnCollisionEnter(Collision collision)
	{
		GameObject impact = Instantiate(impactEffect, transform.position, Quaternion.identity);
		Destroy(impact,2);
		Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
		foreach(Collider nearbyObject in colliders)
		{
			if(nearbyObject.tag == "Player")
			{
				StartCoroutine(FindObjectOfType<PlayerManager>().TakeDamage(damageAmount));
			}
		}
		this.enabled = false;
	}
}
