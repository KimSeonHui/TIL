## 소수 찾기📝
>[문제_소수 찾기](https://programmers.co.kr/learn/courses/30/lessons/12921)

소수 : 1과 자기자신으로만 나누어 떨어지는 수

### 📍첫 번째 풀이
소수가 되려면 2 ~ n-1 까지의 어떤 소수로도 나누어 떨어지지 않아야 함
2는 짝수 중에서 유일한 소수. 
- 따라서 4이상의 짝수는 절대 소수가 될 수 없기 때문에 홀수만 확인

```java
import java.util.ArrayList;

class Solution {
    public int solution(int n) {
        int answer = 0;
	int index = 0;
        ArrayList<Integer> numbers = new ArrayList<Integer>();  
        
        numbers.add(2);
        index++;
        answer++;
		
        for(int i = 3; i <= n; i += 2) {
        	int j;
        	for(j = 1; j < numbers.size(); j++) {
        		if(i % numbers.get(j) == 0) {
        			break;
    			}       		        		
        	}
        	if(index == j) {
    			answer++;
    			index++;
    			numbers.add(i);
    		}
        	
        }
        
        return answer;
    }
}
```
🙋‍♀️**코드 분석**
- 안쪽 for문에서 이미 찾아낸 소수의 수(```numbers.size()```)까지만 for문을 반복하기 때문에 시간이 조금 덜 걸리게 됨
- 홀수만 확인하기 때문에 시간이 덜 걸리게 됨
- 하지만 여전히 **n의 크기에 비례해서 시간이 오래 걸림**


---
### 📍두 번째 풀이
**에라스토테네스의 체**
- 소수를 찾는 방법으로 그리스의 수학자 에라스토테네스가 발견

🙋‍♀️**알고리즘**
- 2부터 n 사이의 수를 모두 나열
- 2는 소수이므로 자기자신을 제외한 2의 배수를 모두 지운다
- 남아 있는 수 가운데 3은 소수이므로 자기자신을 제외한 3의 배수를 모두 지운다
- 남아 있는 수 가운데 5는 소수이므로 자기자신을 제외한 5의 배수를 모두 지운다
- 이와 같은 방법으로 i*i <= n 까지 반복하면 구하고자 하는 구간 안의 소수를 찾을 수 있다

#### Boolean으로 확인
``` java
	int answer = 0;

        ArrayList<Boolean> numbers = new ArrayList<Boolean>();  
        numbers.add(false);
        numbers.add(false);
        
        for(int i = 2; i <= n; i++) {
        	numbers.add(i, true);
        }
		
        for(int i = 2; i * i <= n; i++) {
        	if(numbers.get(i)){
        		for(int j = i * i; j <= n; j += i) {
        			numbers.set(j, false);
        		}
        	}
        }

        numbers.removeAll(Arrays.asList(Boolean.FALSE));
        answer = numbers.size();
        
        return answer;
    }
```

#### int타입으로 확인
```java
import java.util.*;

class Solution {
    public int solution(int n) {
        int answer = 0;

	int[] numbers = new int[n+1];
        numbers[0] = 0;  //false == 0
        numbers[1] = 0;
        
        for(int i = 2; i <= n; i++) {
        	numbers[i] = 1;  // true == 1
        }
		
        for(int i = 2; i * i <= n; i++) {
        	if(numbers[i] == 1){
        		for(int j = i * i; j <= n; j += i) {
        			numbers[j] = 0;
        		}
        	}
        }

        for(int i = 2; i < numbers.length; i++) {
            if(numbers[i] == 1) {
                answer++;
            }
        }
        return answer;
    }
}
```

---
## 느낀점🙄
사실 에라토스테네스의 체를 사용하지 않더라도 소수를 구할 수 있는 방법은 굉장히 다양하다. 하지만 문제에서 통과되지 않았더라면 내가 계속 고민하고 구글링을 하면서 더 효율적이고 더 빠르게 계산을 할 수 있는 방법을 고민했을까? 하는 생각이 들었다. 

이번 문제에서도 여러가지 접근 방법이 있다. 
- 2~ n-1 사이의 어떤 수로도 나눠 떨어지지 않는 수 = 소수
- 2~ n-1 사이의 어떤 소수로도 나눠 떨어지지 않는 수
- 1과 자기 자신으로만 나눠떨어지는 수 = 소수
- 구하는 구간 안에 자기자신을 제외하고 배수를 모두 지우고 남는 수 = 소수

등등 다양한 접근 방법에 초점을 두고 코드를 고민했는데 이제는 시간복잡도도 같이 생각을 해봐야겠다. 접근 방법에 따라 코드가 달라지고 그에 따라 시간복잡도도 달라지는 건 맞지만 조금 더 효율적인 부분에 중심을 두고 고민을 해야겠다는 생각이 든다.
