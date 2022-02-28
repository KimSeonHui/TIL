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
