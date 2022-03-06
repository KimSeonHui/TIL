## 📝 평균 구하기
[문제_ 평균 구하기](https://programmers.co.kr/learn/courses/30/lessons/12944)

----
### 📍 코드(javascript)
**map() 사용**

```javascript
function solution(arr) {
    var answer = 0;
    arr.map((val) => answer += val)
    return answer / arr.length;
}
```

<br />

**reduce() 사용**
```javascript
 return arr.reduce((acc, cur) => acc + cur) / arr.length
```

----
## 📝 제일 작은 수 제거하기
[문제_제일 작은 수 제거하기](https://programmers.co.kr/learn/courses/30/lessons/12935)

---

### 📍 코드(javascript)
- `...(spread operator)arr 사용` : `arr`의 전체 요소를 펼침     
- `Math.min()` : 가장 작은 값 찾기
- `indexOf()` : 해당하는 값의 인덱스 찾기

```javascript
function solution(arr) {
    var answer = [];
    if(arr.length === 1) {
        return [-1];
    }

    let index = arr.indexOf(Math.min(...arr))
    arr.map((val, i) => i !== index ? answer.push(val) : null )
    
    return answer;
}
```

----

## 📝 실패율

[문제_실패율](https://programmers.co.kr/learn/courses/30/lessons/42889#qna)

> 실패율은 다음과 같이 정의한다.     
`스테이지에 도달했으나 아직 클리어하지 못한 플레이어의 수 / 스테이지에 도달한 플레이어 수`    
전체 스테이지의 개수 N, 게임을 이용하는 사용자가 현재 멈춰있는 스테이지의 번호가 담긴 배열 stages가 매개변수로 주어질 때,      
실패율이 높은 스테이지부터 내림차순으로 스테이지의 번호가 담겨있는 배열을 return 하도록 solution 함수를 완성하라.

### 📍 코드(javascript)

**접근 방법**
- `각 스테이지 총 도전자의 수` = 해당 스테이지 번호보다 같거나 큰 수의 갯수
- `각 스테이지 통과 못한 도전자의 수` = 해당 스테이지 번호와 같은 수의 갯수
- 따라서 `filter()`를 통해 각각 총 도전자의 수와 통과하지 못한 도전자의 수를 찾아 실패율을 구함
- 실패율과 스테이지 번호를 배열에 넣고 내림차순으로 정렬
- 그 후 내림차순에 따라 스테이지 번호만 배열에 추가

```javascript
function solution(N, stages) {
    var answer = [];
    const fail =[];
    
    for(let i = 1; i <= N; i++) {
        let allPlayer = stages.filter((ele) => ele >= i).length;
        let notClear = stages.filter((ele) => ele === i).length;
        fail.push([notClear / allPlayer, i]);
    }
    
    fail.sort((a, b) => b[0] - a[0]);   
    fail.forEach((val) => answer.push(val[1]))
    
    return answer;
}
```


<br />
<br />

**접근 방법**
- `각 스테이지 총 도전자 수` = 전체 도전자 수 - 이전 스테이지 통과 못한 도전자 수
    - 1번 스테이지일 경우 : `stages`의 원소가 1보다 큰 자연수이므로 `stages.length`가 1번 스테이지 총 도전자 수
    - 그외 스테이지일 경우 : 전체 도전자 수(`allPlayer`)에 이전 스테이지 통과 못한 도전자 수(`prevStageNotClear`)를 빼줌
- `각 스테이지 통과 못한 도전자의 수` = 해당 스테이지 번호와 같은 수의 갯수

```javascript
function solution(N, stages) {
    var answer = [];
    let prevStageNotClear = 0;
    let currentNotClear = 0;
    let allPlayer = stages.length;
    let fail = [];
    
    for(let i = 1; i <= N; i++) {
        currentNotClear = 0;
        for(let j = 0; j < stages.length; j++) {
            if(stages[j] === i) {
                currentNotClear++;
            }
        }
        if(i !== 1) {
            allPlayer -= prevStageNotClear;
        }
        fail.push([currentNotClear / allPlayer, i]);
        prevStageNotClear = currentNotClear;
    }
    
    fail.sort((a, b) => b[0] - a[0]);
    fail.forEach((val) => answer.push(val[1]))
    
    return answer;
}
```


### 정리
- `filter()`를 사용한 방법이 코드 수도 짧고 보기에 간결하지만 이중 for문 방법보다 시간이 오래 걸림
- 가장 크게 차이나는 것은 약 40배까지 시간이 차이가 났음


----
## 📝 음양 더하기

[문제_음양 더하기](https://programmers.co.kr/learn/courses/30/lessons/76501)


### 📍 코드(javascript)

**접근방법**
- 부호가 `true` , `false`에 따라 숫자 더하기 빼기

```javascript
function solution(absolutes, signs) {
    var answer = 0;
    
    signs.forEach((val, i) => {
        if(val) {
            answer += absolutes[i];
        }
        else {
            answer -= absolutes[i];
        }
    })
     
    return answer;
}
```

<br />

**접근방법**
- `reduce()` 사용
- 부호가 `true`, `false`에 따라 `*1` , `* -1`로 부호 구분

```javascript
function solution(absolutes, signs) {
   return absolutes.reduce((acc, cur, i) => acc += signs[i] ? cur * 1 : cur * -1, 0)
}
```
----
## 📝 크레인 인형뽑기

[문제_크레인 인형뽑기](https://programmers.co.kr/learn/courses/30/lessons/64061)

### 📍 코드(javascript)

**접근방법**
- `moves`의 배열의 값을 통해 인형을 뽑을 `column` 위치를 정하게 됨
- 이중 for문을 통해 `moves`의 배열의 값을 통해 정해진 `column` 위치에서 값이 0이 아닌 row를 찾음 - `인형을 뽑는 위치!`
- 현재 뽑은 값과 이전에 마지막으로 뽑았던 값이 같으면(같은 인형이면) 마지막으로 뽑았던 값 삭제, 사라진 인형이 2개이기 때문에 숫자 카운트
-  현재 뽑은 값과 이전에 마지막으로 뽑았던 값이 다르면(다른 인형이면) 현재 뽑은 값을 결과에 추가
-  뽑은 인형은 사라지기 때문에 값을 0으로 바꿔줌
-  한 번 인형을 뽑았으면 크레인을 움직여야 하기 때문에 같은 컬럼에서 계속 뽑지 않도록 `break`로 for문 탈출 

```javascript
function solution(board, moves) {
    var answer = 0;
    const result = [];
    
    for(let i = 0; i < moves.length; i++) {
        for(let j = 0; j < board.length; j++){
            if(board[j][moves[i] - 1] !== 0) { 
                if(result[result.length - 1] === board[j][moves[i] - 1]) {
                    result.pop();
                    answer += 2;
                }
                else {
                    result.push(board[j][moves[i] - 1]);
                }
                
                board[j][moves[i] - 1] = 0;
                break;
            }
        }
    }

    return answer;
}

```

----
## 📝 로또의 최고 순위와 최저 순위

[문제_로또의 최고 순위와 최저 순위](https://programmers.co.kr/learn/courses/30/lessons/77484)

**접근방법**
- 최고 순위와 최저 순위는 알아볼 수 없는 번호(`0`)의 수에 따라 나눠짐
- `최저 순위` = 당첨 번호와 일치하는 번호의 수 + 0 // 알아볼 수 없는 번호(`0`)가 모두 틀릴 때
- `최고 순위` = 당첨 번호와 일치하는 번호의 수 + `0`의 수 // 알아볼 수 없는 번호(`0`)가 모두 맞을 때

```javascript
function solution(lottos, win_nums) {
    var answer = [];
    let rank = [6,6,5,4,3,2,1];
    let count = 0;
    let zero = 0;
    
    lottos.forEach((val, i) => {
        if(win_nums.includes(val)) {
            count++;
        }
        if(val === 0) {
            zero++;
        }
    })
    
    answer.push(rank[count + zero]);
    answer.push(rank[count])

    return answer;
}

```

