## 📝 정수 내림차순으로 배치하기
[문제_정수 내림차수능로 배치하기](https://programmers.co.kr/learn/courses/30/lessons/12933)

---

### 📍 코드(javascript)

**숫자 풀이**
```javscript
function solution(n) {    
    let arr = [];
    do {
        arr.push(n % 10);
        n = Math.floor(n / 10);
    } while(n > 0)
        
    arr.sort((a, b) =>  b - a);
    return Number(arr.join(''));
}
```

<br />

**문자 풀이**
```javascript
function solution(n) {
    var answer = '';
    let string = [];
    
    for(let i = 0; i < String(n).length; i++) {
        string.push(String(n)[i])
    }

    string.sort((a, b) => {
        return b - a;
    })

    string.forEach((val) => answer += val);
   
    return Number(answer);
}
```

----

<br />
<br />

## 📝 자연수 뒤집어 배열로 만들기
[문제_자연수 뒤집어 배열로 만들기](https://programmers.co.kr/learn/courses/30/lessons/12932)

---
### 코드(javascript)
**문자열 풀이**

```javascript
function solution(n) {
    let answer = [];
    let string = String(n);

    for(let i = string.length-1; i >= 0; i--) {
        answer.push(Number(string[i]));    
    }
    
    return answer;
}
```
<br />

**숫자 풀이**
```javascript
function solution(n) {
    let arr = [];
    do {
        arr.push(n % 10);
        n = Math.floor(n / 10);
    } while(n > 0);
    return arr;
}
```

----

<br /><br />


## 📝 자릿수 더하기
[문제_자릿수 더하기](https://programmers.co.kr/learn/courses/30/lessons/12931)

---

### 📍 코드(javascript)
**숫자 풀이**

```javascript
function solution(n)
{
    let answer = 0;
    
    do {
        answer += n % 10;
        n = Math.floor(n / 10);
    } while(n > 0);
    
   return answer;  
}
```
<br />

**문자 풀이**

- `split([separator])` : 문자열을 `separator`기준으로 끊은 문자열을 반환
- `reduce()` : 배열의 요소를 축약해서 하나의 값으로 생성
- `parseInt(string)` : 문자열을 정수로 반환

```javascript
function solution(n)
{
    return (n + '').split('').reduce((acc, val) => acc + parseInt(val), 0); 
}
```
