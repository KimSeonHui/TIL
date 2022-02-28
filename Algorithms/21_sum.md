## 📝 두 개 뽑아서 더하기

[문제_두 개 뽑아서 더하기](https://programmers.co.kr/learn/courses/30/lessons/68644)

> 정수 배열 numbers가 주어집니다. numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서    
> 만들 수 있는 모든 수를 배열에 오름차순으로 담아 return 하도록 solution 함수를 완성해주세요.


### 📍 코드(javascript)
**접근 방법**
- 중복되지 않게 저장하는 `Set()` 활용해 `Set` 안에 더한 값이 없으면 추가

```javascript
function solution(numbers) {
    numbers = numbers.sort();
    const set = new Set();
    const answer = [];

    
    for(let i = 0; i < numbers.length; i++) {
        for(let j = i + 1; j < numbers.length; j++) {
            if(!set.has(numbers[i] + numbers[j])) {
                set.add(numbers[i] + numbers[j])
            }
        }
    }
   
    for(let item of set) {
        answer.push(item);
    }

    return answer.sort((a , b) => a- b);
}
```
