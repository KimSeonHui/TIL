## 📝 신고 결과 받기

[문제_신고 결과 받기](https://programmers.co.kr/learn/courses/30/lessons/92334#)

### 📍 코드(javascript)

**접근방법**
1. 같은 사람이 한 사람을 계속 신고하는 경우도 있기 때문에 `report`에서 중복을 제거 
2. `user_id` : [`이 유저를 신고한 유저들`] 형식으로 `report`의 데이터를 가공
3. `신고한 유저들의 수 = 유저가 신고 당한 횟수`이기 때문에 신고한 유저들의 수가 `k`이상이면 신고한 유저의 `index`의 값을 증가

```javascript
function solution(id_list, report, k) {
    var answer = [];
    const data = {};
    report = [...new Set(report)];   // 1
    
    
    for(let i = 0; i < id_list.length; i++) {
        answer[i] = 0;
        data[id_list[i]] = [];
    }
    
    // 2
    report.map((val) => {
        let user = val.split(' ')[0];
        let reported = val.split(' ')[1];
        
        data[reported].push(user);
    })
    
    //console.log('data', data)   // data { muzi: ['apeach'],  frodo: ['muzi', 'apeach'],  apeach: [], neo: ['frodo', 'muzi']} 

    // 3
    Object.entries(data).forEach((val) => {
        if(val[1].length >= k) {
           for(let i = 0; i < val[1].length; i++) {
               answer[id_list.indexOf(val[1][i])]++;
           }
            
        }
    })

     
    return answer;
}
```
