## 📝 숫자 문자열과 영단어

[문제_숫자 문자열과 영단어]()

### 📍 코드(javascript)

**정규식 사용**
- `정규식, 숫자`쌍의 배열을 생성
- 정규식을 통해 숫자에 해당하는 영단어와 매치되는 부분을 찾아 숫자로 바꾸기

```javascript
function solution(s) {
    const regExp = [[/zero/ig, 0], [/one/ig, 1],  [/two/ig, 2] , [/three/ig, 3] , [/four/ig, 4], 
                    [/five/ig, 5] , [/six/ig, 6],  [/seven/ig, 7] , [/eight/ig, 8],  [/nine/ig, 9] ];  
    
    regExp.forEach((val) => {
        s = s.replace(val[0], val[1])
    })
    
    return parseInt(s);
}
```

<br />

**split(), join() 사용**
- 해당 영단어로 문자열을 분리
- 영단어에 매치되는 숫자를 `operator`로 `join()`을 통해 분리된 문자열을 붙임
- 영단어가 숫자로 바꿔진 문자열이 됨 

```javascript
function solution(s) {   
    let numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
    let answer = s;
    
    numbers.forEach((val, i) => {
        let arr = answer.split(numbers[i]);
        answer = arr.join(i);
    })
    
   return parseInt(answer)
}
```
