## 📝 거리두기 확인

[거리두기 확인](https://programmers.co.kr/learn/courses/30/lessons/81302)

### 📍 내 풀이(javascript)
`Array`

```javascript
function solution(places) {
    var answer = [];
    
    places.forEach((place, index) => {
        for(let i = 0; i < place.length; i++) {
            for(let j = 0; j < place[i].length; j++) {
                if(place[i][j] === 'P') {
                   if(!isDistancing(i, j, place)){  //P일때, P가 거리두기를 지키는지 확인
                       answer.push(0);
                       break;
                   }
                }
            }
      
            if(answer[index] === 0) break;
        }
        
        if(answer[index] !== 0) {
            answer.push(1);
        }
    });
    
    return answer;
}

function isDistancing(i, j, place) { // P 주변 상하좌우 대각선을 확인해서 못 지키면 false, 지키면 true 반환
    if(i-2 >= 0) { //상
        if(place[i-1][j] === 'P' || (place[i-1][j] !== 'X' && place[i-2][j] === 'P')) {
            return false;
        }
    }
    if(i+2 <= 4) { //하
        if(place[i+1][j] === 'P' || (place[i+1][j] !== 'X' && place[i+2][j] === 'P')) {
            return false;
        }
    }
    if(j-2 >= 0) { //좌
        if(place[i][j-1] === 'P' || (place[i][j-1] !== 'X' && place[i][j-2] === 'P')) {
            return false;
        }
    }
    if(j+2 <= 4) { //우
        if(place[i][j+1] === 'P' || (place[i][j+1] !== 'X' && place[i][j+2] === 'P')) {
            return false;
        }
    }
    if(i-1 >= 0 && j-1 >= 0) { //왼쪽 위 대각선
        if(place[i-1][j-1] === 'P' && (place[i-1][j] !== 'X' || place[i][j-1] !== 'X')) {
            return false;
        }
    }
    if(i-1 >= 0 && j+1 <= 4) { //오른쪽 위 대각선
        if(place[i-1][j+1] === 'P' && (place[i-1][j] !== 'X' || place[i][j+1] !== 'X')) {
            return false;
        }
    }
    if(i+1 <= 4 && j+1 <= 4) { //오른쪽 아래 대각선
        if(place[i+1][j+1] === 'P' && (place[i+1][j] !== 'X' || place[i][j+1] !== 'X')) {
            return false;
        }
    }
    if(i+1 <= 4 && j-1 >= 0) { //왼쪽 아래 대각선
        if(place[i+1][j-1] === 'P' && (place[i+1][j] !== 'X' || place[i][j-1] !== 'X')) {
            return false;
        }
    }
    
    return true;
}
```

### 📍 다른 사람 풀이(javascript)
```javascript
const existPartitionNearBy = (source, target, partitions) => {
  const [sourceX, sourceY] = source;
  const [targetX, targetY] = target;
  let validPartitions = []; // 거리두기 가능한 파티션 위치

  if (sourceX === targetX) { // 같은 row일 때
    validPartitions.push([
      sourceX,
      sourceY < targetY ? sourceY + 1 : targetY + 1,  // source, target 중 더 왼쪽에 있는 것의 바로 오른쪽 위치
    ]);
  } else if (sourceY === targetY) { // 같은 column 일때
    validPartitions.push([
      sourceX < targetX ? sourceX + 1 : targetX + 1,  //source, target 중 더 위에 있는 것의 바로 아래 위치
      sourceY,
    ]);
  } else { // 대각선일 때
    validPartitions.push([sourceX, targetY]);
    validPartitions.push([targetX, sourceY]);
  }
  return validPartitions.every(([validX, validY]) =>  // 거리두기 가능한 파티션 위치가 실제 파티션 위치와 모두 같으면
    partitions.some(([x, y]) => x === validX && y === validY)
  );
};

const isGoodDistance = (positions, partitions) => {
  for (let i = 0; i < positions.length; i++) {
    for (let j = i + 1; j < positions.length; j++) {
      const distance = calculateDistance(positions[i], positions[j]);  // 응시자들 사이의 거리 계산
      if (distance <= 2) {  // 응시자들 사이의 거리가 맨해튼 거리보다 작을 경우
        if (!existPartitionNearBy(positions[i], positions[j], partitions)) {
          return false;
        }
      }
    }
  }
  return true;
};

const calculateDistance = (source, target) => {
  const [sourceX, sourceY] = source;
  const [targetX, targetY] = target;
  return Math.abs(sourceX - targetX) + Math.abs(sourceY - targetY);
};

const extract = (room) => {
  const partitions = [];
  const positions = [];
  room.forEach((row, x) => {
    for (let y = 0; y < row.length; y++) {
      const target = row[y];
      switch (target) {
        case "P":
          positions.push([x, y]); // 응시자 위치(x,y) 저장
          break;
        case "X":
          partitions.push([x, y]); // 파티션 위치(x,y) 저장
          break;
      }
    }
  });
  return { partitions, positions };
};

function solution(places) {
  return places.map((place) => {
    const { partitions, positions } = extract(place);  // 방 구조 중에서 응시자, 파티션 위치만 뽑아내기
    return isGoodDistance(positions, partitions) ? 1 : 0;
  });
}
```
