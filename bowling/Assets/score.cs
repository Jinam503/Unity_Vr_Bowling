using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public int s;
    public TextMeshProUGUI t;

    public int cnt = 0;
    public int Throw = 0;
    public bool finish = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(s >= 10 && cnt == 1) { t.text = "STRIKE!!"; finish = true; }
        else if(s >= 10 && cnt == 2) { t.text = "SPARE!!"; finish = true; }
        else if( Throw  == 0) { t.text = "Trial 1\n" + s; }
        else if (Throw == 1) { t.text = "Trial 2\n" + s; }
        else t.text = s + "";
    }
}
