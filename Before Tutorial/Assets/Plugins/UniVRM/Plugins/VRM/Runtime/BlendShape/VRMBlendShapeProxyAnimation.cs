using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class VRMBlendShapeProxyAnimation : MonoBehaviour
{
    [SerializeField] private bool update = false;

    private VRMBlendShapeProxy vrmBlendShapeProxy;
    public Dictionary<BlendShapeKey, float> m_valueMap;

    private void Awake()
    {
        vrmBlendShapeProxy = GetComponent<VRMBlendShapeProxy>();

        m_valueMap = vrmBlendShapeProxy.m_merger.m_valueMap;
    }

    private void OnValidate()
    {
        if(update == true)
        {
            Awake();
        }
    }


    private void DictionaryToList()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            var proxy = GetComponent<VRMBlendShapeProxy>();

            proxy.SetValues(new Dictionary<BlendShapeKey, float>
            {
                {BlendShapeKey.CreateFromPreset(BlendShapePreset.Blink_L), 1.0f},
                {BlendShapeKey.CreateFromPreset(BlendShapePreset.Blink_R), 1.0f},
            });

        }
    }
}
