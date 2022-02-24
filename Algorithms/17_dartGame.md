## 📝 다트 게임

[문제_다트 게임](https://programmers.co.kr/learn/courses/30/lessons/17682)

#

### 📍 코드(javascirpt)

**접근 방법**  

<br />

**1. `"점수|보너스|[옵션]"`으로 이뤄진 문자열 3세트를 세트별로 나누기**
  - 첫 숫자가 나온 후 다음 숫자가 나온 때까지가 한 세트
  - 세트별로 배열(`set`)에 넣기
  - 문자 `1` 후에 나온 문자가 `0`일 경우 문자열에 `0`을 추가후 `continue`를 통해 넘겨 `10` 구별

<br />

**2. 세트별 점수 계산**
  - 세트에서 보너스만 있을 경우(세트 문자열 길이 === 2), 옵션까지 있을 경우(세트 문자열 길이 === 3)로 나눠서 계산
  - `보너스 계산 ` : 보너스의 종류(`S`, `D`, `T`)에 따라 지수의 값을 설정후 점수와 지수곱 계산
  - `옵션 계산` : 옵션 종류(`*`, `#`)에 따라 현재 세트 값 또는 이전 세트 값까지 
  - 각 세트별 점수를 모두 더해 최종 점수 계산

<br />

```javascript
function solution(dartResult) {
    var answer = 0;
    let num = ['0', '1', '2', '3', '4','5','6','7','8','9','10'];
    let set = [];
    let temp = '';
    let score = [];
    
    for(let i = 0; i < dartResult.length; i++) {
        if(temp === '1' && dartResult[i] === '0') {
            temp += dartResult[i];
            continue;
        }
        if(num.includes(dartResult[i]) && i !== 0) {
            set.push(temp);
            temp = '';
        }
        temp += dartResult[i];  
    }
    set.push(temp);
    
    set.forEach((val, i) => {
        if(val.length === 2) {
            score.push(calZoneScore(val[0], val[1]));
        }
        if(val.length === 3) {
            if(val[1] !== '0') {
                    score.push(calZoneScore(val[0], val[1]));
                    calPriceScore(i, val[2],score);
                }
                else {
                    score.push(calZoneScore(val[0] + val[1], val[2]));
                } 
            }       
    });
    
    
    return score.reduce((acc, cur) => {
        return acc += cur;
    }, answer);
}

function calZoneScore (score, zone) {
    let exp = 0;
    switch(zone) {
        case 'S' :
            exp = 1;
            break;
            
        case 'D' :
            exp = 2;
            break;
            
        case 'T' :
            exp = 3;
            break;
    }
    return Math.pow(score, exp); 
}

function calPriceScore (i, price, score) {
    switch(price) {
        case '*' :
            if(i > 0) {
                score[i - 1] = score[i - 1] * 2;
                score[i] = score[i] * 2;
            }
            else {
                score[i] = score[i] * 2;
            }
            break;
            
        case '#' :
            score[i] = -score[i];
            break;
    }
}
```
