## 완전탐색📝
> 모든 경우의 수를 전부 찾아서 답을 찾는 알고리즘      
> [문제_모의고사](https://programmers.co.kr/learn/courses/30/lessons/42840?language=java) 

### 📍첫 번째 풀이
``` java
class Solution {
    public int[] solution(int[] answers) {
        int answer[] = {};
        int[] p1 = {1,2,3,4,5};
        int[] p2 = {2,1,2,3,2,4,2,5};
        int[] p3 = {3,3,1,1,2,2,4,4,5,5};
        int[] scores = new int[3];
        int p1Score = 0;
        int p2Score = 0;
        int p3Score = 0;
        
        //
        int j = 0;
        for(int i = 0; i < answers.length; i++) {
            if(p1[j] == answers[i]){
                p1Score++;               
            }
            j++;
            if(j >= p1.length)
                j = 0;
        }
        scores[0] = p1Score;
        
        j = 0;
        for(int i = 0; i < answers.length; i++) {
            if(p2[j] == answers[i]){
                p2Score++;                
            }
            j++;
            if(j >= p2.length)
                j = 0;
        }
        scores[1] = p2Score;
        
        j = 0;
        for(int i = 0; i < answers.length; i++) {
            if(p3[j] == answers[i]){
                p3Score++;                
            }
            j++;
            if(j >= p3.length)
                j = 0;
        }
        scores[2] = p3Score;
        
        //최댓값 구하기
        int max = scores[0];
        for(int i = 1; i < scores.length; i++) {
            if(max < scores[i]){
                max = scores[i];
            }
        }
        
        //가장 점수 높은 사람 비교 & return
        if(max == p1Score && max == p2Score && max == p3Score) { 
            answer = new int[3];
            answer[0] = 1;
            answer[1] = 2;
            answer[2] = 3;
                
        }
        else if(max == p1Score && max == p2Score) {
            answer = new int[2];
            answer[0] = 1;
            answer[1] = 2;
        }
        else if(max == p1Score && max == p3Score) {
            answer = new int[2];
            answer[0] = 1;
            answer[1] = 3;
        }
        else if(max == p2Score && max == p3Score) {
            answer = new int[2];
            answer[0] = 2;
            answer[1] = 3;
        }
        else if(max == p1Score) {
            answer = new int[1];
            answer[0] = 1;
        }
        else if(max == p2Score) {
            answer = new int[1];
            answer[0] = 2;
        }
        else if(max == p3Score) {
            answer = new int[1];
            answer[0] = 3;
        }                                   
        return answer;
    }
}
```

### 📍두 번째 풀이
- #### 점수 채점 부분 코드를 줄일 수 없을까? 
    + i 하나의 변수로 비교 할 수는 없을까?
- #### 가장 점수 높은 사람 비교 & return 부분을 줄일 수 없을까?
    + ArrayList로 한 번 해보자!

```java
import java.util.ArrayList;

class Solution {
    public int[] solution(int[] answers) {
        int answer[] = {};
        int[] p1 = {1,2,3,4,5};
        int[] p2 = {2,1,2,3,2,4,2,5};
        int[] p3 = {3,3,1,1,2,2,4,4,5,5};
        int[] scores = new int[3];
        int p1Score = 0;
        int p2Score = 0;
        int p3Score = 0;
        ArrayList<Integer> highScore = new ArrayList<Integer>();
        
        //점수 채점
        for(int i = 0; i < answers.length; i++) {
            if(p1[i % 5] == answers[i]){
                p1Score++;               
            }            
        }
        scores[0] = p1Score;
        
       
        for(int i = 0; i < answers.length; i++) {
            if(p2[i % 8] == answers[i]){
                p2Score++;                
            }           
        }
        scores[1] = p2Score;        
        
        for(int i = 0; i < answers.length; i++) {
            if(p3[i % 10] == answers[i]){
                p3Score++;                
            }
        }
        scores[2] = p3Score;
        
        //최댓값 구함
        int max = scores[0];
        for(int i = 1; i < scores.length; i++) {
            if(max < scores[i]){
                max = scores[i];
            }
        }
        
        //가장 점수가 높은 사람 비교 & return
        for(int i = 0; i < scores.length; i++) {
        	if(max == scores[i]) {
        		highScore.add(i+1);
        	}
        }
        answer = new int[highScore.size()];
        int i = 0;
        for(int temp : highScore) {
        	answer[i++] = temp;
        }
        
        return answer;
    }
}
```

---
### 📍 코드(javascript)

```javascript
function solution(answers) {
    var answer = [];
    const person1 = [1,2,3,4,5];
    const person2 = [2,1,2,3,2,4,2,5];
    const person3 = [3,3,1,1,2,2,4,4,5,5];
    const scores = [0, 0, 0];
    
    answers.forEach((val, i) => {
        if(val === person1[i % person1.length]) {
            scores[0]++;
        }
        if(val === person2[i % person2.length]) {
            scores[1]++;
        }
        if(val === person3[i % person3.length]) {
            scores[2]++;
        }
    });
    
    
    const max = Math.max(scores[0], scores[1], scores[2]);
    scores.forEach((val, i) => {
       if(val === max) {
            answer.push(i+1);
        }
    })
    
    return answer.sort();
}
```
