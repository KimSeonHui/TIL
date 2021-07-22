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
#### 다차원 배열
1차원 이상의 배열을 구성 요소로 하는 배열  
- 2차원 배열 : 배열을 구성 요소로 하는 배열 
- 3차원 배열 : 2차원 배열을 구성 요소로 하는 배열

#### 다차원 배열의 내부
``` java 
int [][] x = new int[2][4];
```
2행 4열의 배열 x의 내부를 그림으로 나타내면 이렇게 보여진다
![](https://images.velog.io/images/zero9657/post/80b24ee0-93f6-439a-b980-9fa270502a08/KakaoTalk_20210722_190908865.jpg)
**1. 배열의 이름(x)는 배열 그 자체가 아니라 배열을 참조하는 변수이다.       
2. 배열 본체를 생성하고 x가 그걸 참조하도록 대입한다.** 
- 생성한 배열을 x에 의해 참조되고 각 요소에 접근하는 방식은 x[0], x[1]이다.
 - 이 배열의 구성 요솟수(길이)는 배열이름(x).length로 구할 수 있다

**3. 배열 본체를 생성하고 x[0]이 그걸 참조하도록 대입한다.**
- 생성한 배열을 x[0]에 의해 참조되고 각 요소에 접근하는 방식은 x[0][0], x[0][1], x[0][2]이다.
 - 이 배열의 구성 요솟수(길이)는 배열이름(x[0]).length로 구할 수 있다

**4. 배열 본체를 생성하고 x[1]이 그걸 참조하도록 대입한다.**
- 생성한 배열을 x[1]에 의해 참조되고 각 요소에 접근하는 방식은 x[1][0], x[1][1], x[1][2]이다.
 - 이 배열의 구성 요솟수(길이)는 배열이름(x[0]).length로 구할 수 있다

### 📍문제에 적용
🙋‍♀️**2차원 배열에서 2차원 배열의 길이 / 각 원소의 길이의 차이?**

**2차원 배열 commands의 길이**
- 배열 변수 commands가 참조하고 있는 배열 본체의 길이(구성 요솟수)

**각 원소의 길이** 
- commands가 참조하고 있는 본체가 참조하고 있는 배열 본체(commands[0], commands[1], commands[2])의 길이(구성 요솟수)를 말한다

🙋‍**2차원 배열이름.length = 2차원 배열의 길이???**     
2차원 배열이름 = 배열 본체 자체가 아니라 배열 본체를 참조하는 변수      
commands.length = commands가 참조하고 있는 배열 본체의 갯수를 구함
- commands[0], commands[1], commands[2] 를 참조하기 때문에 commands.length = 3
