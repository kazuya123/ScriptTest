using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    
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
       
        for (int i = 0; i < 11; i++)
        {
            boss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}

