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
        jsEnv = new JsEnv();        // ʵ���� js �����

        // ʹ����������� js �ű�
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
