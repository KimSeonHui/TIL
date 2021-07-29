## 📝나누어 떨어지는 숫자 배열
>[문제_나누어 떨어지는 숫자 배열](https://programmers.co.kr/learn/courses/30/lessons/12910)

---
### 💡접근방법
원하는 결과(나누어 떨어지는 숫자)를 담은 공간을 생성한다
비어 있는지 아닌지를 판단한 후 길이가 0이 아니면 오름차순으로 정렬
만약 길이가 0이라면 -1을 리턴

**🙋‍♀️조건에 맞는 결과를 담을 공간 생성**
- 얼마큼의 공간이 필요할지 모르기 때문에 ArrayList로 생성
- arr[]을 for문으로 확인하면서 divisor로 나눴을 때 나머지가 0이면 ArrayList에 추가
- arr[] 배열 끝까지 반복

**🙋‍♀️ArrayList가 비어 있는지 확인**
- ArrayList의 isEmpty()로 확인
- true이면 -1리턴, false 이면 ArrayList 오름차순 정렬

**🙋‍♀️오름차순 정렬**
- 첫 번째 요소를 최솟값으로 생각하고 다음 요소와 비교
- 첫 번째 요소가 다음 요소 보다 크다면 두 개의 위치를 바꿈
---

### 📍코드_첫 번째 풀이
- ArrayList에 arr[]의 요소들 중 divisor로 나눠지는 값을 먼저 추가
- 그 후 비었는지 아닌지를 확인해 ArrayList를 오름차순 정렬
```java
import java.util.*;

class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = {};
        ArrayList<Integer> temp = new ArrayList<Integer>();
        
        for(int num : arr) {
            if((num % divisor) == 0) {
                temp.add(num);
            }
        }
        
        if(!temp.isEmpty()) {
           for(int i = 0; i < temp.size(); i++) {
                for(int j = i+1; j < temp.size(); j++){
                    if(temp.get(i) > temp.get(j)){
                        int number = temp.get(i);
                        temp.set(i, temp.get(j));
                        temp.set(j, number);
                    }
                }
            }
            answer = new int[temp.size()];
            for(int i = 0; i < temp.size(); i++) {
                answer[i]  = temp.get(i); 
            }
        }
        else {
            answer = new int[1];
            answer[0] = -1;            
            }
        
        return answer;
    }
}
```
----
### 📍코드_두 번째 풀이
- arr[] 배열을 먼저 오름차순 정렬
- 오름차순 정렬 알고리즘 직접 구현
- 그 후에 divisor로 나눠지는 arr[]의 요소만 ArrayList에 추가
- 비었는지 아닌지에 따라 answer[] 리턴

테스트케이스 6번 시간초과 오류
- 정렬을 배열일 때 오름차순으로 하는 걸로 바꿨는데 왜 안되는거지?🙄

```java
import java.util.*;

class Solution {
    public int[] solution(int[] arr, int divisor) {
        ArrayList<Integer> temp = new ArrayList<Integer>();
        
        for(int i = 0; i < arr.length; i++) {
            for(int j = i+1; j < arr.length; j++){
                if(arr[i] > arr[j]) {
                    int number = arr[i];
                    arr[i] = arr[j];
                    arr[j] = number;
                }
            }
        }
        
        for(int num : arr) {
            if((num % divisor) == 0) {
                temp.add(num);
            }
        }
        
        if(!temp.isEmpty()) {
            int[] answer = new int[temp.size()];
            
            for(int i = 0; i < temp.size(); i++) {
                answer[i]  = temp.get(i); 
            }            
            return answer;
        }
        else {
            int[] answer = {-1};
            return answer;
        }        
    }
}
```
---
### 📍코드_세 번째 풀이
- arr[] 배열을 먼저 오름차순 정렬
- Arrays.sort() 사용해서 정렬
- 그 후 divisor로 나눠지는 요소를 ArrayList에 추가
- 비었는지 아닌지에 따라 answer[] 리턴
```java
import java.util.*;

class Solution {
    public int[] solution(int[] arr, int divisor) {
        ArrayList<Integer> temp = new ArrayList<Integer>();
        Arrays.sort(arr);
        
        for(int num : arr) {
            if((num % divisor) == 0) {
                temp.add(num);
            }
        }
        
        if(!temp.isEmpty()) {
            int[] answer = new int[temp.size()];
            
            for(int i = 0; i < temp.size(); i++) {
                answer[i]  = temp.get(i); 
            }            
            return answer;
        }
        else {
            int[] answer = {-1};
            return answer;
        }        
    }
}
```
---
### 📍세 가지 코드 비교
**🙋‍♀️전체 코드 길이**
코드 길이적인 부분만으로 살펴봤을 때는 첫 번째와 두 번째 코드 길이가 비슷하고 세 번째 코드가 가장 짧았다.

**🙋‍♀️코드 길이가 짧으면 속도가 더 좋을까?**
프로그래머스 프로그램에서 체점을 하면서 코드 실행 속도를 봤을 때는 첫 번째 코드가 가장 속도가 빨랐다. 그리고 두 번째 세 번째 코드는 작동 순서는 같은데 오름차순 알고리즘을 어떻게 구현했느냐에 따라 속도 차이가 나는 것 같다. 그래서 두 번째 코드도 동작하는 코드이지만 테스트 케이스 6번에서 유독 느려 문제 풀이에서 틀린 코드라고 나오는 것 같다.

**🙋‍♀️속도에 영향을 미친 부분?**
세 가지 풀이를 다 비교해봤을 때, 첫 번째 코드가 가장 빠른 이유는 정렬을 어디에서 하느냐의 차이라고 생각한다.

정렬 알고리즘에서 속도에 가장 영향을 많이 미치는 것은 **배열의 길이**이다! 그렇기 때문에 arr[] 배열에서 조건에 맞는 요소만 뽑은 것이 arr[] 배열 전체의 요소보다 작거나 같기 때문에 조건에 맞는 요소들을 정렬하는 것이 훨씬 속도가 빠른 것 같다. 

---
## 👀더 공부가 필요한 부분
ArrayList의 ```set(Int index, E elements)```
- ArrayList의 특정 index의 요소를 특정 값으로 바꿀 때 사용하는 함수
- 배열의 정렬은 많이 해봤지만 ArrayList의 정렬은 처음이었다
- 그래서 처음에는 이상하게 구현하기도 했었는데 이번 기회에 set() 뿐만 아니라 add(), get()에 대해서도 더 알아가는시간이었다
- [ArrayList Document](https://docs.oracle.com/javase/7/docs/api/)
