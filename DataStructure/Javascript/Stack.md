# Stack 스택
리스트의 한 쪽 끝으로만 자료의 삽입과 삭제가 일어나는 자료구조
- **LIFO(Last In First Out)** : 마지막에 들어온 자료가 가장 먼저 삭제 됨

<br />

> 📌 **대표 메서드**
> - **push** : 리스트의 마지막에 데이터를 추가
> - **pop** : 리스트의 마지막에 있는 데이터를 삭제
> - **peak** : 마지막에 리스트에 추가한 데이터를 반환

<br />

![image](https://user-images.githubusercontent.com/44824456/169272282-97b19d14-38e2-433e-8b9c-e6ff13abccae.png)

<br />


> 📌 **주로 사용되는 곳**     
> **`이전의 작업을 저장해놓을 때 주로 사용`**
> - 재귀 호출
> - 웹 브라우저 뒤로가기
> - 실행 취소
> - 후위 표기법

<br />


## 자바스크립트로 구현하기
```javascript
class Stack {
  constructor() {
    this._arr = [];
  }
  push(item) {
    this._arr.push(item);
  }
  pop() {
    return this._arr.pop();
  }
  peek() {
    return this._arr[this._arr.length - 1];
  }
}

const stack = new Stack();
stack.push(1);
stack.push(2);
stack.push(3);
stack.pop(); // 3
```
