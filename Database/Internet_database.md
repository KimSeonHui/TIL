>생활코딩 Database2-mySQL 강의 정리

## 인터넷과 데이터베이스의 관계
![11](https://user-images.githubusercontent.com/44824456/132817854-51ac0ed3-352f-4eae-8e98-45903d5c13f7.png)


**인터넷**

- 흩어져있는 컴퓨터들이 인터넷들으로 연결되면서 컴퓨터들간의 사회가 만들어짐
- 한 대의 컴퓨터가 갖고 있는 한계를 초월하게 되었다는 의미
    - 한컴퓨터는 다른 컴퓨터로 요청, 다른 컴퓨터는 요청한 컴퓨터에 응답
    - client : 요청하는 쪽
    - server : 응답하는 쪽

**데이터베이스 서버는 직접 다룰 수 있는게 아니라 데이터베이스 클라이언트를 통해서 다룰 수 있음**

- 데이터베이스 클라이언트 : mysql monitor
- 데이터베이스 서버를 제어할 수 있도록 기본 번들로 mysql monitor를 제공
    - mysql은 명령어를 통해 데이터베이스 서버를 제어

- 또 다른 데이터베이스 클라이언트 : mysql workbench
![image](https://user-images.githubusercontent.com/44824456/132817979-4f3ccb32-e41d-4077-b7c1-42a013ffccf1.png)
- mysql workbench는 데이터베이스 서버를 GUI 방식으로 제어할 수 있는 환경 제공
   - GUI 환경으로 제어가 가능하지만 결국 sql문 생성함!
   - ![image](https://user-images.githubusercontent.com/44824456/132818359-c6896e89-edc5-4a7c-9486-b854a76c3a17.png) 

---

## 더 나아가기

데이터베이스는 대부분 데이터베이스 자체만 사용하기보다 다른 것들과 함께 사용되는 경우가 많음

- 프로그래밍의 한 부품으로 쓰이는 경우 더 공부해보면 좋은 것
    - ex) php mysql api, java mysql api
    - 데이터베이스 시스템을 그 언어로 쉽게 핸들링 할 수 있는 조작장치
