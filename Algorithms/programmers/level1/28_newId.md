## 📝 신규 아이디 추천

[문제_신규 아이디 추천](https://programmers.co.kr/learn/courses/30/lessons/72410)

>"네오"는 다음과 같이 7단계의 순차적인 처리 과정을 통해 신규 유저가 입력한 아이디가 카카오 아이디 규칙에 맞는 지 검사하고    
>규칙에 맞지 않은 경우 규칙에 맞는 새로운 아이디를 추천해 주려고 합니다.
>신규 유저가 입력한 아이디가 new_id 라고 한다면,

>- 1단계 new_id의 모든 대문자를 대응되는 소문자로 치환합니다.     
>- 2단계 new_id에서 알파벳 소문자, 숫자, 빼기(-), 밑줄(_), 마침표(.)를 제외한 모든 문자를 제거합니다.    
>- 3단계 new_id에서 마침표(.)가 2번 이상 연속된 부분을 하나의 마침표(.)로 치환합니다.    
>- 4단계 new_id에서 마침표(.)가 처음이나 끝에 위치한다면 제거합니다.    
>- 5단계 new_id가 빈 문자열이라면, new_id에 "a"를 대입합니다.    
>- 6단계 new_id의 길이가 16자 이상이면, new_id의 첫 15개의 문자를 제외한 나머지 문자들을 모두 제거합니다.    
 >    만약 제거 후 마침표(.)가 new_id의 끝에 위치한다면 끝에 위치한 마침표(.) 문자를 제거합니다.   
>- 7단계 new_id의 길이가 2자 이하라면, new_id의 마지막 문자를 new_id의 길이가 3이 될 때까지 반복해서 끝에 붙입니다.

> 신규 유저가 입력한 아이디를 나타내는 new_id가 매개변수로 주어질 때,     
> "네오"가 설계한 7단계의 처리 과정을 거친 후의 추천 아이디를 return 하도록 solution 함수를 완성해 주세요.


### 📍 코드(javscript)

```javascript
function solution(new_id) {
    var answer = new_id;
    
    answer = answer
            .toLowerCase()  //1
            .match(/[\w\-\.]/g).join('') //2
            .replace(/\.{2,}/g, '.') //3
            .replace(/^\.|\.$/g, '') //4
            .replace(/^$/, 'a') //5
    
    //6
    if(answer.length >= 16) {  
        answer = answer.slice(0, 15);
        if (answer[answer.length - 1] === '.') {
            answer = answer.slice(0, answer.length - 1);
        } 
    }
    
    //7
    else if(answer.length <= 2) {
        while(answer.length < 3) {
            answer += answer[answer.length - 1];
        }
    }  
    return answer;
}
```
