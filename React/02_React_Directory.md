## React 앱 디렉토리
![image](https://user-images.githubusercontent.com/44824456/136783934-029964ee-a33a-4094-82a0-6237f8fdde04.png)
### public
![image](https://user-images.githubusercontent.com/44824456/136786272-067303a8-bbc4-41c0-bb7c-05b990b3b723.png)

`index.html` 이 있는 디렉토리

`index.html`
- 웹 브라우저에 보여지는 페이지
- `id=root` 인 곳에 만들어둔 컴포넌트를 넣어 웹 페이지에 뿌려줌
    - id=root 는 바꿀 수 있음

### src
![image](https://user-images.githubusercontent.com/44824456/136786381-2b98b108-153a-4300-956b-3f596e0aca01.png)

`index.html` 에서 보여줄 파일이 있는 디렉토리

**진입파일 - index.js**

```jsx
//index.js
import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

ReactDOM.render(
  <React.StrictMode>
    <App />  //react를 통해 만든 사용자 정의 태그
  </React.StrictMode>,
  document.getElementById('root') //이것을 기반으로 index.html에서 어디에 내용을 넣을지 결정
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
```

#

**APP.js**

```jsx
//실제 웹페이지에 보이는 부분을 구현
import React, {Component} from 'react';
import logo from './logo.svg';
import './App.css';
import { render } from '@testing-library/react';

class  App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            Edit <code>src/App.js</code> and save to reload.
          </p>
          <a
            className="App-link"
            href="https://reactjs.org"
            target="_blank"
            rel="noopener noreferrer"
          >
            Learn React
          </a>
        </header>
      </div>
    );
  }
}

export default App;
```

#

**app.css**

`app` 컴포넌트에 관한 디자인을 담당하는  css

**index.css**

웹브라우저에 보여지는 html 요소에 관한 디자인 담당하는  css
