## 물리 계층의 역할과 랜 카드의 구조
### 물리 계층(Physical Layer)
컴퓨터와 네트워크 장비를 연결하고 컴퓨터와 네트워크 장비 간에 전송되는 데이터를 전기 신호로 변환하는 계층       

![그림1](https://user-images.githubusercontent.com/44824456/149896995-da366649-f957-4f3c-8c55-13989a7ebe4b.png)

#

### 전기 신호란?
**종류**
- 아날로그 신호 : 전화 회선, 라디오 방송에 사용되는 신호
- 디지털 신호    

![image](https://user-images.githubusercontent.com/44824456/149887383-ddeb2eee-38c9-4f71-94eb-004264422c5d.png)

# 

<br />

> #### 네트워크를 통해 데이터를 주고 받는 과정
> - 데이터 송신 측 컴퓨터가 전송하는 0/1의 비트열 데이터는 전기 신호로 변환
> - 전기 신호로 네트워크를 통해 수신 측 컴퓨터에 도착
> - 수신 측 컴퓨터에서 전기 신호를 0/1의 비트열 데이터로 복원


# 

### 0과 1을 어떻게 전기 신호로 변환 하는가?
0과 1의 정보가 컴퓨터 내부에 있는 랜 카드로 전송되고 랜 카드는 0과 1을 전기 신호로 변환

랜 카드
![랜카드](https://user-images.githubusercontent.com/44824456/149888292-cef07e96-cb52-4722-aec5-3081ff9af8ef.png)

----
## 케이블의 종류와 구조
**전송 매체**
- 데이터가 흐르는 물리적인 선로
- 유선 : 트위스트 페어 케이블, 광케이블
- 무선 : 라디오파, 마이크로파, 적외선

#

### 트위스트 페어 케이블이란?
**종류** : UTP 케이블, STP 케이블

<br />

#### UTP 케이블(Unshielded Twist Pair 비차폐 연선)
- 구리 선 여덟개를 두 개씩 꼬아 만든 네 쌍의 전선
- 실드로 보호되어 있지 않은 케이블
- 노이즈의 영향을 받기 쉽지만 저렴해서 일반적으로 많이 사용

<br />

#### STP 케이블(Shielded Twist Pair 차페 연선)
- 두 개씩 꼬아 만든 선을 실드로 보호한 케이블
- 노이즈의 영향을 매우 적게 받지만 비싸기 때문에 보편적으로 사용하지 않음


<br />

> #### 실드란?🙄    
> - 금속 호일이나 금속의 매듭과 같은것
> - 외부에서 발생하는 노이즈르 막는 역할을 함

<br />

> #### 노이즈란?🙄    
> 케이블에 전기 신호가 흐를 때 발생     
> 노이즈의 영향을 받으면 전기 신호의 형태가 왜곡됨    
> 노이즈의 영향을 적게 받도록 구리 선 두개를 비틀어 꼬아서 케이블을 만듦!


![image](https://user-images.githubusercontent.com/44824456/149893040-dacce977-0010-43d0-b1d9-90411a3c327d.png)

#

### 랜 케이블
트위스트 페어 케이블은 일반적으로 `랜 케이블(LAN cable)`이라고 함
랜 케이블 양쪽 끝에는 `RJ-45`라는 커넥터가 붙어 있음
![image](https://user-images.githubusercontent.com/44824456/149894455-88c7bfb5-6047-4dfd-a4ab-63b928d1d9af.png)

종류 : 다이렉트 케이블, 크로스 케이블

#

#### 다이렉트 케이블
구리 선 여덟 개를 `같은 순서`로 커넥터에 연결한 케이블
- 한쪽에서 일방적으로 보내고 다른 쪽은 받기만 하는 케이블
- 컴퓨터와 스위치(허브) 연결에 사용
![image](https://user-images.githubusercontent.com/44824456/149894269-77339f3a-3dde-4733-b78b-297b5aef0a94.png)

#

#### 크로스 케이블
구리 선 여덟 개 중 한쪽 커넥터의 `1번`, `2번`에 연결되는 구리선을 다른쪽 커넥터의 `3번`, `6번`에 연결한 케이블
- 컴퓨터 간에 직접 랜 케이블로 연결할 때 사용
![image](https://user-images.githubusercontent.com/44824456/149894780-6a16a8b9-eb19-4f8b-b00e-f73dd2ac3801.png)

<br />

> #### 크로스 케이블은 왜 중간에 전선을 교차 시킨걸까?🙄    
> 컴퓨터 간에 직접 데이터를 보낼 때는 양쪽 컴퓨터 모두 1번과 2번선을 사용    
> 양쪽에서 데이터를 전송하게 되면 1번, 2번에서 데이터가 충돌하기 때문에 일부러 중간에 전선을 교차시켜서 송신 측과 수신 측이 충돌하지 않고 올바르게 연결되도록 함