using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puerts;

public class Main : MonoBehaviour
{
    private JsEnv jsEnv;
    // Start is called before the first frame update
    async void Start()
    {
        // jsEnv=new JsEnv(new DefaultLoader(Application.dataPath+"/../TSProject/dist/"),9229);
        jsEnv=new JsEnv(new DefaultLoader("C:/work/unity/UnityTemplate/TSProject/dist/"),8282);
        await jsEnv.WaitDebuggerAsync();
        jsEnv.Eval("require('Test')");
    }

    // Update is called once per frame
    void Update()
    {
        jsEnv.Tick();
    }
}
