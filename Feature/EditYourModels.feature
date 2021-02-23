Feature: EditYourModels
Scenario:_01 Verify Searchbox of edit your Models.
Given Go to url.
When Click on Edit Your Models.
And click on searchbox button and send search input.
Then verify if searched model is filtered.

Scenario:_02 Delete selected Model.
Given Go to url.
When Click on Edit Your Models.
And Select on model to delete.
Then click on Delete Selected Models Button.
And click on button to confirm delete.

Scenario:_03 Update selected Model.
Given Go to url.
When Click on Edit Your Models.
And Select on model to be edited.
And Update model.
Then click on Update selected Model Button.
And verify that model was updated.

