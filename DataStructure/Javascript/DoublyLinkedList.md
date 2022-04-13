# Doubly Linked List 이중 연결 리스트
- 노드가 나란히 저장되어 있는 자료 구조
- 단일 연결 리스트와 다르게 `Head`, `Tail` 두 개의 노드를 가지고 있어서 처음에서 끝, 끝에서 처음으로 양방향 순회가 가능

 >  📌 **단일 연결 리스트와의 비교**    
 >  <br />
 >  단일 연결 리스트
 >  - `Head` 노드만 가지고 있어서 처음에서 끝 방향으로만 순회 가능
 >  - 중간에 노드가 끊어지면 그 뒤로는 접근 불가능, `Head` 노드 유실 시 전체 자료에 접근이 불가능
 >
 > <br />
 > 
 > 이중 연결 리스트
 >  - `Head`, `Tail` 두 개의 노드가 있어서 처음-끝, 끝-처음으로 순회 가능
 >  - `Head`, `Tail` 둘 중 하나의 노드를 유실해도 나머지 하나로 리스트를 순회할 수 있음

<br />

 >  📌 **노드**    
 >  각각의 노드들은 데이터, 이전 노드/다음 노드를 가리키는 포인터로 구성됨    
 >  첫 번째 노드의 이전 노드 항목, 마지막 노드의 다음 노드 항목은 `Null`을 가리킴

![image](https://user-images.githubusercontent.com/44824456/162963753-89f3cfad-551a-4eaa-825a-b3ebd514cc69.png)
###### [출처](https://untitledtblog.tistory.com/84)

## 구현

### 노드
```javascript
function Node(data) {
    this.data = (data !== undefined ) ? data : null,
    this.prev = null,
    this.next = null 
}

```

### DoblyLinked List
```javascript
function DoublyLinkedList() {
    this.length = 0;
    this.head = null;
    this.tail = null;
}
```

### 데이터 추가
`append(data)` : 연결 리스트 맨 마지막에 `data`를 가진 노드 추가     
`insert(index, data)` : `index` 위치에 `data`를 가진 노드 추가

```javascript
DoublyLinkedList.prototype.append = function(data) {
    const node = new Node(data);

    if(this.head === null) {
        this.head = node;
        this.tail = node;
    }
    else {
        this.tail.next = node;
        node.prev = this.tail;
        this.tail = node;
    }
    this.length++;
}


DoublyLinkedList.prototype.insert = function(data, index) {
    if(0 < index && index < this.length) {
        const node = new Node(data);
        let currentNode = this.head;
        let position = 0;

        while(currentNode.next !== null) {
            if(position === index) {
                currentNode.prev.next = node;
                node.prev = currentNode.prev;
                currentNode.prev = node;
                node.next = currentNode;
            }
            position++;
            currentNode = currentNode.next;
        }
        this.length++;
    }
}
```

### 데이터 삭제
`remove(data)` : `data`값을 가진 노드를 찾아 삭제    
`removeAt(index)` : `index`위치에 있는 노드를 찾아 삭제

```javascript
DoublyLinkedList.prototype.remove = function(data) {
    //방법 1
    let currentNode = this.head;
    let prevNode = currentNode;

    while(currentNode.next !== null && currentNode.data !== data) {
        currentNode = currentNode.next;
        prevNode = currentNode.prev;
    }

    if(currentNode.data === data) {
        prevNode.next = currentNode.next;
        currentNode.next.prev = prevNode;
        currentNode.next = null;
        currentNode.prev = null;
    }
    this.length--;

    //방법 2
    // let index = this.indexOf(data);
    // return this.removeAt(index);
}

DoublyLinkedList.prototype.removeAt = function(index) {
    if(0 < index && index < this.length) {
        let currentNode = this.head;
        let prevNode = currentNode;
        let position = 0;

        while(currentNode.next !== null && position !== index) {
            currentNode = currentNode.next;
            prevNode = currentNode.prev;

            position++;
        }

        prevNode.next = currentNode.next;
        currentNode.next.prev = prevNode;
        currentNode.next = null;
        currentNode.prev = null;

        this.length--;
    }
}
```

### 인덱스 찾기
`indexOf(data)` : `data`값을 가진 노드의 index를 리턴

```javascript
DoublyLinkedList.prototype.indexOf = function(data) {
    let index = 0;
    let currentNode = this.head;

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
DoublyLinkedList.prototype.size = function() {
    return this.length;
}
```

### 연결 리스트가 비었는지 아닌지 확인
`isEmpty()` : 연결 리스트가 비어있으면 `true`, 아니면 `false`를 리턴

```javascript
DoublyLinkedList.prototype.isEmpty = function() {
    return this.length === 0;
}
```

### 연결 리스트 데이터 출력
`printNode()` : 처음부터 끝까지 순서대로 노드의 데이터를 리턴            
`printNodeReverse()` : 끝에서부터 처음까지 순서대로 노드의 데이터를 리턴

```javascript
DoublyLinkedList.prototype.printNode = function() {
    let currentNode = this.head;
    let str = ``;

    while(currentNode.next !== null) {
        str += `${currentNode.data} -> `;
        currentNode = currentNode.next;
    }

    str += `${currentNode.data}`;

    return str;
}

DoublyLinkedList.prototype.printNodeReverse = function() {
    let  currentNode = this.tail;
    let str = ``;

    while(currentNode.prev !== null) {
        str += `${currentNode.data} -> `
        currentNode = currentNode.prev;
    }

    str += `${currentNode.data}`;

    return str;

}
```

### 사용

```javascript
const doubly = new DoublyLinkedList();
doubly.append(10); // 10
doubly.append(5);  // 10 -> 5
doubly.append(1);  // 10 -> 5 -> 1

doubly.insert(4, 1);  // 10 -> 4 -> 5 -> 1

//doubly.remove(5);   // 10 -> 4-> 1
//doubly.removeAt(1);  // 10 -> 1

console.log('dobuly', doubly);
console.log('size', doubly.size());  // 2
console.log('isEmpty', doubly.isEmpty());  // false
console.log('indexOf', doubly.indexOf(7));  // -1
console.log('printNode', doubly.printNode()); // 10 -> 1
console.log('printNodeReverse', doubly.printNodeReverse());  // 1 -> 10
```
