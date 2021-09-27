## Utilties_Flex
[Docs](https://getbootstrap.com/docs/5.1/utilities/flex/)

### Auto margins
 
`default` : 자동 마진 없음    
`me-auto` : 해당 요소 오른쪽으로 마진을 줌     
`ms-auto` : 해당 요소 왼쪽으로 마진을 줌      


![image](https://user-images.githubusercontent.com/44824456/134842676-218d2e51-92d1-4738-bb32-d5340f465326.png)     


```html
<div class="d-flex bd-highlight mb-3">
  <div class="me-auto p-2 bd-highlight">Flex item</div>
  <div class="p-2 bd-highlight">Flex item</div>
  <div class="p-2 bd-highlight">Flex item</div>
</div>

<div class="d-flex bd-highlight mb-3">
  <div class="p-2 bd-highlight">Flex item</div>
  <div class="p-2 bd-highlight">Flex item</div>
  <div class="ms-auto p-2 bd-highlight">Flex item</div>
</div>
```

#

## Utilties_Spacing

[Docs](https://getbootstrap.com/docs/5.1/utilities/spacing/)

### Notation

xs : `{{property}{sides}-{size}` 규칙 따름

sm, md, lg, xl, xxl : `{property}{sides}-{breakpoint}-{size}` 규칙 따름

#

**property**

`m` - set margine

`p` - set padding

#

**sides**

`t` - top

`b` - bottom

`s` - start : 시작 방향에 따라 left, right가 달라짐

`e` - end : 시작바향에 따라 left, right가 달라짐

`x` - left, right 모두

`y` - top, bottom 모두

빈칸 - 모든 방향

#

**size**

`0 ~ 5`

`auto` : 자동설정

```html
ms-2 
me-auto
```
