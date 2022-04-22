"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const csharp_1 = require("csharp");
const cube = csharp_1.UnityEngine.GameObject.Find("Cube");
setInterval(() => {
    let x = 100;
    let y = 0;
    let z = 0;
    const time = csharp_1.UnityEngine.Time.time;
    cube.transform.Rotate(x * time, y * time, z * time);
});
csharp_1.UnityEngine.Debug.Log("Ts Log~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiVGVzdC5qcyIsInNvdXJjZVJvb3QiOiIiLCJzb3VyY2VzIjpbIi4uL3NyYy9UZXN0LnRzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiI7O0FBQUEsbUNBQXFDO0FBR3JDLE1BQU0sSUFBSSxHQUFHLG9CQUFXLENBQUMsVUFBVSxDQUFDLElBQUksQ0FBQyxNQUFNLENBQUMsQ0FBQztBQUVqRCxXQUFXLENBQUMsR0FBRyxFQUFFO0lBQ2IsSUFBSSxDQUFDLEdBQUcsR0FBRyxDQUFDO0lBQ1osSUFBSSxDQUFDLEdBQUcsQ0FBQyxDQUFDO0lBQ1YsSUFBSSxDQUFDLEdBQUcsQ0FBQyxDQUFDO0lBQ1YsTUFBTSxJQUFJLEdBQUcsb0JBQVcsQ0FBQyxJQUFJLENBQUMsSUFBSSxDQUFDO0lBQ25DLElBQUksQ0FBQyxTQUFTLENBQUMsTUFBTSxDQUFDLENBQUMsR0FBQyxJQUFJLEVBQUMsQ0FBQyxHQUFDLElBQUksRUFBQyxDQUFDLEdBQUMsSUFBSSxDQUFDLENBQUM7QUFDaEQsQ0FBQyxDQUFDLENBQUM7QUFFSCxvQkFBVyxDQUFDLEtBQUssQ0FBQyxHQUFHLENBQUMsMENBQTBDLENBQUMsQ0FBQyJ9