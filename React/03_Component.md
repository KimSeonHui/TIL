## Component
![image](https://user-images.githubusercontent.com/44824456/136783934-029964ee-a33a-4094-82a0-6237f8fdde04.png)

**정리정돈의 도구**
- 복잡하고 긴 `html`을 간단하게 표현
- 컴포넌트의 이름에 집중하게 함으로 코드의 복잡도를 낮춤

#

### 컴포넌트 사용하지 않은 html과 c컴포넌트 사용 비교
**html**
```html
<!DOCTYPE html>
<html>
    <body>
        <header>
            <h1> WEB </h1>
            world wide web!
      </header>        
    </body>
</html>
```

**Component**
```jsx
//App.js
class Subject extends Component {
  render() {
    return (
      <header>
            <h1> WEB </h1>
            world wide web!
        </header>
    );
  }
}

class  App extends Component {
  render() {
    return (
      <div className="App">
        <Subject></Subject>
      </div>
    );
  }
}
```
가독성 부분에서 훨씬 코드를 읽기 좋음!
`<Subject>`라는 이름으로 눈에 먼저 들어오기 때문에 html코드보다 복잡성이 줄어듬
>예시 코드라서 짧지만 만약! html코드가 1억줄이었다면??!! Component의 사용은 엄청나게 효과적일 것!

# 

>**여기서 사용하는 언어는??🙄🙄**
>**JSX**
>- 태그를 js에서 사용하기 위해서는 처리할게 많기 때문에 이를 위해 만들어진 언어
>- jsx로 작성하면 create-react-app이 자동으로 js로 바꿔주는 것

----
### 컴포넌트 생성
**기본 구조**
```jsx
class ComponetName extends Componente {
	render() {
		return(
					... 원하는 코드
		);
	}
}
```
`ComponetName`

- 첫 글자는 무조건 대문자로 시작해야 함!

`return`

- 웹브라우저에 표현하고자 하는  html 코드가 담김
- 이 때 반드시 하나의 최상위 태그로 시작해야함!
    - ex)
        
        ```jsx
        class Subject extends Component {
          render() {
            return (
              <header> //하나의 최상위 태그로 시작해야함!
                    <h1> WEB </h1>
                    world wide web!
                </header>
            );
          }
        }
        ```
#
        
**컴포넌트 사용**

```jsx
class  App extends Component {
  render() {
    return (
      <div className="App">
        ...만들어진 컴포넌트
      </div>
    );
  }
}
```

- 컴포넌트 기본구조를 따름
- 만들어진 컴포넌트를 html 태그처럼 넣음
    - ex)
    
    ```jsx
    class Subject extends Component {
      render() {
        return (
          <header>
                <h1> WEB </h1>
                world wide web!
            </header>
        );
      }
    }
    
    class  App extends Component {
      render() {
        return (
          <div className="App">
            <Subject></Subject>  //컴포넌트 사용!
          </div>
        );
      }
    }
    ```
