## 📝 방문 길이

[방문 길이](https://programmers.co.kr/learn/courses/30/lessons/49994)

### 📍 내 풀이(javascript)

```javascript
function solution(dirs) {
    var answer = 0;
    let x = 0;
    let y = 0;
    
    const road = new Set();  // 중복되서 데이터가 들어가지 않도록 Set 생성

    for(let i = 0; i < dirs.length; i++) {
        let nextX = x;
        let nextY = y;
        
        if(dirs[i] === 'U' && nextY < 5) {
            nextY += 1;
        }
        else if(dirs[i] === 'D' && nextY > -5) {
            nextY -= 1;
        }
        else if(dirs[i] === 'L' && nextX > -5) {
            nextX -= 1;
        }
        else if(dirs[i] === 'R' && nextX < 5) {
            nextX += 1;
        }
        
        if(x !== nextX || y !== nextY) {  // 움직였을 때만 set에 추가하기 위해 확인
            if(!road.has(`${nextX}${nextY}${x}${y}`)) {  // [x,y, nextX, nextY] 와 [nextX, nextY, x,y]은 움직이는 방향만 다를 뿐 같은 길이기 때문에 확인
                road.add(`${x}${y}${nextX}${nextY}`);
            }
        }
        
        x = nextX;
        y = nextY;
    }
    
    return road.size;
}
```


### 📍 다른 사람 풀이 (javascript)
```javascript
function solution(dirs) {
    const firstPathMap = new Map();
    let now = [0, 0];
    let moved;
    for(let dir of dirs) {
        moved = move(now, dir);
        if(moved[0] < -5 || moved[0] > 5 || moved[1] < -5 || moved[1] > 5) {
            continue;
        }
        firstPathMap.set(generateKey(now, moved), true);  // map에 처음 간 길을 key로 추가
        now = moved;
    }  

    return firstPathMap.size;
}

function move(now, dir) {
    switch(dir) {
        case 'L': 
            return [now[0] - 1, now[1]];
        case 'R':
            return [now[0] + 1, now[1]];
        case 'U':
            return [now[0], now[1] + 1];
        case 'D':
            return [now[0], now[1] - 1];
    }        
}

function generateKey(now, moved) {
    return `${Math.min(now[0], moved[0])},${Math.max(now[0], moved[0])},${Math.min(now[1], moved[1])},${Math.max(now[1], moved[1])}`;
    // 현재x, 이동한x, 현재y, 이동한y로 키를 생성
}
```
