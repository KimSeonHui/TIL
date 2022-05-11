## 📝 문자열 압축

[문자열 압축](https://programmers.co.kr/learn/courses/30/lessons/60057)

### 📍 내 풀이(javascript)
`String`

```javascript
function solution(s) {
    let min = s.length;
    
    for(let i = 1; i <= Math.floor(s.length / 2); i++) {
        let compress = '';
        const cutting = cut(s, i);  // i개만큼 문자열 s를 자르기
        let count = 1;  
        
        for(let j = 0; j < cutting.length; j++) {
            if(compress.slice(-i) === cutting[j]) { // 같은 문자가 반복될 때 
                count += 1;
                if(count < 3) { // 반복되는 횟수가 3미만 일 때 압축 완료된 문자열까지만 가져오기
                  compress =  `${compress.substring(0,compress.length-i)}`;
                }
                else if(3 <= count && count <= 10) { // 반복되는 횟수가 3이상 10이하 일 때 압축 완료된 문자열까지만 가져오기
                     compress =  `${compress.substring(0,compress.length-i-1)}`;
                }
                else { // 반복되는 횟수가 10초과일 때 압축 완료된 문자열까지만 가져오기
                    compress =  `${compress.substring(0,compress.length-i-2)}`;
                }
                compress += `${count}${cutting[j]}`;
            }
            else {
                count = 1;
                compress += cutting[j];
            }
        }
        min = Math.min(min, compress.length);
       
    }
    return min;
}

function cut(s, num) {
    const result = [];
    let i = 0;
    
    for(i; i + num <= s.length; i += num) {
        result.push(s.substring(i, i + num));
    }
    
    if(s.substring(i) !== '') {
        result.push(s.substring(i));
    }

    return result;
}
```


### 📍 다른 사람 풀이(javascript)
```javascript
function solution(s) {
    if(s.length === 1 ) return 1;
    let min = 1000;
    for (let i = 1; i <= s.length / 2; i++) {
        let str1 = '';
        let str2 = '';
        let ans = '';
        let count = 1;
        for (let j = 0; j < s.length; j += i) {

            if( j === 0 ) {
                str1 = s.slice(j, j + i);
            }else{
                str2 = s.slice(j, j + i)  // i길이 만큼 문자열 가져오기
                if(str1 === str2){  // 같은 문자가 반복될 때 count만 증가
                    count++;
                    if(j+i === s.length) ans += `${count}${str1}`; // 마지막 문자일 때 

                }else{  // 반복이 안될 때(다른 문자가 등장했을 때 압축한 문자를 추가
                    if( count > 1 ){
                        ans += `${count}${str1}`  // 반복된 횟수와 문자 추가
                    }else{
                        ans += str1;
                    }
                    count = 1;
                    if(str1.length > str2.length){
                        ans += str2;
                    }
                    str1 = str2;
                    if(j+i === s.length) ans += str2; // 마지막 문자일 때 
                }
            }
        }
        min = Math.min(ans.length, min);
    }
    return min;
}
```
