using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 0; i< 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int a = 4; a == 0; a--)
        {
            Debug.Log(array[a]);
        }

        }
    }

class Boss
{
    int mp = 53;

    void Magic()
    {
        if(mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }
    }
    
  void start()
    {
        Boss lastboss = new Boss();

        lastboss.Magic();
        if (mp <= 3)
        {
            Debug.Log("MP������܂���B");
        }

    }
}

    // Update is called once per frame
    
