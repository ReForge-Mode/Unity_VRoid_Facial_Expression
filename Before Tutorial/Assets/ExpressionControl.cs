using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionControl : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void SetExpression_Default()
    {
        Debug.Log("Animation Default");
    }

    public void SetExpression_Joy()
    {
        Debug.Log("Animation Joy");
    }

    public void SetExpression_Surprised()
    {
        Debug.Log("Animation Surprised");
    }

    public void SetExpression_Sus()
    {
        Debug.Log("Animation Sus");
    }
}
