# Hash Table(Hash Map) 해시 테이블
- **(key, value)** 쌍으로 데이터를 저장하는 자료구조
- 각각의 key값에 해시함수를 적용해 배열(버킷)의 고유한 index를 생성,
index를 활용해 값을 저장하거나 검색함
- 데이터 저장/삭제/검색이 매우 빠름

![image](https://user-images.githubusercontent.com/44824456/167544596-f57e7ce3-fff8-4de6-aa8f-8e6f22ff685e.png)

> 📌 **내부 동작**    
> (key, value)가 ('John Smith', '521-1234')인 데이터를 저장할 때, 
>     
> - 해시 함수에 의해 key값인 'John Smith'에 대한 **고유한** `index`가 생성됨.    
> - 그 후 array\[index\](버킷)에 value값인 '521-1234'가 저장이 된다.    
> 
> 각각의 key에 대해 고유한 index가 생성되기 때문에 key값으로 검색할 때 **해시 함수를 한 번만 수행**해서 
> 해당하는 value 값을 찾을 수 있어 데이터 저장/삭제/검색이 매우 빠름

<br />

## 해시 값(index)의 충돌
이상적으로 해시 함수는 하나의 key에 하나의 해시 값(index)가 생성되지만, 불완전한 해시 함수를 사용하기 때문에    
서로 다른 key에 같은 index를 생성하는 해시 충돌이 발생할 수 있다. 해결하는 방법으로는 1) 분리 연결법 2) 개방 주소법이 있다.


### 분리 연결법 Sparate Chaining

![image](https://user-images.githubusercontent.com/44824456/167545908-1e163c48-b496-4e64-b1a7-5e23d9001231.png)


동일한 버킷의 데이터에 대해 추가 메모리를 사용해 추가 데이터의 주소를 저장하는 방법
- 해시 테이블의 확장이 필요 X, 간단하게 구현 가능
- 손쉽게 삭제 할 수 있음
- 데이터 수가 많아지면 버킷에 chaining 되는 데이터가 많아 캐시의 효율성이 감소함

<br />

### 개방 주소법(Open Addressing)
비어있는 해시 테이블의 공간을 활용하는 방법

1. **Linear Probing** : 현재 버킷 index로부터 고정폭만큼씩 이동하며 순서대로 검색해 비어 있는 버킷에 데이터 저장
2. **Quadratic Probing** : 해시의 저장순서 폭을 제곱으로 저장 
    ex) 처음 충돌이 발생한 경우 1만큼 이동, 그 후 충돌이 발생하면 2^2, 3^2칸씩 칸을 옮기는 방식
3. **Double Hasing Probing** : 해시된 값을 한번 더 해싱해 해시의 규칙성을 없애버리는 방식
    해시된 값을 한 번더 해싱해 index를 생성하기 때문에 다른 방법보다 많은 연산을 함


![image](https://user-images.githubusercontent.com/44824456/167546258-e480fb36-4a09-4e58-af7d-f5bdca7b31f8.png)


> 📌 **데이터 삭제시**      
> 개방 주소법에서 데이터 삭제 시 삭제된 공간이 dummy space로 남기 때문에 해시 테이블 정리가 필요함


----
## 참고
- [해시 테이블](https://mangkyu.tistory.com/102)
- [hash table](https://github.com/trekhleb/javascript-algorithms/tree/master/src/data-structures/hash-table)
