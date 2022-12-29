using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public GameObject d;
    bool c = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "road" && c == false)
        {
            d = GameObject.Find("ScoreManager");
            d.GetComponent<score>().s++;
            c = true;
        }
    }
}
