## 📝 약수의 갯수와 덧셈

[문제_약수의 갯수와 덧셈](https://programmers.co.kr/learn/courses/30/lessons/77884)

> 두 정수 `left`와 `righ`t가 매개변수로 주어집니다. `left`부터 `right`까지의 모든 수들 중에서,     
약수의 개수가 짝수인 수는 더하고, 약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.


### 📍 코드(javascript)

**접근 방법**
- 이중 for문을 통해 `left`부터 `right`까지 수의 약수의 갯수를 찾음
- 약수의 갯수가 짝수이면 그 수를 더하고, 약수의 갯수가 홀수이면 그 수를 뺌

```javascript
function solution(left, right) {
    var answer = 0;

    for(let i = left; i <= right; i++) {
        let count = 0;
        for(let j = 1; j <= i; j++) {
            if(i % j === 0) {
                count++;
            }
        }
        if(count % 2 === 0) {
            answer += i;
        }
        else {
            answer -= i;
        }
    }
    return answer;
}
```
