> 생활코딩_Database2-MySQL 강의 정리

## MySQL의 구조
![2](https://user-images.githubusercontent.com/44824456/132816333-9559ac6d-e108-49d0-9ea8-d54159e3ded6.png)

**table** : 데이터를 기록하는 최종적인 곳

**데이터베이스(스키마_shema)** : 연관된 표들을 그룹핑 한 것

- 표들을 그룹핑할 때 사용하는 폴더와 같은 역할

**데이터베이스 서버** : 스키마들을 그룹핑 한 것

**사용할 때 좋은점**

- 자체적인 보안체계가 있기 때문에 보다 안전하게 데이터를 보관할 수 있음
- 권한기능 → 여러 사용자를 등록할 수 있음

`mysql -u사용자이름 -p`

- 초기 사용자이름 : root
    - 관리자이기 때문에 모든 권한이 열려있음
    - 직접 다루는 건 위험하기 때문에 중요한 시스템일경우 따로 사용자를 등록해서 사용하는 것이 좋음
- -p : 비밀번호 입력(각자 기억하고 있는 비밀번호)
    - 비밀번호 까먹었을 때는 검색엔진 이용...

이까지 들어온 것은 데이터베이스 서버에 들어온 것

![3](https://user-images.githubusercontent.com/44824456/132816446-60d6911b-7519-486b-b3cb-75694a0f15e3.png)

---

## Schema 생성/삭제

`CREATE DATABASE database_name;`

- database_name : 생성하고자 하는 데이터베이스 이름

`USE database_name;`

- 사용할 database를 지정

`SHOW DATABASES;`

- 현재 생성되어 있는 데이터베이스의 목록 확인

---

## SQL과 테이블 구조

Structured Query Language

- 구조화된 요청/질의 언어
- 데이터의 처리를 구조화된 방식(표)으로 처리하도록 하는 언어

**특징**

- 쉬움!
- 중요함!
    - 관계형 데이터베이스에서 데이터를 다룰 때 사용하는 언어이기 때문에

![4](https://user-images.githubusercontent.com/44824456/132816563-64250f0d-b15b-49fd-a811-05a91265778d.png)

**row** : 데이터 자체

**column** : 데이터의 구조, 데이터의 타입

---

## Table 생성

검색해서 원하는 정보를 찾아내는게 중요! 

**mysql create table cheat sheet**

- cheat sheet : 컨닝페이퍼/ 간단하게 정리해놓은 것

API보고 이해가 어려울 때 검색해서 활용하기

![5](https://user-images.githubusercontent.com/44824456/132816708-9e4c8021-e566-45b7-9aa5-a999d291e55c.png)

**column의 데이터 타입 강제**

- 사용자가 예상하지 못한 데이터타입을 입력할 때도 많기 때문에 규제
- 데이터의 수가 많아질 때 관리를 쉽게 하기 위해
- 데이터를 꺼낼 때 데이터 타입이 동일하기 때문에 타입을 신경쓰지 않아도 되서 편함

`NOT NULL`
- 값이 없는걸 허용하지 않겠다

`NULL`
- 값이 없는걸 허용함

`AUTO_INCREMENT`
- 자동으로 값을 1씩 증가

`VARCHAR(size)`
- variable charactor 의 약자
- size 만큼만 받고 넘어가는 나머지는 버려버림

PRIMARY KEY(속성)
- 값이 중복되면 안되는 속성을 지정
- 식별자로써 데이터를 구분하기 위한 것을 주로 지정

---

## CRUD

Create : 생성     
Read : 읽기     
Update : 수정     
Delete : 삭제    

**CREATE**      
`INSERT table_name (col1, col2, col3...) VALUES (val1, val2, val3...);`    
- 칼럼에 맞춰 값을 테이블에 넣음

**READ**     
`SELECT select_expression [FROM tabe_name] [WHERE where_condition] [ORDER BY {col_name | expr | position}] LIMIT num;`

- select_expreesion : 보고자 하는 칼럼 / 전부 보고 싶으면 *
- WHERE where_condition : 데이터 중 조건에 맞는 값을 찾고 싶을 때 사용
- ORDER BY {col_name | expr | position} : 정렬 { 정렬하는 방법}
- LIMIT num : 가져오려는  데이터 수를 num만큼만 제한
- '[ ]' : 괄호 안은 생략 가능

예시)

`SELECT * FROM table_name;` 테이블 전체 보기
![6](https://user-images.githubusercontent.com/44824456/132816811-936ee55c-d6c5-440e-ae43-9aee1303c89e.png)

`SELECT **id, title, created, author** FROM topic;` 테이블에서 원하는 칼럼만 보기
![7](https://user-images.githubusercontent.com/44824456/132816873-1f335867-a57a-47aa-b199-5933ba619036.png)

`SELECT id, title, created, author FROM topic **WHERE author="egoing"**;` 테이블에서 원하는 값만 추출해서 보기
![8](https://user-images.githubusercontent.com/44824456/132816911-cc03d9ea-bce1-4d29-87ad-b28adc3843e4.png)

`SELECT id, title, created, author FROM topic WHERE author="egoing" **ORDER BY** **id DESC**;` 테이블에서 원하는 값 정렬해서 보기
![9](https://user-images.githubusercontent.com/44824456/132817064-09dddfe5-e9fd-4f73-9f03-9a2cbdbcdb45.png)

`SELECT id, title, created, author FROM topic WHERE author="egoing" ORDER BY id DESC**LIMIT 2**;` 테이블에서 원하는 값 원하는 갯수만큼만 추출하기
![10](https://user-images.githubusercontent.com/44824456/132817149-60aa2ab2-2498-4a70-84ea-308824a49e09.png)

**SELECT문을 상황에 따라 잘 사용하는게 중요!**       

**UPDATE**

`UPDATE table_name SET assignment_list [WHERE where_condition];`

입력된 데이터를 수정

- assignment_list :  col_name=value
- [WHERE where_condition] : 수정할 데이터의 조건을 명시, 잘못 빠뜨리면 전체 데이터가 변경되서 재앙이 일어날 수도...

**DELETE**

`DELETE FROM table_name [WHERE where_condition];`

데이터 삭제

- [WHERE where_condition] : 삭제할 데이터의 조건을 명시, 잘못 빠뜨리면 전체 데이터에 적용되서 재앙 일어남..

----
## JOIN

- 테이블과 테이블 사이의 중복을 제거함
    - 중복을 제거하기 때문에 수정해야 하는 부분이 줄어서 유지보수하기가 쉬워짐
- 한 테이블과 한 테이블 사이의 관계 뿐만 아니라 다른 많은 테이블과도 언제든지 관계를 맺을 수 있음
- 언제든지 원할 때 원하는 데이테를 포함한 테이블을 만들 수 있음
