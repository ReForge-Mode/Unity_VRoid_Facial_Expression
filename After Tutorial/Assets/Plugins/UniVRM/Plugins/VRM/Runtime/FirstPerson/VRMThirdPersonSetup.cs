using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class VRMThirdPersonSetup : MonoBehaviour
{
    [SerializeField]
    Camera m_firstPersonCamera; // HMDのカメラ

    [SerializeField]
    LayerMask m_firstPersonMask; // HMDのカメラにセットするマスク default | VRMFirstPersonOnly など

    [SerializeField]
    LayerMask m_otherMask; // HMDのカメラにセットするマスク default | VRMThirdPersonOnly など

    [SerializeField]
    VRMFirstPerson m_firstPerson;

    void Reset()
    {
        m_firstPerson = GameObject.FindObjectOfType<VRMFirstPerson>();
    }

    void Start()
    {
        foreach (var camera in GameObject.FindObjectsOfType<Camera>())
        {
            camera.cullingMask = (camera == m_firstPersonCamera)
                ? m_firstPersonMask
                : m_otherMask
                ;
        }

        // VRMFirstPersonの初期化
        if (m_firstPerson != null)
        {
            m_firstPerson.Setup();
        }
    }
}