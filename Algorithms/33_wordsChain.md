## 📝 영어 끝말잇기

[영어 끝말잇기](https://programmers.co.kr/learn/courses/30/lessons/12981#)

### 📍 코드(javascript)
`Array`  `String`

```javascript
function solution(n, words) {
    var answer = [0, 0];
    const say = [];  // 지금까지 말한 단어
    
    for(let i = 0 ; i < words.length; i++) {        
        if(i === 0) {  
            say.push(words[i]);
        }
        else {
            const prev = words[i-1];
            const current = words[i];
            if(words[i].length === 1) {  // 한 글자 단어는 인정 x -> 탈락
                return [i%n + 1, Math.floor(i/n) + 1];
            }
            // 이전 단어의 마지막 단어로 시작 안 함 || 말한 단어 중에서 말하면 탈락
            if(current.charAt(0) !== prev.charAt(prev.length - 1) || say.includes(words[i]) ) {
                return [i%n + 1, Math.floor(i/n) + 1];
            }
            //그 외 통과
            else {
                say.push(words[i]);
            }
        }
        
    }

    return answer;
}
```
