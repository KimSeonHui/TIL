## 📝 스킬트리

[스킬트리](https://programmers.co.kr/learn/courses/30/lessons/49993#fn1)

### 📍 내 풀이(javascript)
`Array`  `String`

```javascript
function solution(skill, skill_trees) {
    var answer = 0;
    const regExp = new RegExp(`[^${skill}]`, 'g'); // 객체로 생성해 변수로 정규식 생성
    
    for(let tree of skill_trees) {
        const replace = tree.replace(regExp, '');  //`skill`에 있는 부분만 남기기
        let possible = true;
        
        for(let i = 0; i < replace.length; i++) {
            if(skill[i] !== replace[i]) {  //`skill`의 인덱스와 `replace`의 인덱스가 같지 않으면 스킬트리를 따르지 않음 -> 불가능한 스킬트리
                possible = false;   
                break;
            }
        }
        
        if(possible) {
            answer++;
        }
    }
    return answer;
}
```
