## 📝정렬    
> [문제_K번째수](https://programmers.co.kr/learn/courses/30/lessons/42748) 

---
### 📍접근방법
**1. i, j, k 값을 결정하기**
- i,j,k가 어떤 값을 가질지 결정하는 것은 commands 배열의 row가 몇 번째이냐에 따라 결정된다 
- commands 배열의 row는 commands의 길이와 같음을 이용해서 row에 따라 i,j,k 값을 결정하기

**2. i부터 j까지 뽑아낸 배열을 정렬하기**
- 배열의 첫 번째 요소를 min 값으로 설정
- 다음 요소와 비교하면서 min 값보다 작은 값이 있으면 min값의 위치와 비교한 값의 위치를 바꿈
- 오름차순으로 정렬

**3. 정렬된 배열에서 k번째 숫자 뽑아내기**
- 정렬된 배열에서 index가 [k-1]인 숫자를 answer배열에 넣기

---
### 📍코드
``` java
class Solution {
    public int[] solution(int[] array, int[][] commands) {
        int[] answer = new int[commands.length];
        
        for(int a = 0; a < commands.length; a++) {
            int i = commands[a][0];
            int j = commands[a][1];
            int k = commands[a][2];                        
            int[] temp = new int[j - i + 1];
        
            for(int index = 0; index < temp.length; index++) {
                temp[index] = array[i-1];
                i++;
            }
        
            int min = temp[0];
            for(int c = 0; c < temp.length; c++) {
                for(int b = c+1; b < temp.length; b++) {
                    if(temp[c] > temp[b]) {
                        min = temp[b];
                        temp[b] = temp[c];
                        temp[c] = min;
                    }
                }
            }
            answer[a] = temp[k -1];        
        }
        return answer;
    }
}
```
---
## 💡공부할 것
### 📍정확한 개념이 필요한 부분
- 2차원 배열에서 2차원 배열의 길이 / 각 원소의 길이의 차이?
- 2차원 배열이름.length = 2차원 배열의 길이 ??? (왜??)