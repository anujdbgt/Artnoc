using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDisabler : MonoBehaviour {

    [SerializeField]
    protected float timeToDisable = 2f;

    private void OnEnable()
    {
        Invoke("Disabler", timeToDisable);
    }

    void Disabler()
    {
        gameObject.SetActive(false);
    } 
}
