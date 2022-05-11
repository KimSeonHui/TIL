## 📝 완주하지 못한 선수

[문제_완주하지 못한 선수](https://programmers.co.kr/learn/courses/30/lessons/42576)

### 📍 코드(javascript)

**접근방법**
- `participant`, `completion`를 정렬한 뒤 처음부터 하나하나 비교
- 완주하지 못한 한 명의 선수를 제외하면 `participant`, `completion` 각각을 정렬했기 때문에 같은 인덱스일 때 같은 값이 나와야 함
- 같은 인덱스인데 다른 값이 나온다면 완주하지 못한 선수를 가리킴

```javascript
function solution(participant, completion) {
    var answer = '';    

    participant = participant.sort();
    completion = completion.sort();
    
    for(let i = 0; i < participant.length; i++) {
        if(participant[i] !== completion[i]) {
            answer = participant[i];
            break;
        }
    }
    return answer;
}
```
