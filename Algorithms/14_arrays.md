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
