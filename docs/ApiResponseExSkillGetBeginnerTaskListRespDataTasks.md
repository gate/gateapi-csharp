
# Io.Gate.GateApi.Model.ApiResponseExSkillGetBeginnerTaskListRespDataTasks

Getting started mission information. &#x60;task_center_id&#x60; and &#x60;status&#x60; are included in required: both are allowed to be 0 (registration tasks, download tasks to be received), And avoid Go SDK using omitempty for integer zero values, which will cause fields to be lost during client serialization.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WelfareTaskId** | **long** | Rewards Center task ID | [optional] 
**TaskCenterId** | **long** | Task center task ID (fixed at 0 for registration tasks) | 
**TaskType** | **int** | Task type: 1&#x3D;KYC secondary certification 2&#x3D;Spot 3&#x3D;Contract 4&#x3D;Invitation 5&#x3D;Quantification 6&#x3D;Yu Bibao 7&#x3D;startup 8&#x3D;First deposit 10&#x3D;Registration task 11&#x3D;Guide task 23&#x3D;Download task | [optional] 
**TaskName** | **string** | Task name | [optional] 
**TaskDesc** | **string** | Task description, may contain &lt;span&gt; highlight tags | [optional] 
**RewardNum** | **string** | Reward value | [optional] 
**RewardUnit** | **string** | Reward unit (e.g., USDT, BTC) | [optional] 
**PrizeType** | **int** | Reward type: 1 &#x3D; points, 2 &#x3D; regular coupon, 3 &#x3D; VIP coupon | [optional] 
**Status** | **int** | Task status: 0&#x3D;Not claimed (typically a download task waiting to be claimed) 1&#x3D;Received/in progress 2&#x3D;Completed and waiting to be claimed 3&#x3D;Rewards in progress 4&#x3D;Completed/settled 5&#x3D;Expired | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
