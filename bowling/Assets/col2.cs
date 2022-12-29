using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col2 : MonoBehaviour
{
    public GameObject d;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            
            d = GameObject.Find("ScoreManager");
            d.GetComponent<score>().cnt++;
            Debug.Log(d.GetComponent<score>().cnt);
        }
    }
}
