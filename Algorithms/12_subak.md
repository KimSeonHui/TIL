## 📝수박수박수박수
>[문제_수박수박수박수](https://programmers.co.kr/learn/courses/30/lessons/12922)

---
### 💡접근 방법
**🙋‍♀️첫 번째 방법**     
전체 '수박수박수박수...' 문자열에서 n까지의 문자열만 추출     
- n은 10,000이하인 자연수이므로 문자열 '수박수박수박수..'의 길이가 10,000이 되도록 문자열을 생성해야하는 문제 발생

**🙋‍♀️두 번째 방법**     
홀수, 짝수인지에 따라 "수"와 "박"이 들어가는 위치가 다름
- Index로 할 때 짝수는 "수" , 홀수는 "박"이기 때문에 for문을 돌면서 Index에 맞춰 String에 추가

---
### 📍첫 번째 코드
```java
class Solution {
    public String solution(int n) {
        String answer = "";
        
        for(int i = 0 ; i < n; i++) {
            
            if(i % 2 == 0) {
                answer += "수";
            }
            else {
                answer += "박";
            }            
        }
        
        return answer;
    }
}
```
---
### 📍두 번째 코드
``` java
class Solution {
    public String solution(int n) {
        String answer = "";
        
        for(int i = 0 ; i < n; i++) {
	   answer += i % 2 == 0 ? "수" : "박";
        }
        
        return answer;
    }
}
```

**🙋‍♀️코드분석**
- 첫 번째, 두 번째 코드 둘 다 알고리즘은 동일
- 그래서 문제를 푸는데 시간차이는 크게 없지만 두 번째 코드가 조금 더 빠름
- 시간은 처리 횟수와도 관계가 있기 때문에 answer에 추가하기 까지 처리해야하는 문장수가 많은 첫 번째 코드보다 한줄로 answer에 추가할 수 있는 두 번째 코드가 조금 더 빠른듯함.
