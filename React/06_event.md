## 이벤트
![image](https://user-images.githubusercontent.com/44824456/136783934-029964ee-a33a-4094-82a0-6237f8fdde04.png)

리액트에서는  props, state 값이 바뀌면 그 state를 가진 컴포넌트의 render함수가 다시 호출됨

- render함수 하위에 있는 컴포넌트의 render 함수도 다시 호출
- **화면이 다시 그려짐**

**render()**

- 화면에 어떤 html을 그릴지 결정하는 함수

#

### 이벤트 설치
>`onClick`이벤트 예시

react에서는 `onClick={function() { ...}` 으로 이벤트 사용

```html
<header>
  <h1><a href="/" onClick={function(e){
   console.log(e);
	 e.preventDefault();
   debugger;
	 this.state.mode = 'welcome';
}}</a>{this.state.subject.sub}</h1>
 </header>
```

**페이지 로드 막기**

- `e` : onClick 함수가 실행됬을 때, 첫 번째 인자로 들어오는 이벤트 객체
- `e.preventDefault()` : 이벤트가 발생한 태그의 기본적 기능을 못하게 막는 것
- `debugger;`
    -  만나면 멈추고 `Source` 탭에서 코드를 통해 디버깅 할 수 있도록 함

#

**문제점**

`this.state.mode = 'welcome';`

- onClick() 실행 할 때 `this` 값이 아무것도 셋팅되어 있지 않아서 오류가 발생
- `this`를 찾을 수 없음

#

**해결**

1.  `bind(this)` 추가

```html
<header>
  <h1><a href="/" onClick={function(e){
   console.log(e);
	 e.preventDefault();
	 this.state.mode = 'welcome'
}}.bind(this)</a>{this.state.subject.sub}</h1>
 </header>
```

`this.state.mode = 'welcome';` 의 `this` 는 APP 컴포넌트의 `this` 가 됨

#

2. `this.setState({ stateName : value })`

```html
<header>
  <h1><a href="/" onClick={function(e){
   console.log(e);
	 e.preventDefault();
	 this.setState({
		mode: 'welcome';
	});
}}.bind(this)</a>{this.state.subject.sub}</h1>
 </header>
```

state 값을 변경하기 위해서는 `setState()` 사용
