## 📝 기능개발

[문제_기능개발](https://programmers.co.kr/learn/courses/30/lessons/42586)

### 📍 코드(javascript)

**접근방법**
1. 기능 개발에 걸리는 시간을 각각 계산
2. 기준을 처음 배포하는 기간으로 설정, 이보다 짧은 개발 기간을 가진 프로젝트 수만큼 count
3. 기준보다 개발 기간이 길다면 더 긴 개발 기간으로 기준을 설정, 다음 배포할 수 있는 프로젝트 수(`answer`배열의 다음 인덱스)에 count

```javascript
function solution(progresses, speeds) {
    var answer = [0];
    let days = [];
    
    progresses.forEach((val, i) => {
        days.push(Math.ceil((100 - val) / speeds[i]))  // 1
    });
    
    days = days.reverse();
    
    let release = days[days.length - 1];
    for(let i = days.length - 1, j = 0; i >= 0; i--) {
        // 2
        if(release >= days[i]) {
            answer[j] += 1;
        }
        // 3
        else {
            release = days[i];
            answer[++j] = 1;
        }
        days.pop();
    }
    
    return answer;
}
}
```


---

## 📝 프린터

[문제_프린터](https://programmers.co.kr/learn/courses/30/lessons/42587)

### 📍 코드(javascript)

**접근방법**
1. 현재 위치와 우선순위를 한쌍으로 하는 객체를 생성
2. 프린터의 조건에 따라 제일 처음의 문서보다 더 높은 우선순위를 가진 문서가 대기열에 있는지 확인
    - 현재 문서가 인쇄 가능한지, 아닌지 판단
3. 더 높은 우선순위가 있다면(현재 문서 인쇄 불가능) 대기열 맨 뒤로 추가
4. 더 높은 우선순위가 없다면(현재 문서 인쇄 가능) 프린트 횟수 추가
5. 현재 문서의 위치가 내가 인쇄하려고 하는 문서위 위치(`location`)과 같으면 문서 대기열 순서를 더 알아볼 필요가 없기 때문에 stop

```javascript
function solution(priorities, location) {
    var answer = 0;
    let list = priorities.map((val, i) => ({location : i ,  priority : val,}));   // 1
    let isTargetPrinted = false;
    
    while(!isTargetPrinted) {
    
        // 2
        let j = list.shift();
        let hasHighPriority = list.some((ele) => ele.priority > j.priority);

        //3
        if(hasHighPriority) {
            list.push(j); 
        }
        //4
        else {
            answer++;
            isTargetPrinted = (j.location === location) ? true : false;   // 5
        }
    }   
    
    return answer;
}
```


### 참고
- [Array.prototype.some()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/some)
- [Array.prototype.shift()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/shift)
