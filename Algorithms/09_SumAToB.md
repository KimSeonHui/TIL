## 📝두 정수 사이의 합
> [문제_두 정수 사이의 합](https://programmers.co.kr/learn/courses/30/lessons/12912?language=java)

----
### 💡접근방법
- a > b 경우 / a < b 경우로 나눠서 접근 (두 수가 같을 경우는 둘 중 어느 케이스에 포함되도 상관 없음)
- a , b 둘 중 작은 수부터 큰 수까지 또는 큰 수부터 작은 수까지를 for문을 통해 돌면서 answer에 계속해서 더함

### 📍첫 번째 코드
if문을 통해 a,b 대소 비교
```java
class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        if(a <= b) {
            for(int i = a; i <= b; i++) {
                answer += i;
            }
        }
        else {
            for(int i = a; i >= b; i--) {
                answer += i;
            }
        }
        return answer;
    }
}
```

### 두 번째 코드
Math의 함수를 통해 a,b 대소 비교
``` java
class Solution {
    public long solution(int a, int b) {
        long answer = 0;        
        
        for(int i = Math.min(a,b); i <= Math.max(a,b); i++) {
            answer += i;
        }
        return answer;
    }
}
```
