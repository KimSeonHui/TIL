## 📝예산    
> [문제_예산](https://programmers.co.kr/learn/courses/30/lessons/12982) 

---
### 📍접근방법
정해진 예산 안에서 가장 많은 부서를 지원할 수 있도록 해야하기 때문에 가장 적은 금액을 제출한 부서부터 많이 제출한 부서를 지원하도록 한다

**1. 배열 d를 오름차순으로 정렬하기**
- 정렬을 하는 것이 문제의 핵심은 아니라고 생각했기 때문에 java.util.Arrays를 import 후 Array.sort() 사용

**2. 정렬된 d의 첫 번째 요소부터 예산에서 지원하기**
- 배열 d를 첫 번째 요소부터 끝까지 for문으로 접근하기
- budget이 0보다 크고 for문으로 접근하는 d의 요소보다 크거나 같으면 (budget - d의 요소)를 실행
    - 지원했다는 의미로 d의 요소를 뺌
    - 뺀 후의 budget의 값은 남은 부서들을 지원해 줄 수 있는 남은 예산이라는 의미 
- 이 때 answer의 값을 하나씩 증가
- for문이 종료되면 answer의 값을 return

---
### 📍코드
``` java
import java.util.Arrays;

class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Arrays.sort(d);
        
        for(int i = 0; i < d.length; i++) {
            if(budget > 0 && budget >= d[i]) {
                budget -= d[i];
                answer++;
            }
        }
        
        
        return answer;
    }
}
```
---
