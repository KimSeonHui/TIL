# Array 배열

- 박스가 칸칸이 이어져있는 자료구조
- 배열의 길이가 고정되어 있지 않기 때문에 배열의 길이가      
  늘어나거나 줄어들 수 있고 데이터를 연속적이지 않은 곳에 저장할 수 있음
- 배열 안에 들어가는 데이터(요소)의 자료형도 고정되어 있지 않음
- 0부터 인덱스가 시작

<br />

> 📌 **인덱스**
> - 박스의 번호
> - 인덱스로 배열의 특정 칸에 접근해서 안에     
>   담겨있는 데이터를 가져오거나 수정 할 수 있음

![image](https://user-images.githubusercontent.com/44824456/158733518-40153bdc-b49c-4cd6-a360-141983f6ed44.png)     

<br />


## 자주 사용하는 연산
#### 배열 생성
```javascript
const arr1 = new Array();
const arr2 = [1, 2];
```


#### 인덱스 위치
```javascript
const fruits = ['apple', 'banana'];

console.log(fruits)  //['apple', 'banana']
console.log(fruits.length)  //2
console.log(fruits[0])  //apple
console.log(fruits[2]) // undefined 인덱스 범위 초과
console.log(fruits[fruits.length - 1])  //banana
```

#### 배열의 모든 요소 가져오기
```javascript
// 1 for문
for(let i = 0; i < fruits.length; i++) {
    console.log(fruits[i]);
}

// 2 for of문
for(let f of fruits) {
    console.log(f);
}

// 3 forEach문
fruits.forEach((val) => {
    console.log(val)
})

// apple
// banana

```

#### 배열의 요소 추가
```javascript
// fruits = ['apple', 'banana']

//push : 배열의 맨 마지막에 데이터 추가
fruits.push('strawberry', 'peach');
console.log(fruits); // ['apple', 'banana', 'strawberry', 'peach']

//unshift : 배열의 맨 앞에서부터 데이터 추가
fruits.unshift('strawberry', 'peach');
console.log(fruits); //['strawberry', 'peach', 'apple', 'banana']

// splice : 특정 위치에 있는 요소를 삭제하고 다른 요소를 삽입
fruits.splice(1, 1, 'watermelon');
console.log(fruits);  // ['apple', 'watermelon']

```

#### 배열 요소 삭제
```javascript
// fruits = ['apple', 'banana', 'strawberry', 'peach']

//pop : 배열의 맨 마지막 데이터를 삭제하고 리턴
fruits.pop();
console.log(fruits);  //['apple', 'banana', 'strawberry']

// shift : 배열의 맨 앞에서부터 데이터 삭제하고 리턴
fruits.shift();
console.log(fruits); // ['banana', 'strawberry', 'peach']


// splice : 배열의 특정 위치에 있는 요소를 삭제
fruits.splice(1); // 시작한 위치부터 뒤의 모든 요소를 삭제 ['apple']
fruits.splice(1, 1); // 시작한 위치부터 명시된 갯수만큼 삭제 ['apple', 'strawberry', 'peach']
```

> 📌 **`shift()`, `unshift()`는 `pop()`, `push()`보다 훨씬 느리다**      
>  `pop()`, `push()`는 배열의 뒤에서 일어나기 때문에 빈 공간에 데이터를 넣거나 지우기 때문에 기존의 데이터는 이동하지 않는다.      
>  
>  반면, `shift()`, `unshift()`는 배열의 앞에서 일어나기 때문에 데이터를 추가할 때는 새로 추가되는 데이터 수만큼 기존에 있던 전체 데이터를 뒤로 이동해야 하며, 
>  데이터를 삭제할 때는 삭제후 남은 전체 데이터를 앞으로 이동해야 한다. 
>  
>  배열의 전체 데이터를 이동하기 떄문에 더 느리며 배열의 길이가 길면 길수록 이동해야 하는 데이터가 더 많아지기 때문에 더 느려진다. 

<br />

#### 두 배열을 합치기
```javascript
// fruits = ['apple', 'banana']

// concat : 두 배열을 결합해 새로운 배열을 리턴
const fruit2 = ['lemon', 'grape']
const newFruits = fruits.concat(fruit2);
console.log(newFruits);  // ['apple', 'banana', 'lemon', 'grape']
```

#### 배열의 요소의 인덱스 찾기
```javascript
//fruits = ['apple', 'watermelon', 'apple']

// indexOf : 배열에서 특정 요소 중 제일 처음 위치에 있는 인덱스를 반환
console.log(fruits.indexOf('apple')) // 0

// lastIndexOf : 배열에서 특정 요소 중 제일 마지막 위치에 있는 인덱스를 반환
console.log(fruits.indexOf('apple')) // 2
```

#### 배열에 찾는 요소가 있는지 확인
```javascript
//fruits = ['apple', 'watermelon', 'apple']

//includes : 특정 요소가 배열에 있다면 true, 없다면 false
console.log(fruits.includes('banana'))  //false
console.log(fruits.includes('watermelon')) //true
```

## 참고
- [forEach()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/forEach)
- [push()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/push)
- [unshift()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/unshift)
- [pop()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/pop)
- [shift()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/shift)
- [splice()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/splice)
- [concat()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/concat)
- [indexOf()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/indexOf)
- [lastIndexOf()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/lastIndexOf)
- [includes()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/includes)
