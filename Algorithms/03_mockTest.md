## 완전탐색📝
> 모든 경우의 수를 전부 찾아서 답을 찾는 알고리즘      
> [문제_모의고사](https://programmers.co.kr/learn/courses/30/lessons/42840?language=java) 

### 📍풀이
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
        
        int max = scores[0];
        for(int i = 1; i < scores.length; i++) {
            if(max < scores[i]){
                max = scores[i];
            }
        }
        
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
