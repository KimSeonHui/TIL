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

----
## 📝 폰켓몬

[문제_폰켓몬](https://programmers.co.kr/learn/courses/30/lessons/1845)

### 📍 코드(javascript)

**접근방법**
- 최대로 가질 수 있는 폰켓몬의 수 안에서 폰켓몬을 서로 다른 종류로 가장 많이 가지고 갈 수 있는 방법을 찾는 것이기 때문에 모든 종류를 찾지 않아도
  서로 다른 종류의 폰켓몬을 최대로 가질 수 있는 수만큼 가지면 가장 많이 가지고 갈 수 있는 방법이 된다. 
  
**Array.includes() 사용**
-  `includes()` : 같은 종류의 폰켓몬이 있는지 확인
- `최대로 가질 수 있는 폰켓몬의 수` = `nums.length / 2`이기 때문에 최대로 가질 수 있는 폰켓몬 수까지 서로 다른 폰켓몬을 `poketmon`에 추가

```javascript
function solution(nums) {
    let poketmon = [];
    
    for(let i = 0; i < nums.length; i++) {
        if(!poketmon.includes(nums[i]) && poketmon.length < nums.length/2) {
            poketmon.push(nums[i])
        }
    }

    return poketmon.length;
}
```

<br />
<br />

**Set() 사용**
- `Set()`으로 `nums`의 중복 모두 제거

```javascript
function solution(nums) {
    let poketmon = [...new Set(nums)];
    let max = nums.length / 2;

    return max < poketmon.length ? max : poketmon.length;
}
```
