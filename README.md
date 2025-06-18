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

- Unity 6  
- XR Interaction Toolkit  
- OpenXR + Oculus Quest 2  
- ProBuilder（用于地图编辑） / ProBuilder (맵 편집용)  
- GitHub（版本控制） / GitHub (버전 관리)

---

##  项目结构 / 프로젝트 구조
Assets/             
-  游戏资源、预制体、脚本  
-  게임 에셋, 프리팹, 스크립트

Scenes/             
-  场景文件，如主房间、通道等  
-  Unity 씬 파일들 (Main Room, Tunnel 등)

Scripts/            
-  交互控制、枪械逻辑、AI 脚本  
-  VR 인터랙션, 총기 로직, AI 스크립트

Materials/          
-  材质与贴图（复古风）  
-  메탈 재질 및 DOOM 스타일 텍스처

ProjectSettings/    
-  Unity 项目设置  
-  Unity 프로젝트 설정

.gitignore          
-  忽略缓存与编译临时文件  
-  캐시 및 임시 빌드 파일 무시

---
### 📦 素材来源 / 에셋 출처

- **Sketchfab**  
  🔗 [https://sketchfab.com](https://sketchfab.com)  
  查找并下载免费和付费 3D 模型（支持 Unity）  
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
