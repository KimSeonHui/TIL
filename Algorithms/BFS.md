# Breadth-Frist-Search 너비 우선 탐색
트리나 그래프를 탐색하는 알고리즘으로 **루트노드(임의의 노드)부터 시작해서 연결된 노드를 먼저 탐색하는 방법**
- 자식 노드들보다 **형제 노드를 우선적**으로 탐색
- 시작 노드와 가까운 노드를 먼저 방문하고 멀리 있는 노드를 나중에 방문
- 노드를 방문할 때 **방문 여부를 확인**을 해야 무한루프에 빠지지 않음
- ex) 한 반에 있는 모든 관계 중에서 A와 B 학생 사이의 연결된 관계를 찾을 때 A와 가까운 관계부터 찾아나감(`넓게`)

![BFS](https://user-images.githubusercontent.com/44824456/169266262-58a6abef-9dc9-4940-96e0-cce5e9d2ebe6.gif)

<br />

> 📌 **주로 사용하는 패턴**
> - 두 노드 사이의 최단 경로를 찾을 때
> - 두 노드 사이의 임의의 경로를 찾을 때

<br />

## 트리 노드 탐색 순서

![image](https://user-images.githubusercontent.com/44824456/169261649-f6c48175-e894-4582-af44-5db305034d8e.png)

**BFS Traversal** : 1 2 3 4 5

<br />

> 📌 **BFS와 DFS의 차이점?**    
> DFS는 Root 노드를 언제 방문하는지에 따라 운행법이 3가지로 나뉨
> - Preorder Traversal(`Root` -> Left -> Right)
> - Inorder Traversal(Left -> `Root` -> Right)
> - Postorder Traversal(Left -> Right -> `Root`)
> 
> **Preorder Traversal** :   1 2 4 5 3     
> **Inorder Traversal**  :  4 2 5 1 3     
> **Postorder Traversal** :  4 5 2 3 1

<br />

## 구현 방법
**Queue 이용**
- 시작하는 노드(루트 or 임의의 노드)를 방문했는지 확인
   - 탐색을 시작할 때는 queue에 시작하는 노드만 들어있음
- 현재 노드와 연결된 노드를 모두 방문 queue에 추가
- 현재 노드와 연결된 모든 노드를 방문한 후 queue에 있는 노드를 dequeue
- queue에서 꺼낸 노드를 기준으로 queue에 더이상 노드가 없을 때까지 위 과정을 반복
- [BFS 구현](https://gmlwjd9405.github.io/2018/08/15/algorithm-bfs.html)

<br />

## 대표 문제
- **leetcode**
   - [Maximun Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/)
   - [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/)
   - [Merge Two Binary Trees](https://leetcode.com/problems/merge-two-binary-trees)

<br />

## 참고
- [BFS](https://github.com/trekhleb/javascript-algorithms/tree/master/src/algorithms/tree/breadth-first-search)
