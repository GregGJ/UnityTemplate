using Puerts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public JsEnv jsEnv;
    // Start is called before the first frame update
    void Start()
    {
        jsEnv = new JsEnv();        // 实例化 js 虚拟机

        // 使用虚拟机运行 js 脚本
        jsEnv.Eval(@"
            const CS = require('csharp');
            let gameObject = new CS.UnityEngine.GameObject('test');
            CS.UnityEngine.Debug.Log(gameObject.name);
        ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
