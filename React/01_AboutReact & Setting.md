## React란?
![image](https://user-images.githubusercontent.com/44824456/136783934-029964ee-a33a-4094-82a0-6237f8fdde04.png)

자바스크립트 UI 라이브러리

html의 복잡한 코드를 사용자 정의 태그(**컴포넌트**)로 바꾸어줌

- 가독성이 높아짐
- 재사용성이 높아짐
- 유지보수가 편리해짐

-----
## create-react-app 개발환경 설정

### Get Started
**1. `npm 설치`**
- `node js` 설치
- cmd 창에서 `npm -v` 후 버전이 나오면 설치 성공
```
C:\Users\김선희>npm -v
6.14.15
```

#

**2. npm을 이용해 `create-react-app` 설치**        
- 공식 `create-react-app` README.md 방법
```
npx create-react-app my-app
cd my-app
npm start
```
[자세한 참고](https://github.com/facebook/create-react-app)



- npm 이용해 설치
```
npm install -g create-react-app
```


- 설치 후 cmd 창에서 `create-react-app -V` 후 버전이 나오면 설치 성공
```
 C:\Users\김선희>create-react-app -V
4.0.3
```


>`npx` 와 `npm`의 차이는??🙄🙄      
>
>`npx`
>- 실행할 때 다운 받아서 한 번만 실행하고 지움
>    - 불필요한 공간을 차지하지 않음
>   - 실행할 때마다 설치되기 때문에 항상 최신상태임
>
>`npm`     
>- 완전히 설치해서 사용

**3. react 앱 디렉토리 설정**
- 원하는 경로에 빈 디렉토리 생성
- `cmd` 를 통해 디렉토리로 경로 이동
    - Tip) `cd + 디렉토리 드래그 & 드랍`
        - 자동으로 해당 디렉토리 경로를 입력해줌
- 해당 디렉토리로 이동 후 `create-react-app .` 입력
    - 현재 디렉토리가 create-react-app에 의해서 개발환경이 셋팅됨
    
     ![image](https://user-images.githubusercontent.com/44824456/136785788-b184641f-9294-432c-b90f-ab7ad7e52f3f.png)
     
     
     자동으로 필요한 파일들이 생성됨
