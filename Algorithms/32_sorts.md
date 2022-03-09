## 📝 가장 큰 수

[가장 큰 수]

### 📍 코드(javascript)

**접근방법**
1. 숫자들을 이어 붙여서 가장 큰 수를 만들어야 하기 때문에 각 수를 `Number`타입이 아니라 `String`타입으로 비교해 정렬    
2. `String`타입을 하나씩 붙여서 하나의 수를 만들기 때문에 각각의 값끼리 큰지를 비교하는게 아니라 조합해서 숫자를 만들었을 때, 더 큰 숫자를 만드는 것을 기준으로 비교해야함
    - ex) `'30'`, `'3'` : 각각 값끼리 보면 `'30'`이 `'3'`보다 크지만 `'303'(30+3)` 보다 `'330'(3+30)`이 크기 때문에 `3`이 `30`보다 큼
3. 만약 만들 수 있는 가장 큰 수가 `0`일 때 `String`타입이기 때문에 실제로 `answer`에 있는 값이 `'0000'`처럼 `'0'`이 여러개일 수도 있다.
    - 하지만 결국 가장 큰 수는 `0`이기 때문에 `'0'`으로 처리해야 함

```javascript
function solution(numbers) {
    var answer = '';
    answer = numbers.sort(compareFunc).join('');  // 1
    
    if(answer[0] === '0') {
        return '0';  // 3
    }
    
    return answer;
}


// 2
function compareFunc(a, b) {
    a = a.toString();
    b = b.toString();
    
    if(a+b < b+a) {
        return 1;
    }
    else if(a+b > b+a) {
        return -1;
    }
    else {
        return 0;
    }
}
```
