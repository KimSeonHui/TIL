## Props

html의 `attribute` 와 같음

props의 값을 받아서 서로 다른 결과를 보여주는 컴포넌트를 제작할 수 있음

- 코드의 재사용성을 엄청나게 높여줌

#

### 사용법

**App**

`<Component props_name="props_value">`

**컴포넌트 내부**

`{this.props.props_name}`

- `props_name` : 사용하고자 하는 props 이름

```jsx
class Subject extends Component {
  render() {
    return (
      <header>
            <h1> {this.props.title} </h1>
            {this.props.sub}
      </header>
    );
  }
}

class  App extends Component {
  render() {
    return (
      <div className="App">
        <Subject title="WEB" sub="world wide web"></Subject>
        <Subject title="React" sub="For ui"></Subject>
        <TOC></TOC>
        <Content></Content>
      </div>
    );
  }
}
```
![image](https://user-images.githubusercontent.com/44824456/137125837-bea1b76c-143a-4e51-bd72-185a958675b1.png)       

>**같은 `<Subject>` 컴포넌트지만 `props`값이 다르기 때문에 서로 다른 결과를 출력**

----
## State

`props` : 사용자가 컴포넌트를 사용하는 입장에서 조작하는 데이터

`state` : props의 값에 따라서 내부의 구현에 필요한 데이터

- 컴포넌트 내부적으로 사용되는 데이터
