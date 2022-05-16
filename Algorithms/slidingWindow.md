# Sliding Window 슬라이딩 윈도우
전체 중 일부를 윈도우로 설정한 후 윈도우를 옆으로 밀어가면서(슬라이딩) 데이터 구조를 조작하는 알고리즘
- 데이터 구조에서 조건을 만족하는 최적의 **부분 집합을 찾는데 좋은 알고리즘**
- 문제에 따라 **윈도우의 범위를 적절하게 설정**하는 것이 중요

![image](https://user-images.githubusercontent.com/44824456/168564752-afff31a3-bb1a-4d52-af36-076fe03294b1.png)


> 📌 **접근 방식**
> - 윈도우의 범위가 **고정**
> - 윈도우의 범위가 **가변적** 

<br />

### 대표적인 문제
**슬라이딩 윈도우를 사용해서 풀 수 있는 문제**
- 배열에서 연속된 `k`개 요소들로 만들 수 있는 서브 배열 중 최댓값 찾기
- 문자열에서 `k` 길이를 가지는 모든 서브 스트링 찾기 

<br />

- **leet code**
   - [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) : 가변 범위
   - [Permutation in String](https://leetcode.com/problems/permutation-in-string/)  : 고정 범위


----
## 참고
- [Sliding window](https://towardsdev.com/sliding-window-algorithm-145f8e201a64)
