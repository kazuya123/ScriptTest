using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    int mp = 53;
    // Use this for initialization
    void Start()
    {
        int[] array = { 30, 20, 50, 10, 80 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Boss boss = new Boss();
       
        for (int i = 0; i < 10; i++)
        {
            boss.Magic(mp);
            mp -= 10;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}

