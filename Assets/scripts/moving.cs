using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * 30 * Time.deltaTime);
        if (this.transform.position.y > 20  )
        {
            Destroy(this.gameObject);
        }
	}
}
