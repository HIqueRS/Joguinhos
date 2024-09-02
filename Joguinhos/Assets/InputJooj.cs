using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputJooj : MonoBehaviour
{
    //transformar em scriptable obj se pa

    [SerializeField] public KeyCode[] rigth_button;
    [SerializeField] public KeyCode[] left_button;
    [SerializeField] public KeyCode[] foward_button;
    [SerializeField] public KeyCode[] back_button;

    public bool GetKeyDown(KeyCode[] keyList)
    {
        foreach(KeyCode key in keyList)
        {
            if(Input.GetKey(key))
            {
                return true;
            }
        }
        return false;
    }
}
