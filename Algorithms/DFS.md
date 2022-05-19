# Depth-Frist-Search 깊이 우선 탐색
트리나 그래프를 탐색하는 알고리즘으로 **루트노드(임의의 노드)부터 시작해서 다음 분기로 넘어가기 전에 현재 분기를 완벽하게 탐색하는 방법**
- 형제 노드들보다 **자식 노드를 우선적**으로 탐색
- 모든 노드를 방문할 때 사용하는 탐색법
- 노드를 방문할 때 **방문 여부를 확인**을 해야 무한루프에 빠지지 않음
- ex) 미로를 갈 때 갈 수 있는 곳까지 가다가(`깊게`) 길이 없으면 처음 갈림길로 다시 돌아오는 것

![68747470733a2f2f75706c6f61642e77696b696d656469612e6f72672f77696b6970656469612f636f6d6d6f6e732f372f37662f44657074682d46697273742d5365617263682e676966](https://user-images.githubusercontent.com/44824456/169025775-a675cbe1-7c38-437f-9e6f-ad86594abf9c.gif)


## 트리 노드 탐색 순서
DFS는 Root 노드를 언제 방문하는지에 따라 운행법이 3가지로 나뉨
- Preorder Traversal(`Root` -> Left -> Right)
- Inorder Traversal(Left -> `Root` -> Right)
- Postorder Traversal(Left -> Right -> `Root`)

![image](https://user-images.githubusercontent.com/44824456/169261649-f6c48175-e894-4582-af44-5db305034d8e.png)

<br />

> **Preorder Traversal** :   1 2 4 5 3     
> **Inorder Traversal**  :  4 2 5 1 3     
> **Postorder Traversal** :  4 5 2 3 1

<br />

> 📌 **BFS와 DFS의 차이점?**    
> DFS는 트리 노드 운행법이 총 3가지로 나뉘지만 BFS는 한가지로 고정됨    
> BFS Traversal : 1 2 3 4 5

<br />


## 구현 방법
### 재귀 함수 이용
- 탐색을 시작하는 노드(루트 or 임의의 노드)를 방문했는지 확인
- 현재 노드가 방문하지 않은 노드이면 방문한 것으로 표시하고 현재 노드와 연결되어 있는 노드를 하니씩 확인
- 연결된 노드가 방문하지 않았다면 현재 노드를 기준으로 다시 위 과정을 반복(함수로 만들어 재귀로 호출) 

- [DFS_ 재귀로 구현](https://gmlwjd9405.github.io/2018/08/14/algorithm-dfs.html)

<br />

### 스택 이용
- 탐색을 시작하는 노드(루트 or 임의의 노드)를 스택에 추가하고 연결되어 있는 노드 중에 방문하지 않은 노드 확인
- 방문하지 않은 노드를 방문하고 스택에 추가, 또다시 방문하지 연결되어 있는 노드 중에 방문하지 않는 노드를 확인
- 연결되어 있는 노드 중에 방문하지 않은 노드가 없을 때까지 위 과정을 반복
- 현재 노드와 연결된 노드 중에 방문하지 않은 노드가 있는 곳까지 스택을 pop하며 노드를 거슬러 올라감
- 트리의 모든 노드를 방문할 때까지 위 과정을 반복

- [DFS_스택으로 구현](https://velog.io/@sohi_5/algorithmDFS)

<br />

## 대표 문제
- **leetcode**
   - [Flood Fill](https://leetcode.com/problems/flood-fill/)
   - [Max area of island](https://leetcode.com/problems/max-area-of-island/)


## 참고
- [DFS](https://github.com/trekhleb/javascript-algorithms/tree/master/src/algorithms/tree/depth-first-search)
- [BFS VS DFS](https://www.geeksforgeeks.org/bfs-vs-dfs-binary-tree/)
