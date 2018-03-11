using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTimeout : MonoBehaviour {

    [Tooltip("Esperar X segundos antes de destruir el objeto")]
    public float waitBeforeDestroy;

    // Use this for initialization
    void Awake ()
    {
        StartCoroutine(ControlLimit());
	}

    public IEnumerator ControlLimit()
    {
        yield return new WaitForSeconds(waitBeforeDestroy);
        Destroy(gameObject);
    }
}
