## 📝가운데 글자 가져오기
> [문제_가운데 글자 가져오기](https://programmers.co.kr/learn/courses/30/lessons/12903)

### 📍첫 번째 풀이(java)
**홀수 짝수 확인**
- 홀수, 짝수에 따라 가져오는 글자 수가 달라지기 때문에 확인 후
- String에서 원하는 문자를 Char[]로 저장
- Char[]을 다시 String으로 변환
```java
import java.lang.*;

class Solution {
    public String solution(String s) {
        String answer = "";
        
        if(s.length() % 2 != 0) {
            char[] tmp = {s.charAt(s.length() / 2)};
            answer = String.valueOf(tmp);
        }
        else {
            char[] tmp = {s.charAt(s.length() / 2 - 1), s.charAt(s.length() / 2)};
            answer = String.valueOf(tmp);
        }
        return answer;
    }
}
```

🙋‍♀️```charAt(int Index)```
- String 변수에서 명시된 Index에 있는 char 변수를 return
- Index는 0부터 시작, 범위 : 0 ~ length() - 1까지

---
### 📍두 번째 풀이(java)
```substring(int beginIndex, int endIndex)``` 사용
```java
class Solution {
    public String solution(String s) {
        String answer = "";
        
        if(s.length() % 2 != 0) {
            answer = s.substring(s.length() / 2, s.length() / 2 + 1);
        }
        else {
            answer = s.substring(s.length() / 2 - 1, s.length() / 2 + 1);
        }
        
        return answer;
    }
}
```

🙋‍♀️```substring(int beginIndex, int endIndex)```
- 주어진 String 변수의 일부분을 새로운 String 변수로 return
- beginIndex부터 endIndex - 1 까지를 return
   - beginIndex - 시작하는 Index, 포함 o
     endIndex - 끝나는 Index, 포함 x
- ex) "smiles".substring(1, 5) returns "mile"

🙋‍♀️```substring(int beginIndex)```
- 주어진 String 변수의 일부분을 새로운 String 변수로 return
- beginIndex부터 끝까지 return
   - beginIndex - 시작하는 Index, 포함 o
- ex) "unhappy".substring(2) returns "happy"

---
### 📍 코드(javascript)
```javascript
function solution(s) {
    return (s.length % 2 === 0 ? s[s.length/2 - 1] + s[s.length/2] : s[Math.floor(s.length / 2)]);
}
```


---
## 📝문자열 다루기 기본
>[문제_문자열 다루기 기본](https://programmers.co.kr/learn/courses/30/lessons/12918)

### 📍첫 번째 풀이(java)
**비교 데이터(check) 생성해서 비교**
- 주어진 문자열 s와 check를 비교해서 알파벳 포함 유무 확인

```java
class Solution {
    public boolean solution(String s) {
        boolean answer = false;
        String check = "abcdefghijklmnopqrstuwxyz";
        
        if(s.length() == 4 || s.length() == 6) {
            for(int i = 0; i < s.length(); i++) {
                for(int j = 0; j < check.length(); j++) {
                    if(s.charAt(i) == check.charAt(j)) {
                        answer = false;
                        return answer;
                    }
                }
            }                                   
            answer = true;
             return answer;
        }
        else {
            answer = false;
             return answer;
        }
        

    }
}
```

### 📍두 번째 풀이(java)

**char 변수 값 비교**
- char 변수는 내부적으로 유니코드로 저장되기 때문에 정수값으로 저장됨
- char 변수의 비교(저장된 정수값(유니코드) 값의 비교)를 통해 숫자 외 다른 것이 포함되어 있는지를 확인

```java
class Solution {
    public boolean solution(String s) {
        
        if(s.length() == 4 || s.length() == 6) {
            for(int i = 0 ; i < s.length(); i++) {
                if(s.charAt(i) < '0' || s.charAt(i) > '9') {
                    return false;
                }
            }
            return true;
        }
        else {
            return false;
        }
    }
}
```
---
### 더 공부할 것
문제_문자열 다루기 기본에서 숫자만 들어있는지 확인 하는 부분에서 다른 사람들이 풀이에 사용한 함수
- ```parseInt(String s)``` : Integer
- ```matches(String regex)``` : String


---
### 📍 코드(javascript)
**정규표현식 풀이**

```javascript
function solution(s) {
    let regExp = /[^0-9]/g;
    return !regExp.test(s) && (s.length === 4 || s.length === 6);
}
```

### 더 공부할 것
정규 표현식... 계속 봐도.. 어렵다..
표현식에 길이까지 확인하는걸 넣을 수 있을 것 같은데.. 조금 더 공부해봐야겠다..


---
## 📝 핸드폰 번호 가리기
[문제_핸드폰 번호 가리기](https://programmers.co.kr/learn/courses/30/lessons/12948)

---

### 📍 코드(javascript)
- `repeat()` 통해 `*` 반복
- `phone_number`의 뒤에서 4글자를 붙어줌

```javascript
function solution(phone_number) {
    var answer = '';
    let p = phone_number;
    answer = '*'.repeat(p.length - 4) + p.slice(p.length -4);
    return answer;
}
```

----
## 📝 이상한 문자 만들기
[문제_이상한 문자 만들기](https://programmers.co.kr/learn/courses/30/lessons/12930#)

----

### 📍 코드(javascript)

**while()사용**
- 모든 문자를 하나씩 분리: `split('')`
- `모든 문자를 순회하는 인덱스(j)`, `각 단어의 글자의 짝/홀 판단하는 인덱스(i)`로 설정
- 글자의 인덱스가 짝/홀인지에 따라 대문자/소문자로 변환
- 현재값이 공백이면 단어가 바뀌었기 때문에 인덱스를 `0`으로 

```javascript
function solution(s) {
    let answer = '';
    let words = s.split('');
    let i = 0, j = 0;
    
    while(j < words.length) {
        answer += (i % 2 === 0) ? words[j].toUpperCase() : words[j].toLowerCase();
        i++;
        
        if(words[j] === ' ')
            i = 0;
        
        j++;
    }
    
    return answer;   
}

```
<br />


**reduce()사용**
- 모든 문자를 하나씩 분리: `split('')`
- 글자의 인덱스(i)가 짝/홀인지에 따라 대문자/소문자로 변환
- 현재값이 공백이면 단어가 바뀌었기 때문에 인덱스를 `0`으로 

```javascript
function solution(s) {
    let answer = '';
    let words = s.split('');
    
    let i = 0;
    answer = words.reduce((acc, cur) => {
        acc += (i % 2 === 0) ? cur.toUpperCase() : cur.toLowerCase();
        i++;
        
        if(cur === ' ') 
            i = 0;
        
        return acc;
    }, '');
    
    return answer;
}

```

----
## 📝 시저 암호
[문제_시저 암호](https://programmers.co.kr/learn/courses/30/lessons/12926)

----

<br/>

### 📍 코드(javascript)

`(i + n > 25 ) ? (i + n) - sample.length : i+n`
- 문자열의 인덱스(i) + 이동할 거리(n)을 더했을 때 `sample`의 길이를 벗어나는 경우가 생기기 때문에 이를 처리하는 로직

<br/>

```javascript
function solution(s, n) {
    var answer = '';
    let sample = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'];
 //let sample = 'abcdefghijklmnopqrstuvwxyz'.split('');  //배열로 푸는 것이 빠름

    let str = s.split('');
    let i = 0;
    
    str.forEach((val) => {
        if(val === ' '){
            answer += val;   
        }
        else {
            i = sample.indexOf(val.toLowerCase());
            i = (i + n > 25 ) ? (i + n) - sample.length : i+n;
            
            if(val === val.toUpperCase()) {
                answer += sample[i].toUpperCase();
            }
            else {
                answer += sample[i];
            }
        }
    })
    return answer;
}
```
