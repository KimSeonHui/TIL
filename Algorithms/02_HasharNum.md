## 하샤드 수
> [문제](https://programmers.co.kr/learn/courses/30/lessons/12947)
     
     
      

### 첫 번째 풀이

```java
class Solution {
    public boolean solution(int x) {
        int thousand = 0;
        int hundred = 0;
        int ten = 0;
        int one = 0;
        int sum = 0;
        boolean answer = true;
        
        if(x == 10000){
            sum = 1;
        }
        else{
            thousand = x / 1000;
            hundred = x % 1000 / 100;
            ten = x % 1000 % 100 / 10;
            one = x % 1000 % 100 % 10;
            
            sum = thousand + hundred + ten + one;
        }
        
        if(x % sum == 0){
            answer = true;
        }
        else {
            answer = false;
        }
        return answer;
    }
}
```


### 첫 번째 풀이 수정
> 자릿수를 찾기 위해 만든 변수 thousand, hudred, ten, one 줄이고 싶음

```java
class Solution {
	public boolean HarsaNumber(int x) {
		boolean answer = true;
		int num = x;
		int sum = 0;	
			
		while (num != 0 ) {
			sum += num % 10;
			num = num / 10;
		}
		
		if(x % sum == 0) {
			answer = true;
		}
		else {
			answer = false;
		}
		
		return answer;
				
	}
}
