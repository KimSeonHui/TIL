## 📝 나머지가 1이 되는 수 찾기

[문제_나머지가 1이 되는 수 찾기](https://programmers.co.kr/learn/challenges)

> 자연수 n이 매개변수로 주어집니다. n을 x로 나눈 나머지가 1이 되도록 하는     
> 가장 작은 자연수 x를 return 하도록 solution 함수를 완성해주세요.     
> 답이 항상 존재함은 증명될 수 있습니다.

#

### 📍 코드(javascript)

**접근방법**
- `n`의 최소값은 3이기 때문에 나머지가 1이 될 수 있는 최소값은 2, 최대수는 `n-1`
- 이 구간만큼을 돌면서 나머지가 1이 되는 수가 있을 때 종료

```javascript
function solution(n) {
    var answer = 0;
    
    for(let i = 2; i <= n - 1; i++) {
        if(n % i === 1) {
            answer = i;
            break;
        }
    }
    
    return answer;
}
```
