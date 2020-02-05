using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaLoaderTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.AddComponent<XLuaManager>();
        XLuaManager.Instance.InitLuaEnv();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
