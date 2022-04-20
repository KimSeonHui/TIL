## 📝 점프와 순간이동

[점프와 순간이동](https://programmers.co.kr/learn/courses/30/lessons/12980)

### 📍 내 풀이(javascript)
`Bit`

```javascript
function solution(n)
{
    let battaryNum = 1;  // 점프 한 번해서 1에서 시작하는 걸로 계산

    while(Math.floor(n/2) > 0) {
        battaryNum += n % 2;  // 위치(n)이 홀수 일때만 점프를 한 번씩 뛰어야 하기 때문에 나머지를 더해줌
        n = Math.floor(n/2);  // 순간이동 전 위치(n/2)까지에서 점프를 뛴 적있는지 확인
    }
    
    return battaryNum;
}

```

### 📍 다른 사람 풀이(javascript)
```javascript
function solution(n)
{
    return n.toString(2).match(/1/g).length;  // 순간이동한다/안한다(=점프한다)라는 두가지 경우의 수 밖에 없기 때문에 이진법으로 변환이 가능        
                                              // 이진법으로 표현했을 때 1의 개수와 점프를 뛴 횟수가 동일 
}
```
