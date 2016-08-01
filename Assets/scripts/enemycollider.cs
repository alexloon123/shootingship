using UnityEngine;
using System.Collections;

public class enemycollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            int x = Random.Range(-5, 5);
            Instantiate(this.gameObject, new Vector3(x,10,0), Quaternion.identity);
        }
    }
}
