## ArrayList
배열과 비슷하지만 좀더 유동적임
- 크기를 명시하지 않아도 됨
   - ```add()```와 ```remove()```로 원하는 요소를 추가하고 삭제할 수 있음!
---
### 📍생성
방법1. ```ArrayList 이름 = new ArrayList();```

```java
ArrayList animals = new ArrayList();
```

- 자료형을 명시하지 않았을 경우 ```Object```타입
- Object타입이기 때문에 Object타입을 상속하는 어떤 것이든 넣을 수 있음

**그럼 자료형이 int, String처럼 달라도 다 넣을 수 있는 것인가?🙄**
- 가능! (Object타입이기 때문!!)
```java
ArrayList animals = new ArrayList();
animals.add(34);  
animals.add("Cow");
animals.add("Parrot");
```

방법2. ```ArrayList<자료형> = new ArrayList();```
```java
ArrayList<String> animals = new ArrayList();
```
- ```String```타입만 ArrayList에 포함될 수 있음
--- 

### 📍요소 추가하기
방법1. ```add(Object o);```
```java
animals.add("Pig");
animals.add("Cow");
animals.add("Parrot");
```
방법2. ```animals.add(int index, Ojbect o)```
//원하는 인덱스에 원하는 값 넣기
```java
animals.add(0, "Dog")
```

--- 
  
### 📍요소 가져오기
```get(int index)``` // 이름.get(가져오고자 하는 요소의 index);
```java
animals.get(0);
```    

  
**반복해서 요소 가져오기**
arrayList는 length가 아니라 size가 있음

🙋‍♀️**방법1. for문**
```java
for(int i = 0; i < animals.size; i++) {
   System.out.println(animal.get(i));
}

---
Pig
Cow
Parrot
```

🙋‍♀️**방법2. Clever for문**
```java
//for(받아올 자료형 타입 받아올 변수이름 : 읽어올 리스트)
for(String animal : animals)  {
   System.out.println(animal);
}
```
**방법2-1. String 타입으로 가져오기**
- animals가 자료형을 명시하지 않았기 때문에 String 타입인 animal로 읽어올 수 없음
- animals에 자료형을 String으로 명시해줘야함!
```java                                
//ArrayList 자료형 명시O
ArrayList<String> animals = new ArrayList();
animals.add("Pig");
animals.add("Cow");
animals.add("Parrot");

for(String animal : animals)  {
   System.out.println(animal);
}

------
Pig
Cow
Parrot
```

**방법2-2. Object타입으로 가져오기**
```java                                
//ArrayList 자료형 명시 X
ArrayList animals = new ArrayList();
animals.add(34); 
animals.add("Cow");
animals.add("Parrot");

for(Object animal : animals)  {
   System.out.println(animal); 
}

----
34
Cow
Parrot
```
---

### 📍요소 삭제하기
방법1. ```remove(int index)``` // ArrayList 이름.remove(삭제할 요소의 인덱스);
```java
animals.remove(0);
```

방법2. ```remove(Object o)```
```java
animals.remove("Cow"); 
```
- 삭제하려고 하는 요소값을 직접 입력해서 삭제할 수 있음
- 삭제하려고 하는 값이 정확히 어디 있는지 모를 때, 너무 많을 때 사용하면 유용

---
### 📍특정 요소 있는지 확인하기
```contains(Object o); ```
- 포함하고 있으면 true, 없으면 false return

```java
ArrayList animals = new ArrayList();
animals.add("34");
animals.add("Cow");
animals.add("Parrot");
animals.add("Cheetah");

if(animals.contains("Parrot")) {
  animals.remove("Parrot");
  }
else {
 System.out.println("Nope");
 }
```

---
## 📝추가 공부
### 📍Object 클래스
![](https://images.velog.io/images/zero9657/post/4516f1fe-76ae-49e7-a676-1319d1d31624/image.png)
- Object는 모든 클래스의 수퍼 클래스로 array를 포함한 모든 objects가 Object 클래스를 상속함 
- String 클래스, integer 클래스 뿐만 아니라 Thread.. 등도 모두 상속함
---
### 📍ArrayList Document
java.util 패키지 안에 있음
- [ArrayList API](https://docs.oracle.com/javase/7/docs/api/)
