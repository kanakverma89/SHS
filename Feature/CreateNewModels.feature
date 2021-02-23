Feature: CreateNewModels
Scenario:_01 Verify AdhesiveType dropdown.
Given Go to url.
When After landing on sharkspray page, click on AdhesiveType Dropdown.
Then Select adhesive type from dropdown.
| AdhesiveType                               |
| Pressure Sensitive Double-Coated Tape (PSA-DCT) |

Scenario:_03 DMA files upload verification.
Given Go to url.
When Click on open DMA files button and upload file.
Then Verify file upload.


Scenario:_04 Cancel Upload Button verification.
Given Go to url.
When Click on open DMA files button and upload file.
Then Click on cancel upload button to cancel uploading the file.
And click on OK from the popup to confirm upload cancellation.

Scenario:_05 Remove file button verification.
Given Go to url.
When Click on open DMA files button and upload file.
Then click on remove file button to remove the uploaded file.

Scenario:_06 Verifcation of display of files.
Given Go to url.
When Click on open DMA files button and upload file.
Then Verify file display.

Scenario:_07 Verification of Clear All Files Button.
Given Go to url.
When Click on open DMA files button and upload file.
Then Click on Clear All Files Button.
And Verify removal of files.

Scenario:_10 Verification of generate constitutive  mechanical model button.
Given Go to url.
When Click on open DMA files button and upload file.
Then Select deformation Mode from dropdown.
| DeformationMode  |
| Tensile | 
And click on generate constitutive mechanical model button.

Scenario:_02 Verify Model Phase Dropdown.
Given Go to url.
When After landing on sharkspray page, click on AdhesiveType Dropdown.
Then Select Model Phase from dropdown.
| ModelPhase   |
| Phase 2(DMA + Compression) | 

Scenario:_08 Verification of Deformation Mode dropdown.
Given Go to url.
When Click on open DMA files button and upload file.
Then Select deformation Mode from dropdown.
| DeformationMode  |
| Tensile | 

Scenario:_09 Verification of Density.
Given Go to url.
When Click on open DMA files button and upload file.
Then Send density value.

Scenario:_11 Multiple DMA file upload.
Given Go to url.
When Click on open DMA files button and upload file.
And Upload second dma file.
Then Verify multiple dma files upload.

