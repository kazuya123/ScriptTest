using UnityEngine;
using System.Collections;

public class Boss
{
    public void Magic(int mp)
    {
        if (mp >= 10)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            
        }
            else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
    }
        // Use this for initialization
        void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
