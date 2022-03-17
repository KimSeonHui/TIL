## Hashmaps
![](https://images.velog.io/images/zero9657/post/9e44093b-65d1-4fbe-9e43-6e539a78cdcb/image.png)     
하나의 key가 하나의 value와 연결돼서 pair로 저장
key를 통해 저장된 value값을 가져올 수 있음
- key값은 중복될 수 없다!
   - key - value를 추가할 때, 


---

### 📍생성
**🙋‍♀️방법1. Key, Value 자료형 타입 지정 없이 생성하기**
- 유동적으로 사용이 가능하지만 나중에 이슈가 발생할 수도 있음
- 사용할 키, 밸류의 타입을 정확하게 명시해주는게 좋음!
```java
HashMap user = new HashMap();
```

**🙋‍♀️방법2. Key, Value 자료형 타입 지정해서 생성하기**
```java
HashMap<Integer, String> newUsers = new HashMap<Integer, String>();
```
  - HashMap에 들어가는 타입은 Object타입만 사용이 가능하기 때문에 int가 아니라 Object타입인 Integer로 정확히 명시해야함


---
### 📍요소 추가하기
**🙋‍♀️방법1. Key, Value 자료형이 명시되지 않은 해쉬맵에 요소 추가하기**      
Object 타입 어떤 것이든 가능     
```put(Object key, Object value)```
```java
user.put("Sandra", 23);
user.put("Paul", 31);
user.put("George", 74);
```

**🙋‍♀️방법2. Key, Value 자료형이 명시된 해쉬맵에 요소 추가하기**     
```put(명시한 자료형 key, 명시한 자료형 value)```     
```java
//put(Integer key, String value);
newUsers.put(23, "Sandra");
```

**같은 Key를 중복될 수 있을까?🙄**        
할 수 없다!       
![](https://images.velog.io/images/zero9657/post/9e44093b-65d1-4fbe-9e43-6e539a78cdcb/image.png)        
여기에 ```("Sandra", 45);```을 추가하면 이미 Key 값에는 ```"Sandra"```가 존재하기 때문에 Key ```"Sandra"```는 더 추가되지 않고 이에 해당하는 Value 값이 ```23```에서 ```45```로 바뀌게 된다       
![](https://images.velog.io/images/zero9657/post/10baff00-e37f-4972-b9c1-132d8546d18b/image.png)
- 추가하는 key값이 이미 존재한다면 이미 존재하는 해당 key의 value의 값이 새롭게 추가하는 같은 key값이 가진 value의 값으로 바뀌게 됨
- Key 값만 다르다면 value는 중복 가능!

---
### 📍요소 가져오기
**🙋‍♀️HashMap에 저장된 전체 값 가져오기**  
```entrySet()```
```java
user.put("Sandra", 23);
user.put("Paul", 31);
user.put("George", 74);

System.out.println(user.entrySet());

---
[George=74, Paul=31, Sandra=23]
```
- HashMap은 안에 배열을 가지고 있으며, HashMap에 들어간 요소들은 배열로 나타나진다

**🙋‍♀️원하는 특정 요소 가져오기**     
```get(Object key)```
```java
System.out.println(user.get("Sandra"));

----
23
```
- Key 값을 넣으면 Key값에 해당하는 Value 값을 가져옴 

**🙋‍♀️반복해서 요소 가져오기**
```java
user.put("Sandra", 23);
user.put("Paul", 31);
user.put("George", 74);

Ierator iterator = user.entrySet().iterator();

while(iterator.hasNext()) {
// 자료형을 Map타입으로 캐스팅해줌
  Map.Entry pair = (Map.Entry) itertator.next(); 
  System.out.println("Key : " + pair.getKey() + 
                       "Value : " + pair.getValue()); 
 ---
 Key : George Value : 74
 Key : Paul Value : 31
 Key : Sandra Value : 23
```
- entrySet()은 우리가 HashMap에 추가한 모든 요소들에 접근할 수 있음
- HashMap의 entrySet()을 통해 iterator()를 사용할 수 있음
- Map<K, V>
  + HashMap을 읽을 때는 하나의 요소만을 가져오는 게 아니라 짝으로 key와 value를 가져와야 하기 때문에 collection 중에 하나인 Map을 사용함

---
### 📍요소 삭제하기
```romve(Object key)```
```java
user.remove("Sandra");

System.out.println(user.entrySet());
----
[George=74, Paul=31]
```
