using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public LayerMask mask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray (transform.position, transform.rotation * Vector3.forward);
        RaycastHit hitInfo;
		if (Physics.Raycast (ray, out hitInfo, 300, mask, QueryTriggerInteraction.Ignore)) {
			Destroy (hitInfo.transform.gameObject);
		}
    }
}
