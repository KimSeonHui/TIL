## 📝같은 숫자는 싫어
>[문제_같은 숫자는 싫어](https://programmers.co.kr/learn/courses/30/lessons/12906)

---
### 💡접근방법 1
연속된 중복된 숫자가 있다면 연속되지 않게 다른 숫자와 자리를 바꾼다
연속되어 중복되지 않은 배열의 부분만 answer로 옮긴다

**🙋‍♀️중복된 숫자가 있는지 확인**
- pivot을 arr[0]로, pivotIndex를 0(배열의 첫 번째 index)로 지정
- 배열의 다음 요소와 비교하면서 값이 pivot과 다르면 다른 값의 index 저장
- 현재 pivotIndex의 다음 index로 arr[index]의 값을 옮김
- 새로 값이 바뀌었기 때문에 이 값에 맞는 index와 요소 값으로 pivotIndex과 pivot의 값을 바꿔 다음 값의 비교 기준으로 함
- arr 배열 끝까지 반복

**🙋‍♀️answer 배열로 arr배열의 원하는 부분을 옮김**
- pivotIndex가 연속으로 중복되지 않은 배열의 마지막 부분을 가리킴
- answer 배열을 pivotIndex+1만큼 생성
- answer 배열로 arr배열의 pivotIndex까지의 값만 옮김
---

### 💡접근방법 2
**코드를 봤을 때 조금 더 이해하기 쉬운 방법으로 짤 수 있지 않을까?🙄**

arr 배열 하나에서 작업을 하는 것이 아니라 원하는 값을 담아 놓는 공간을 만들어서 연속되어 중복되지 않는 배열을 생성한다
새롭게 생성된 배열을 answer로 옮긴다

**🙋‍♀️임시 공간에 연속되어 중복되지 않는 배열을 생성**
- arr[]에서 필요한 값만을 뽑을 때 얼만큼의 공간이 필요할지 모르기 때문에 ArrayList로 생성
- arr[0]을 pivot으로 해 연속된 값을 비교할 기준으로 함
- arr 배열의 요소를 pivot과 비교해 다르면 ArrayList에 추가, pivot 값을 새로 추가한 값으로 바꿈
- arr 배열 끝까지 반복

**🙋‍♀️answer 배열로 ArrayList의 값을 옮김**
- ArrayList의 길이만큼 answer 배열 생성
- for문을 이용해 answer로 ArrayList의 값 옮김
---
### 📍코드
**🙋‍♀️접근 방법1에 대한 코드**
```java
import java.util.*;

public class Solution {
    public int[] solution(int []arr) {
        int[] answer = {};
        int pivot = arr[0];
        int pivotIndex = 0;
        
        for(int i = 1; i < arr.length; i++) {
            if(pivot != arr[i]){
                int index = i;
                arr[pivotIndex + 1] = arr[index];
                pivotIndex += 1;
                pivot = arr[pivotIndex];
            }
        }
        
        answer = new int[pivotIndex+1];
        for(int i = 0; i < answer.length; i++) {
            answer[i] = arr[i];
        }
        return answer;
    }
}
```

**🙋‍♀️접근방법 2에 대한 코드**
```java
import java.util.*;

public class Solution {
    public int[] solution(int []arr) {
        int[] answer = {};
        ArrayList<Integer> temp = new ArrayList<Integer>();
        temp.add(arr[0]);
        int pivot = arr[0];
        
        for(int num : arr) {
            if(pivot != num){
                temp.add(num);
                pivot = num;
            }
        }        
        answer = new int[temp.size()];
        for(int i = 0; i < answer.length; i++) {
            answer[i] = temp.get(i);
        }
        return answer;
    }
}
```

---
## 두 가지 접근방법으로 풀면서 느낀점🙄
전체적인 코드 길이는 크게 차이 나지는 않지만 접근방법2가 좀더 알아보기 쉽게 짜여진 코드인것 같다

둘다 같은 결과를 전달하지만 조금 더 읽기 쉬운 글과 전달이 잘 되는 말이 있듯이 코드도 전달이 더 잘 되는 방법으로 코딩하는 게 중요하다고 생각한다

프로젝트가 크면 클수록 개발자 혼자서 할 수 있는게 아니기 때문에 같이 코딩할 때 중요한 건 다른 개발자들도 잘 읽고 이해할 수 있게 코딩을 짜는걸 더 연습해야겠다!!