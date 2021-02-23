Feature: LoadYourModels
	
Scenario:_01 Verify Searchbox
Given Go to url.
When Click on Load your Models .
Then search for a model.
And verify if model is retreived or not.

	
Scenario:_02 Model Name Selection.
Given Go to url.
When Click on Load your Models .
Then Select a model to load.
And Verify model selection.


Scenario:_03 Load Constitutive Mechanical Model Verification.
Given Go to url.
When Click on Load your Models .
Then Select a model to load.
And click on load constitutive mechanical model button.
And Verify load constitutive mechanical model button clicked.

