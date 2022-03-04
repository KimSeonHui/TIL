## 📝 소수 만들기

[문제_소수 만들기](https://programmers.co.kr/learn/courses/30/lessons/12977)

### 📍 코드(javascript)

**접근방법**
- 3중 for문으로 `nums` 배열에서 3가지 수를 뽑아 더해서 만들 수 있는 수 모든 경우의 수 만들기
- 더해서 만든 `sum`이 소수인지 확인 

```javascript
function solution(nums) {
    let answer = 0;
    let sum = 0;
    
    for(let i = 0; i < nums.length; i++) {
        for(let j = i + 1; j < nums.length; j++) {
            for(let k = j + 1; k < nums.length; k++) {
                sum = nums[i] + nums[j] + nums[k];
                if(isPrime(sum)){
                    answer++;
                }       
            }
        }
    }
    
    return answer;
}

function isPrime(num) {
    for(let i = 2; i <= Math.sqrt(num); i++) {
        if(num % i === 0) {
            return false;
        }
    }
    return true;
}
```
