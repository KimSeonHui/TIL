## Bootstrap Navbar
화면 상단에 배치해 메뉴 등을 표시하는 용도    
지정한 스케일에 따라 스케일 이상이면 메뉴바처럼 표시, 스케일 이하일 때는 버튼으로 동작

[Docs](https://getbootstrap.com/docs/5.1/components/navbar/)
#### 스케일 이상
![image](https://user-images.githubusercontent.com/44824456/134836541-7e9b713f-ec1a-4df8-9b38-dc45610b1781.png)

#### 스케일 이하
![image](https://user-images.githubusercontent.com/44824456/134836520-1dc0b38f-1ab3-4300-894c-e91a47feafe2.png)

#

### 대표 클래스
`navbar` : nav 태그를 navbar로 만들어줌    
`fixed-*` : navbar 고정    
- -top : 위에 navbar 고정    
- -bottom : 아래에 navbar 고정    
- sticky-top : 스크롤을 내리다가 navbar에 닿으면 거기서 유지    

`navbar-collapse` : 접었다 펼칠 수 있는 navbar로 만들어줌   

#

### 배경색
bg-primary, bg-success, bg-info, bg-warning, bg-danger, bg-secondary, bg-dark, bg-light
![2](https://user-images.githubusercontent.com/44824456/134835724-6bde50fb-050b-48ad-8a29-b364d5cd60f5.png)
- 클래스 이름에 따라 미리 지정되어 있는 색
- 만약 색을 바꾸고 싶으면 css파일에서 원하는 부분을 찾아 직접 바꿔서 원하는 색으로 사용할 수도 있음

#

### 글자색

`navbar-dark `
- navbar가 어두운 색이기 때문에 이거에 맞는 밝은 글자색을 사용
![3](https://user-images.githubusercontent.com/44824456/134835802-9ca3a87d-b453-48a1-81f0-8c14767c9e67.png)

`navbar-light`
- navbar가 밝은 색이기 때문에 이거에 맞는 어두운 글자색을 사용
![4](https://user-images.githubusercontent.com/44824456/134835821-7d18b7f5-7c20-4301-82e9-654622e87ead.png)

#

### 버튼이 나타날 사이즈
navbar-expand-xl, navbar-expand-lg, navbar-expand-md, navbar-expand-sm
- 창의 크기가 (스케일)이하일 때 버튼이 나타나겠끔 설정할 수 있음

#

### 상단바 안에서의 위치배치
`Utilities_Spacing(margine, padding`)과 `Utilities_flex(자동 마진, 정렬, 순서...)` class를 사용해서 배치
