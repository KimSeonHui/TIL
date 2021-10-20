## state 사용
![image](https://user-images.githubusercontent.com/44824456/136783934-029964ee-a33a-4094-82a0-6237f8fdde04.png)

### 기본 구조

```jsx
constructor(props) {
    super(props);

.. 원하는 초기화 작성
	
  }
```

- 컴포넌트가 실행될 때 `cunstructor` 가 있다면 제일 먼저 실행되서 함수를 초기화를 담당

#

### 사용

```jsx
class  App extends Component {
  constructor(props) {
    super(props);

//state 초기화		
    this.state = {
//Subject를 state화 시킴
      Subject: {title:'Web', sub:'World Wide Web!'}
    }

  }
  render() {
    return (
      <div className="App">
        <Subject
  //state를 props의 값으로 전달
          title={this.state.Subject.title}
          sub={this.state.Subject.sub}></Subject>
        <TOC></TOC>
        <Content  title="HTML" des="HTML is.."></Content>
      </div>
    );
  }
}
```

- 상위 컴포넌트는 내부 정보로 `state`를 사용
- `state` 를 하위 컴포넌트로 전달할 때는 `props` 값으로 전달


>앱이 내부적으로 사용할 상태는 `state` 를 통해 사용
>- 외부에서 알 필요가 없는 정보는 철저하게 은닉해야 함

#

### state 값이 여러개인 경우

```jsx
class  App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Subject: {title:'Web', sub:'World Wide Web!'},
      contents:[ 
        {id:1, title:'HTML', desc:'HTML is....'},
        {id:2, title:'CSS', desc:'CSS is....'},
        {id:3, title:'JavaScript', desc:'JavaScript is....'},
      ]
    }

  }
  render() {
    return (
      <div className="App">
        <Subject
          title={this.state.Subject.title}
          sub={this.state.Subject.sub}></Subject>
        <TOC data={this.state.contents}></TOC>
        <Content  title="HTML" des="HTML is.."></Content>
      </div>
    );
  }
}

//TOC.js - 사용
class TOC extends Component {
    render () {
      var list = [];
      var data = this.props.data;
      var i = 0;
      while(i < data.length){
        list.push(<li key={data[i].id}><a href={data[i].id}>{data[i].title}</a></li>);
        i = i + 1;
      }

      return (
        <nav>
              <ul>
                  {list}
              </ul>
        </nav>
      );
    }

}
export de
```

`state이름 : [`

`{객체이름: 객체 값},`

`{객체이름: 객체 값},`

`.....`

`]`

#

### ❗주의해야 할 것❗

여러 개의 요소를 자동으로 생성할 경우 리액트에서 에러를 발생

- `Warning: Each child in a list should have a unique "key" prop`
    - `key` props를 가지고 있어야 하기 때문

**key**

리액트가 내부적으로 필요해서 개발자에게 요청하는 것

- 다른 것과 겹치지 않는 식별자를 주면 됨
