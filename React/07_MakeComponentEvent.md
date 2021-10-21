## 컴포넌트 이벤트 만들기
![image](https://user-images.githubusercontent.com/44824456/136783934-029964ee-a33a-4094-82a0-6237f8fdde04.png)

컴포넌트에 이벤트를 설치하고 이벤트 안에 함수를 설치      
이벤트가 실행됬을 때 이벤트 안에 있는 함수가 실행됨

```jsx
//App.js
class  App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      mode:'read',
      Subject: {title:'Web', sub:'World Wide Web!'},
      welcome:{title:'welcome', desc:'Hello React!'},
      contents:[
        {id:1, title:'HTML', desc:'HTML is....'},
        {id:2, title:'CSS', desc:'CSS is....'},
        {id:3, title:'JavaScript', desc:'JavaScript is....'},
      ]
    }

  }
  render() {
    var _title, _desc = null;
    if(this.state.mode === 'welcome') {
        _title = this.state.welcome.title;
        _desc = this.state.welcome.desc;
    }
    else if(this.state.mode === 'read'){
        _title = this.state.contents[0].title;
        _desc = this.state.contents[0].desc;
    }
    return (
      <div className="App">
        <Subject
          title={this.state.Subject.title}
          sub={this.state.Subject.sub}
          onChangePage={function() {  //  props로 사용자 정의 함수 정의
            this.setState({mode : 'welcome'})
          }.bind(this)}
          >
          </Subject>
        <TOC data={this.state.contents}></TOC>
        <Content  title={_title} des={_desc}></Content>
      </div>
    );
  }
}

```

하위 컴포넌트 코드로 들어가서 `this.props.함수이름()` 으로 함수 호출

- 원하는 곳에 사용하면 사용자 정의 이벤트로 동작함

```jsx
//Subject.js
class Subject extends Component {
    render() {
      return (
        <header>
              <h1><a href="/" onClick={function(e){ 
                e.preventDefault();
								//onClick이벤트 발생할 때 props로 전달받은 함수 실행
                this.props.onChangePage();  
              }.bind(this)}>{this.props.title}</a></h1>
              {this.props.sub}
        </header>
      );
    }
  }
```

#

### 이벤트에서 매개변수 사용

**이벤트 객체 이용**

```jsx
class TOC extends Component {
    render () {
      var list = [];
      var data = this.props.data;
      var i = 0;
      while(i < data.length){
        list.push(<li >
          <a 
          href={data[i].id}
          data-id={data[i].id}
          onClick={function (e) {
            e.preventDefault();
            this.props.onChangePage(e.target.dataset.id);
          }.bind(this)}
          >{data[i].title}
          </a>
          </li>);
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
```
이벤트 객체는 `target` 속성 있음
- 이벤트가 발생한 요소를 가리킴
    - 여기서는 `<a>`
- 이벤트 객체의 `target` 속성을 이용해 그 요소의 속성값 활용 가능

>이벤트 객체란?        
>- 이벤트 호출할 때 콜백함수의 첫 번째 인자, 여기서는 `e`    


속성값 중 이름이 `data-`(variable_name) 으로 시작하는 것은 해당 요소의 dataset에서 값을 확인할 수 있음        
- ex) data-id → 이벤트객체.target.dataset.id로 접근 가능  

#

**bind()의 매개변수 이용**

bind(this, `data_name`)
- `data_name` : bind()의 두번째 인자로 들어온 값은 bind()가 연결된 함수의 첫 번째 매개변수의 값으로 넣어줌

```jsx
class TOC extends Component {
    render () {
      var list = [];
      var data = this.props.data;
      var i = 0;
      while(i < data.length){
        list.push(<li >
          <a 
          href={data[i].id}
          onClick={function (id, e) {
            e.preventDefault();
            this.props.onChangePage(id);
          }.bind(this, data[i].id)}
          >{data[i].title}
          </a>
          </li>);
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
```

bind()의 두번째 인자인 `data[i].id`의 값은 onClick()의 콜백함수의 첫번째 매개변수 `id`로 들어감
- 기존에 있었던 변수는 뒤로 한칸씩 밀림
