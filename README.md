# SpartaDungeon
 게임개발숙련주차 개인과제


## 과제중 어려웠던 점과 고찰

(이 부분 위주로 피드백해주시면 좋을 것 같습니다)

1. **인벤토리 장착기능에 delegate를 사용해보려하였으나 생각대로 작동하지 않음. 코드는 문제 없는 것 같은데 인벤토리 슬롯을 클릭해도 NPE가 뜨며 팝업이 안뜨네요...**  
2. 아이템에 대한 정보를 csv로 데이터테이블을 작성한 후, 아이템 고유 id값으로 csv를 호출해 정보를 가져오는 방식(db사용하듯이)에 대한 고민을 좀 해봤는데  
- 그때그때 Resources폴더의 csv파일에서 id를 기본키로 사용해서 검색하는 방식은 불가능한가? 혹은 비효율적이라 하지않는것인가?  
- 그렇다면 게임이 시작하기전에 미리 csv파일을 string으로 파싱해와서 LINQ로 검색하여 사용할텐데, 파싱한 string은 어디에 두어야하는가. 하이어라키창에 빈 오브젝트를 만들어서? Asset어딘가에?  
- 그럴바엔 그냥 SQL기반 DB를 연동하는게 더 편하지 않을까? SQLite같은걸 연동했을때와 비교하여 csv의 장단점은?  


-----------------

사실상 1번문제때문에 시간을 많이 잡아먹어서 2번은 시작도 못했네요

2번까지 완료 후 UI 이미지 채워넣으려했는데 1번이 안돼서 스프라이트가 공백으로 텅텅...
