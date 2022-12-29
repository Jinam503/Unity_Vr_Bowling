using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ddddd : MonoBehaviour
{
    public GameObject pins;
    public GameObject ball;
    public GameObject score_;
    public Vector3 pinsVec;
    public Vector3 ballVec;
    GameObject p;
    GameObject b;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(pins, pinsVec, Quaternion.Euler(0f, 180f, 0f));
        Instantiate(ball, ballVec, Quaternion.identity);
    }

    // Update is called once per framet
    void Update()
    {
        
    }
    public void resetPin()
    {
        score_.GetComponent<score>().Throw++;
        if (score_.GetComponent<score>().Throw == 2) { score_.GetComponent<score>().Throw = 0; }
        if (score_.GetComponent<score>().cnt == 1 && !score_.GetComponent<score>().finish)
        {
            b = GameObject.FindGameObjectWithTag("ball");
            Destroy(b);
            Instantiate(ball, ballVec, Quaternion.identity);
            return;
        }
        else
        {
            p = GameObject.FindGameObjectWithTag("pins");
            Destroy(p);
            Instantiate(pins, pinsVec, Quaternion.Euler(0f, 180f, 0f));
            b = GameObject.FindGameObjectWithTag("ball");
            Destroy(b);
            Instantiate(ball, ballVec, Quaternion.identity);
            score_.GetComponent<score>().s = 0;
            score_.GetComponent<score>().cnt = 0;
            score_.GetComponent<score>().finish = false;
        }

        
        
        
    }
}
