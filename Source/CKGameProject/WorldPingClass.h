// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Components/Image.h"
#include "WorldPingClass.generated.h"

UCLASS()
class CKGAMEPROJECT_API AWorldPingClass : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AWorldPingClass();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

	UPROPERTY(EditAnywhere,BlueprintReadWrite, Category = "WorldPing")
	UTexture2D* NewTexture;

	UPROPERTY(meta =(BindWidget))
	UImage* TargetImage;

	// 3. 에디터에서 값이 바뀌었을 때 실시간으로 반영하기 위한 함수
    virtual void OnWidgetRebuilt() override;
    
    // 블루프린트에서 값이 바뀔 때 호출하기 위한 함수
    virtual void SynchronizeProperties() override;
public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

};
