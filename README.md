# VR_DOOM
Unity 기반의 VR 슈팅 게임 프로토타입, 고전 DOOM 스타일에서 영감

---

## 프로젝트 소개
OOM은 빠른 전투 리듬, 복잡한 미로형 레벨 구성, 그리고 금속풍 아트 스타일로 잘 알려진 고전 1인칭 슈팅 게임입니다.
초기 FPS 게임의 기준을 정립했으며, 수많은 후속작들에 영향을 끼친 전설적인 타이틀입니다.
본 프로젝트는 DOOM 게임을 VR 환경에서 재현한 프로토타입입니다.
원작의 시각적 스타일과 박진감 넘치는 전투 리듬을 유지하면서, Unity 기반의 XR 기술을 통해 몰입도 높은 VR 경험을 구현하였습니다.
플레이어는 VR 헤드셋과 컨트롤러를 이용해 무기를 직접 잡고, 조준하고, 사격하며 재구성된 DOOM 세계를 탐험할 수 있습니다.
이 프로토타입은 향후 완성형 VR DOOM 게임 개발을 위한 기초 연구로 사용될 예정입니다.

---

## 구현 기능

- ** 기본 이동(이동 + 회전) **

  - “조이스틱/컨트롤러 터치패드”로 전후좌우 이동

  - “머리 방향”에 따라 시점 회전 제어

- ** 무기 사격 및 재장전 **

  - 트리거/트리거 버튼으로 원터치 사격

  - 탄약 소진 시 사격 불가

  - 사격 사운드 효과 추가

- ** 적 **
  - 일정 반경 내에서 플레이어 감지 시 추적 시작
  - 플레이어가 일정 거리 내에 들어오면 공격
  - 세 가지 대기 모드와 두 가지 공격 모드를 랜덤으로 전환
  - 공격 사운드 효과 추가

- ** 기본 UI **
  - 탄약 수, 체력 및 아머 실시간 표시
  - 사격 시 UI 애니메이션 피드백
  - 적 처치 시 탐험도(Exploration Rate) 증가 반영

- ** 상호작용 오브젝트 **
  - 획득 가능한 보급품(탄약 팩, 체력 팩, 아머 팩)
  - 상호작용 가능한 문: 문 근처에서 오른쪽 컨트롤러의 B 버튼을 누르면 문이 올라감
  - 포탈: 포탈에 들어가면 다른 씬 영역으로 이동

- ** 맵 및 사운드 효과 **
  - DOOM1의 E1M1 맵과 E1M2 맵을 구축하여 플레이어가 선택 가능
  - 전체 구간 동안 배경 음악을 루프 재생
  - 준비 로비 생성: 전투 맵에서 획득한 탐험도를 확인할 수 있음

---

##  技术栈 / 기술 스택

 - Unity 엔진 (MonoBehaviour, 씬 관리, 프리팹 인스턴싱)
 - C# (.NET) 언어 기능 (컬렉션, 이벤트 및 델리게이트, 싱글턴 패턴)
 - Unity 신규 입력 시스템 (Input System 패키지) + XR Interaction Toolkit
 - 물리 시스템 (Rigidbody, CharacterController, Physics.Raycast, 충돌/트리거)
 - 코루틴 및 비동기 로직 (Coroutine, WaitForSeconds)
 - 애니메이션 및 오디오 (Animator 상태 머신, AudioSource 재생)
 - UI 시스템 (Canvas, TextMeshProUGUI, 실시간 데이터 바인딩)
 - 데이터 관리 (Dictionary 저장, 게임 상태 싱글턴 관리)
 - 디버깅 지원 (Debug.Log 로그 출력)

---

## 설치 및 실행
- 사전 요구사항
  - Unity 에디터 버전: Unity 6000.0.44f1 (LTS) 이상
  - 다음 Unity 패키지 설치 필요:
    - Input System
    - XR Interaction Toolkit
    - TextMeshPro
  - VR 기기 (선택, 실기 테스트용): Oculus Quest 2 또는 OpenXR 호환 헤드셋

---

## 조작 설명
 - 왼손 엄지 스틱(Thumbstick): 이동
 - 왼손 X 버튼: 점프
 - 왼손 Y 버튼: UI 패널 표시/숨기기
 - 오른손 엄지 스틱(Thumbstick): 시점 전환
 - 오른손 트리거(Trigger): 사격
 - 오른손 그립 버튼(Grip Button): 무기 교체
 - 오른손 A 버튼: 점프
 - 오른손 B 버튼: 문 상호작용

---


### 에셋 출처

- **Sketchfab**  
  🔗 [https://sketchfab.com](https://sketchfab.com)    
  무료 및 유료 3D 모델 검색 및 다운로드 (Unity 지원)
  
- **Ammo Box**
  - Source: Unity Asset Store
  - Name: Ammo Box
  - Author: Beatheart Creative Studio
  - Link: https://assetstore.unity.com/packages/3d/props/weapons/ammo-box-7701
  - Usage: Used as Ammo Pickup in this project

- **First aid jar**
  - Source: Unity Asset Store
  - Name: First aid jar
  - Author: SIUP
  - Link: https://assetstore.unity.com/packages/3d/props/first-aid-jar-285566
  - Usage: Used as Health Pickup in this project
---
