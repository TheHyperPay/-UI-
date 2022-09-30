using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_controll : MonoBehaviour
{
    public Animator Anim;

    static private bool IsUpperUI_Activate=false;
    public void UpperUI_Controll()
    {
        if(IsUpperUI_Activate)
        {
            Anim.Play("Shrink");
            IsUpperUI_Activate=false;
        }
        else if(!IsUpperUI_Activate)
        {
            Anim.Play("Extend");
            IsUpperUI_Activate=true;
        }
    }
}
