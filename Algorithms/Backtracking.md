# Backtracking 백트래킹
해를 찾아가는 도중, **지금의 경로가 해가 될 것 같지 않으면** 그 경로를 더이상 가지 않고 **되돌아가서 답을 찾아가는 기법**
- **가지치기** : 탐색 가능한 모든 경로를 탐색하는 게 아니라 답이 될 가능성이 없는 경로는 가지 않고 다시 이전으로 되돌아감
- 모든 경우의 수를 탐색하는 과정에서 **특정 조건을 만족하는 경우만 살펴보는 것**

<br />

> 📌 **DFS와 백트래킹**    
> `DFS` : 모든 경우의 수를 탐색하기 때문에 절대 답이 될 수 없는 경우도 탐색하게 됨!
> - 경우의 수를 줄이지 못하는 완전탐색 기법
> <br />
> 
> `백트래킹` : 답이 될 수 있는 경우의 수만 탐색
> - DFS보다 좋은 효율로 답을 찾을 수 있음


![image](https://user-images.githubusercontent.com/44824456/172112262-1105b2c1-4368-4bff-a497-00d99e02671b.png)


### 대표 문제
- **leetcode**
  - [combinations](https://leetcode.com/problems/combinations/)
  - [permutations](https://leetcode.com/problems/permutations/)
  - [letter case permutation](https://leetcode.com/problems/letter-case-permutation/)

----
## 참고
- [백트래킹](https://chanhuiseok.github.io/posts/algo-23/)
- [문제로 살펴보는 백트래킹](https://idea-sketch.tistory.com/29)
