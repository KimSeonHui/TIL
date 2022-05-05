## 📝 괄호 변환

[괄호 변환](https://programmers.co.kr/learn/courses/30/lessons/60058)

### 📍 내 풀이(javascript)
`String` `recursive`

```javascript
function solution(p) {
    if(p === '') return '';
    
    let answer = '';
    let [u, v] = devide(p);  
    
    if(isCorrect(u)) {
        return u += solution(v);
    }
    else {
        answer += '(';
        answer += solution(v) + ')';
        
        for(let i = 0 ; i < u.length; i++) {
            if(i !== 0 && i !== u.length - 1) {
                if(u[i] === '(') answer += ')';
                else answer += '(';
            }
         }
    }   
    
    return answer;
}


function devide(p) {  // 문자열을 u , v로 나누는 로직
    const result = [];
    let leftCnt = 0;
    let rightCnt = 0;
    let u = '';
    let v = '';
    let i = 0;
    
   for(i; i < p.length; i++) {      
        if(p[i] === '(') leftCnt++;   
        else rightCnt++;
       
        u += p[i];
       
        if(leftCnt === rightCnt) break;  // 시작 괄호와 닫는 괄호의 갯수가 같으면 - 균형 잡힌 괄호라고 판단 -> 종료
   }
        
    v = p.slice(i + 1) === '' ? '' : p.slice(i + 1);
    result.push(u, v);
    
    
    return result;
}

function isCorrect(u) {  // 문자열이 올바른 괄호인지 확인하는 로직
    const reg = /\(\)/; // 올바른 괄호의 최소 단위 `()`를 패턴으로 사용
    
    while(reg.test(u)) {  // 패턴에 맞는게 있을 때까지 반복
        const match = u.match(reg);
        
        u = u.replace(reg, ''); //패턴에 맞으면 ''(빈 문자열)로 바꿈
    }
    
    return u === '' ? true : false;  // 전체가 빈 문자열이면 올바른 문자열 O, 아니면 올바른 문자열 x
}
```

### 📍 다른 사람 풀이(javascript)
```javascript
function reverse(str) {
  return str.slice(1, str.length - 1).split("").map((c) => (c === "(" ? ")" : "(")).join("");  // 괄호 방향 뒤집기
}

function solution(p) {
  if (p.length < 1) return "";

  let balance = 0;
  let pivot = 0;
  do { balance += p[pivot++] === "(" ? 1 : -1 } while (balance !== 0); // 균형 잡힌 괄호이면 loop 종료

  const u = p.slice(0, pivot); // 균형 잡힌 괄호 
  const v = solution(p.slice(pivot, p.length)); // 나머지 문자열을 1단계부터 수행한 결과 - u가 올바른 괄호이든 아니든 v에 대해 1단계부터 수행하는게 필요

  if (u[0] === "(" && u[u.length - 1] == ")") return u + v;  // u가 올바른 괄호일 때
  else return "(" + v + ")" + reverse(u); // u가 올바른 괄호가 아닐 때
}
```
