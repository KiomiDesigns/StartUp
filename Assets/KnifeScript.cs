using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    public bool grabbed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        print("a");
        if (other.gameObject.CompareTag("Police") && grabbed)
        {
            print("b");
            if (other.gameObject.GetComponent<PoliceBehaviour>() != null)
                other.gameObject.GetComponent<PoliceBehaviour>().enabled = false;
            else other.gameObject.GetComponent<PoliceAi>().enabled = false;
            other.transform.rotation = Quaternion.Euler(-90, 0, 0);
            other.transform.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

}
