## 📝 3진법 뒤집기

[문제_3진법 뒤집기](https://programmers.co.kr/learn/courses/30/lessons/68935)
> 자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후,     
> 이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.

### 📍 코드(javascript)
**접근 방법**
- `toString(radix)` : `n`을 3진법으로 변환
  - `radix` : 변환하고자 하는 기수 (2 - 36)
- `...`(spread operator) : 배열, 문자열 같이 반복 가능한 문자의 요소를 펼쳐서 보여줌
- `...`를 통해 3진법으로 변환한 수를 배열에 넣고 `reverse()`를 통해 앞뒤 뒤집기
- 뒤집어진 3진법 수를 계산해 10진법으로 표현
  - `Math.pow()`
  - `parseInt()`


<br />

**Math.pow() 사용**
```javascript
function solution(n) {
   let answer = 0;
    n = [...n.toString(3)].reverse(); 

    
    for(let i = 0; i < n.length; i++) {
        answer += Math.pow(3, i) * n[n.length - 1 - i];
    }
   return answer;

}


```

<br />

**parseInt() 사용**
```javascript
function solution(n) {
    n = [...n.toString(3)].reverse();

    return Number.parseInt(n.join(''), 3);
    
}
```
