using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseBtn : MonoBehaviour
{
    public bool IsEraseClick;

    public void Erase()
    {
        if(IsEraseClick == false)
        {
            IsEraseClick = true;
        }
        else if(IsEraseClick == true){
            IsEraseClick = false;
        }
    }
}
