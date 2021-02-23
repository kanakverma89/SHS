Feature: ExportandSaveModels

Scenario:_01 Loaded Models Selection.
Given Go to url.
When Click on open DMA files button and upload file.
Then Select deformation Mode from dropdown.
| DeformationMode  |
| Tensile | 
And click on generate constitutive mechanical model button.
And click on Model Name.
And Verify Selection Of Model Name.

Scenario:_02 'Save Selected Model' Button Verification.
Given Go to url.
When Click on open DMA files button and upload file.
Then Select deformation Mode from dropdown.
| DeformationMode  |
| Tensile | 
And click on generate constitutive mechanical model button.
And click on Model Name.
And  Click on Save Selected  Models Button.
And Verify Model saved.

