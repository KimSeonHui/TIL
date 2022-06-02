# BST(Binary Search Tree) 이진 탐색 트리
- 규칙에 따라 데이터를 저장하는 트리

<br />

![image](https://user-images.githubusercontent.com/44824456/171639943-6108b1a7-0495-40c6-abe4-6f1f1e7e4408.png)

<br />

> 📌 **규칙**
> 1. 이진 탐색 트리의 노드에 저장된 값은 유일
> 2. 부모의 값이 왼쪽 자식 노드의 값보다 큼
> 3. 부모의 값이 오른쪽 자식 노드의 값보다 작음
> 4. 왼쪽/오른쪽 자식 트리도 이진 탐색 트리 

<br />

## 복잡도
이진 탐색 트리에서 탐색 연산은  `O(log n)` 시간 복잡도를 가짐
- 트리의 높이를 h라 했을 때 트리의 높이가 추가될 수록 노드의 수가 두배씩 증가하기 때문에 정확하게는 `O(h)` 시간 복잡도를 가짐


### 대표 문제
- **leetcode**
   - [ Search in a Binary Search Tree](https://leetcode.com/problems/search-in-a-binary-search-tree/)
   - [Insert into a Binary Search Tree](https://leetcode.com/problems/insert-into-a-binary-search-tree/)
   - [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/)
   - [Two Sum IV - Input is a BST](https://leetcode.com/problems/two-sum-iv-input-is-a-bst/)

<br />

## 참고
- [BST](https://github.com/JaeYeopHan/Interview_Question_for_Beginner/tree/master/DataStructure#binary-tree-%EC%9D%B4%EC%A7%84-%ED%8A%B8%EB%A6%AC)
