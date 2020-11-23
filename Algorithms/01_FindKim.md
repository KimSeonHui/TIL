### String 비교
>[서울에서 김서방 찾기](https://programmers.co.kr/learn/courses/30/lessons/12919)

```java
class Solution {
	public  String FindKimSolution(String[] seoul) {
		String answer = "";
		int index = 0;
		
		for(int i = 0; i < seoul.length; i++) {
			if(seoul[i].equals("Kim")) {
				index = i;
			}
		}
		
		answer = "김서방은 " + index + "에 있다";
		return answer;
	}
}
```
