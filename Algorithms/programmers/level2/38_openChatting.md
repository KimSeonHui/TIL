## 📝 오픈채팅방

[오픈채팅방](https://programmers.co.kr/learn/courses/30/lessons/42888)

### 📍 내 풀이(javascript)
`Map`

```javascript
function solution(record) {   
    var answer = []; 
    const user = {};  // 입장한 user의 정보 담아둠
    
    record.forEach((val) => {
        const [state, uid, name] = val.split(' ');
        if(state === 'Enter'){
            if(!user[uid]) {
                user[uid] = {id : uid, name : name};  // 새로운 user의 아이디와 이름 저장
            }
            else {
                user[uid].name = name;  //들어왔던 방을 나갔다가 다시 입장했을 때 이름을 바꾸는 경우
            }
        }
        else if(state === 'Change') {
            user[uid].name = name;  // 채팅방에서 이름을 바꾸는 경우
        }
    });
    
    record.forEach((val) => {
        const [state, uid] = val.split(' ');
        if(state === 'Enter') { // 상태에 따라 id의 이름을 메세지와 함께 array에 저장
            answer.push(`${user[uid].name}님이 들어왔습니다.`);
        }
        else if(state === 'Leave') {
            answer.push(`${user[uid].name}님이 나갔습니다.`)
        }
    })
    
    
    return answer;
}
```

### 📍 다른 사람 풀이(javascript)
```javascript
function solution(record) {
    const userInfo = {}; // 채팅방에 들어온 user 정보(id : name) 저장
    const action = []; //채팅방에 들어온 user의 상태와 id 저장
    const stateMapping = {  //상태에 따른 메세지 
        'Enter': '님이 들어왔습니다.',
        'Leave': '님이 나갔습니다.'
    }

    record.forEach((v) => {
        const [state, id, nick] = v.split(' ');

        if(state !== "Change") {  //메세지를 출력해야하는 상태(Enter, Leave)만 저장
            action.push([state, id]);
        }

        if(nick) {  // user 정보 저장
            userInfo[id] = nick;
        }
    })

    return action.map(([state, uid]) => {  // 메세지 출력해야 하는 상태만 loop를 통해서 메세지 출력
        return `${userInfo[uid]}${stateMapping[state]}`;    
    })
}
```
