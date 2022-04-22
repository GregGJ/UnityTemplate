import { UnityEngine } from "csharp";


const cube = UnityEngine.GameObject.Find("Cube");

setInterval(() => {
    let x = 100;
    let y = 0;
    let z = 0;
    const time = UnityEngine.Time.time;
    cube.transform.Rotate(x*time,y*time,z*time);
});

UnityEngine.Debug.Log("Ts Log~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");