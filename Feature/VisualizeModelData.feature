Feature: VisualizeModelData
Scenario:_01 Verify Selected Model.
Given Go to url.
When Click on open DMA files button and upload file.
Then Select deformation Mode from dropdown.
| DeformationMode  |
| Tensile | 
And click on generate constitutive mechanical model button.
And verify Selected Model.



Scenario:_02 Verify Chart Type Dropdown.
Given Go to url.
When Click on open DMA files button and upload file.
Then Select deformation Mode from dropdown.
| DeformationMode  |
| Tensile | 
And click on generate constitutive mechanical model button.
And select chart type from dropdown.
|ChartType  |
| Simulated Tensile | 

Scenario:_03 Verify Chart save.
Given Go to url.
When Click on open DMA files button and upload file.
Then Select deformation Mode from dropdown.
| DeformationMode  |
| Tensile | 
And click on generate constitutive mechanical model button.
And click on save chart as png.
And verify file saved.