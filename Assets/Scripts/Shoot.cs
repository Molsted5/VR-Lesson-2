using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public LayerMask mask;

    public InputActionProperty shootAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float shootActivate = shootAction.action.ReadValue<float>();

        if (shootActivate == 1.0f) {
            print(shootActivate);

            Ray ray = new Ray (transform.position, transform.rotation * Vector3.forward);
            RaycastHit hitInfo;
		    if (Physics.Raycast (ray, out hitInfo, 200000, mask, QueryTriggerInteraction.Ignore)) {
			    Destroy (hitInfo.transform.gameObject);
		    }
        }

    }
}
