using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArea : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag == "Player")
    {
      Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
      rb.AddForce(new Vector3(0,2000,0));
      Destroy(this.gameObject);
    }
  }
}
