## 📝 가운데 글자 가져오기
[문제_가운데 글자 가져오기](https://programmers.co.kr/learn/courses/30/lessons/12903)

---
### 💡 접근방법
s의 길이가 홀수
- `s.length / 2`의 값을 내림한 위치의 글자 = 가운데 글자

s의 길이가 짝수
- `s.length / 2 - 1`, `s.length / 2` 위치의 글자 = 가운데 두글자

### 📍 코드(javascript)
```javascript
function solution(s) {

    return (s.length % 2 === 0 ? s[s.length/2 - 1] + s[s.length/2] : s[Math.floor(s.length / 2)]);
}
```
