## 📝 체육복

[문제_체육복](https://programmers.co.kr/learn/courses/30/lessons/42862)

> 점심시간에 도둑이 들어, 일부 학생이 체육복을 도난당했습니다. 다행히 여벌 체육복이 있는 학생이 이들에게 체육복을 빌려주려 합니다.     
> 학생들의 번호는 체격 순으로 매겨져 있어, 바로 앞번호의 학생이나 바로 뒷번호의 학생에게만 체육복을 빌려줄 수 있습니다.    
> 예를 들어, 4번 학생은 3번 학생이나 5번 학생에게만 체육복을 빌려줄 수 있습니다. 체육복이 없으면 수업을 들을 수 없기 때문에 체육복을 적절히 빌려 최대한 많은 학생이 체육수업을 들어야 합니다.
>
>전체 학생의 수 n, 체육복을 도난당한 학생들의 번호가 담긴 배열 lost, 여벌의 체육복을 가져온 학생들의 번호가     
>담긴 배열 reserve가 매개변수로 주어질 때, 체육수업을 들을 수 있는 학생의 최댓값을 return 하도록 solution 함수를 작성해주세요.

<br />

### 📍 코드(javascript)

**접근방법**
- 여벌을 갖고온 학생이 도난 당했을 수도 있기 때문에 `lost`, `reserve`에서 각각 서로 겹치는 원소를 제거
- 체육복은 앞번호 혹은 뒷번호에게만 빌려줄 수 있기 때문에 `여분 있는 학생의 번호 - 도난 당한 학생의 번호`의 절댓값이 1일 때 빌려주는게 가능
- 한번 빌려준 학생은 다시 빌려주지 못하기 때문에 여분 배열에서 삭제, `count` 증가
- 빌려준 수(`count`)가 도난 당한 수(`lost.length`)보다 작으면 체육복을 빌리지 못한 학생이 생기기 때문에 `전체 학생 수 - 도난당한 학생수 + 다시 빌린 학생`으로 구함
- 빌려준 수('count'`가 도난 당한수 ('lost.length')보다 크면 도난 당한 학생 모두 체육복을 빌렸기 때문에 전체 학생 모두 수업을 들을 수 있음

```javascript
function solution(n, lost, reserve) {
    let count = 0;
    let realLost = lost.filter((ele) => !reserve.includes(ele)).sort();
    let realReserve = reserve.filter((ele) => !lost.includes(ele)).sort();
    
    for(let i = 0; i < realLost.length; i++) {
        for(let j = 0; j < realReserve.length; j++) {
            if(Math.abs(realReserve[j] - realLost[i]) === 1) {
                realReserve.splice(j, 1);
                count++;
                break;
            }
        }
    }
    
    return lost.length > count ? n - realLost.length + count : n
}
```

<br />

### 참고
- [탐욕법(greedy)](https://velog.io/@contea95/%ED%83%90%EC%9A%95%EB%B2%95%EA%B7%B8%EB%A6%AC%EB%94%94-%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98)
