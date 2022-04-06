using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionControl : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void SetExpression_Default()
    {
        Debug.Log("Animation Default");
        anim.SetTrigger("Default");
    }

    public void SetExpression_Joy()
    {
        Debug.Log("Animation Joy");
        anim.SetTrigger("Joy");
    }

    public void SetExpression_Surprised()
    {
        Debug.Log("Animation Surprised");
        anim.SetTrigger("Surprised");
    }

    public void SetExpression_Sus()
    {
        Debug.Log("Animation Sus");
        anim.SetTrigger("Sus");
    }
}
