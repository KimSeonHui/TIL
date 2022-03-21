# Linked List 연결 리스트
- 노드가 나란히 저장되어 있는 자료 구조
  - 메모리에 저장되어 있는 물리적 순서가 아님
- 순서에 상관없이 특정 위치에 데이터를 추가하거나 삭제하는 것에 효과적임
- 순차적으로 탐색해야 하기 때문에 접근 시간이 선형적이고 탐색 속도가 배열에 비해 떨어짐
- 병렬처리가 안됨

<br />

> 📌 **배열과 비교**    
> 탐색/정렬을 자주 하면 배열을 사용하는 게 효과적     
> 데이터의 추가/삭제가 많다면 연결 리스트를 사용하는 게 효과적
 
 <br />
 
 >  📌 **노드**    
 >  각각의 노드들은 데이터와 다음 노드를 가리키는 포인터로 구성됨    
 >  마지막 항목은 `Null`을 가리킴

![image](https://user-images.githubusercontent.com/44824456/159213555-e2948a39-b606-42c1-9e90-6412381eddf9.png)
###### [출처](https://siddharthschandran44.medium.com/linked-list-reordering-9613dd4d7a1f)


## 구현

### 노드
```javascript
function Node(data) {
    this.data = (data === undefined) ? 0 : data;
    this.next =  null;
}
```

### linked list
```javascript
function LinkedList() {
    this.length = 0;
    this.head = new Node('head');
    this.append = append;
    this.insert = insert;
    this.size = size;
    this.indexOf = indexOf;
    this.remove = remove;
    this.removeAt = removeAt;
    this.isEmpty = isEmpty;
    this.toString = toString;
}
```

### 데이터 추가
`append(data)` : 연결 리스트 맨 마지막에 `data`를 가진 노드 추가     
`insert(index, data)` : `index` 위치에 `data`를 가진 노드 추가

```javascript
function append(data) {
    const node = new Node(data);
    let currentNode = this.head;

    while(currentNode.next !== null) {
        currentNode = currentNode.next;
    }

    currentNode.next = node;
    this.length++;
}

function insert(index, data) {
    if(0 <= index && index < this.length) {
        const node = new Node(data);
        let currentNode = this.head;
        let prevNode = null;
        let i = 0;
    
        while(i <= index) {
            prevNode = currentNode;
            currentNode = currentNode.next;

            i++;
        }

        prevNode.next = node;
        node.next = currentNode;
        this.length++;
    }
    return null;
    
}
```

### 데이터 삭제
`remove(data)` : `data`값을 가진 노드를 찾아 삭제    
`removeAt(index)` : `index`위치에 있는 노드를 찾아 삭제

```javascript
function remove(data) {
    let index = this.indexOf(data);
    return this.removeAt(index);
}

function removeAt(index) {
    if(0 <= index && index < this.length) {
        let currentNode = this.head;
        let prevNode = null;
        let i = 0;

        while(i <= index) {
            prevNode = currentNode;
            currentNode = currentNode.next;

            i++;
        }

        prevNode.next = currentNode.next;
        currentNode.next = null;
        this.length--;

        return currentNode.data;
    }
    return null;
}
```

### 인덱스 찾기
`indexOf(data)` : `data`값을 가진 노드의 index를 리턴

```javascript
function indexOf(data) {
    let currentNode = this.head;
    let index = -1;

    while(currentNode !== null) {
        if(currentNode.data === data) {
            return index;
        }
        currentNode = currentNode.next;
        index++;
    }

    return -1;
}
```

### 연결 리스트 크기
`size()` : 연결 리스트의 길이를 리턴

```javascript
function size() {
    return this.length;
}
```

### 연결 리스트가 비었는지 아닌지 확인
`isEmpty()` : 연결 리스트가 비어있으면 `true`, 아니면 `false`를 리턴

```javascript
function isEmpty() {
    return (this.length === 0) ? true : false;
}
```

### 연결 리스트의 전체 요소를 `String`타입으로 전환
`toString()` : 연결 리스트의 요소를  `string`타입으로 리턴

```javascript
function toString() {
    let currentNode = this.head;
    const list = [];

    while(currentNode !== null) {
        if(currentNode.data !== 'head') {
            list.push(currentNode.data);
        }
        currentNode = currentNode.next;
    }

    return list.join(' ');
}
```

### 사용

```javascript
const list = new LinkedList();

list.append(10);
list.append(15);
list.append(15);
list.insert(0, 3);
console.log('list', list.toString())  // list 3 10 15 15

//list.removeAt(0);  // list 10 15 15
list.remove(15);  // list 3 10 15

console.log('size', list.size())  // 3
console.log('indexOf', list.indexOf(15)) // 2
console.log('isEmpty', list.isEmpty()) // false

```
