using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {
    public Transform target;
    public float range = 5f;
    public Transform Turret;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        Turret.rotation = lookRotation;
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
