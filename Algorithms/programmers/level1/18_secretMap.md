## 📝 비밀지도

[문제_비밀지도](https://programmers.co.kr/learn/courses/30/lessons/17681)

#

### 📍 코드(javascript)

**if문 사용**
- 주어진 배열을 이진수로 변환
  - 이진수로 변환했을 때 길이가 `n`보다 작으면 이진수 앞에 `0`을 붙이기
- 두 배열의 각 자리값을 비교해 `#` 또는 `' '(공백)`넣기 

```javascript
function solution(n, arr1, arr2) {
    var answer = [];
    
    arr1 = convertBinary(arr1, n);
    arr2 = convertBinary(arr2, n);
          
    for(let i = 0; i < n; i++) {
        let row = [];
        for(let j = 0; j < n; j++) {
            if(arr1[i][j] === '1' || arr2[i][j] === '1') {
                row.push('#');
            }
            if(arr1[i][j] === '0' && arr2[i][j] === '0') {
                row.push(' ');;
            }
        }
        answer.push(row.join(''));
    }
    
    
    return answer;
}

function convertBinary(arr, n) {
     arr.forEach((val, i) => {   
        if(n - val.toString(2).length > 0) {
          arr[i] = '0'.repeat(n - val.toString(2).length) + val.toString(2);
        }
        else {
            arr[i] = val.toString(2);
        }
        return arr[i];
    });
    
    return arr;
}
```

<br />
<br />
<br />

**`sigle vertical bar` , `replace()` 사용**
- `|`(sigle vertical bar) : 두 수를 이진수로 변환 후 더한 값을 10진수로 반환
- `arr1`의 각 줄과 `arr2`의 각 줄을 이진수로 변환 후 더한 값을 10진수로 반환
- 이것을 다시 이진수로 변환(`toString(2)`)
- `replace()` : 두 배열을 합쳐 만든 이차원 배열의 값에 따라 `#`, `' '(공백)` 넣기

```javascript
function solution(n, arr1, arr2) {
    let addedMap = '';
    addedMap = arr1.map((val, i) => convertBinary(n, (val | arr2[i]).toString(2)));
    
    return addedMap.map(v => v.replace(/1|0/g, (i) => i === '1' ? '#' : ' '))
    
}

function convertBinary(n, s) {
    return '0'.repeat(n - s.length) + s;
}
```

#

### 참고
- [`sigle vertical bar`](https://topic.alibabacloud.com/a/detailed-js-operator-single-vertical-bar--and---introduction-to-the-use-and-role-of-the-basic-knowledge_8_8_20088584.html) 
- [`Number.toString`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Number/toString)
