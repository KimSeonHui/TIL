## Character
- 문자, JAVA에서는 ''(작은 따옴표)로 표현
     
>**문자와 문자열은 뭐가 다른거지?🙄**    
**문자(Character)** : 문자열을 이루는 최소 단위 하나하나 ex) 'A', 'B', '생'         
**문자열(String)** : 문자와 문자가 결합 한 것, ""(큰 따옴표)로 표현 ex) "AB", "생활코딩"    
문자열을 ''(작은 따옴표)로 묶으면 에러가 발생 



- 메소드, Character 클래스의 데이터 등등의 정보는 유니코드 Standard에 기초함_[Unicode](http://www.unicode.org) 
   - char 변수는 내부적으로 유니코드로 저장됨
   - char 변수에 저장된 유니코드를 알고 싶으면 int형 변수로 바꿔서 확인할 수 있음
   
 ```java
 public static void main(String[] args) {
		char c = 'a';
		char c2 = '0';
		
		int code = (int)c;
		int code2 = (int)c2;
		
		System.out.println(" 'a' code : " + code);
		System.out.println(" '2' code : " + code2);

	}
 ```
**결과**    
 >'a' code : 97   
 '0' code : 48    
 
  - 내부에 저장된 유니코드 값으로 다른 charcter 변수끼리 서로 대소를 비교할 수 있음
``` java
public static void main(String[] args) {
		char c = 'a';
		char c2 = '0';
		
		int code = (int)c;
		int code2 = (int)c2;
		
		System.out.println(" 'a' code : " + code);
		System.out.println(" '0' code : " + code2);
		
		if(c < c2) {
			System.out.println(c+ "가 " + c2 + "보다 작습니다");
		}
		else {
			System.out.println(c+ "가 " + c2 + "보다 큽니다");
		}

	}
```
**결과**    
 >'a' code : 97   
 '0' code : 48      
 a가 0보다 큽니다
 

**유니코드란?🙄**     
네트워크와 IT의 발전으로 다양한 나라들이 컴퓨터를 사용하게 되면서 만든 **국제적으로 모든 언어를 표시할 수 있는 표준코드 규약**     
영어와 같이 1byte로 자국어를 표현할 수 있는 나라는 1byte로 사용하지만 한자와 한글같이 1byte로 충분하지 않은 나라들은 2byte 유니코드를 사용

---
**참고자료**
- [JAVA_API_Character](https://docs.oracle.com/javase/7/docs/api/java/lang/Character.html#unicode)
- [문자형 char에 대한 이야기](https://gyugyu.tistory.com/6)
