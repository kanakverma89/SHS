



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sharkspray_3M_QA

{
    class ObjectIdentifiers
    {
       
        public static readonly string _adhesiveDropdown = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[1]/div[1]/div/div/div/div";
        public static readonly string _pstt = "//div[contains(text(),'Pressure Sensitive Transfer Tape (PSA-ATT)')]";
        public static readonly string _psdct = "//body/div[@id='menu-newmodel_adhesive_type_select']/div[2]/ul[1]/li[2]";
        public static readonly string _vha = "//body/div[@id='menu-newmodel_adhesive_type_select']/div[2]/ul[1]/li[3]";
        public static readonly string _dropDmaFilesIdentifier = "//*[@id='dmaDrop']";
        public static readonly string _removeFileButton = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[2]/div/div[2]/a";
        public static readonly string _cancelUploadButton = "/html/body/div[@id='root']/div[@class='App']/div[@class='jss01']/main[@class='jss06']/div[2]/div/div[@class='jss0233']/div[@class='jss0261 jss0266 jss0262 jss0260 jss0235']/div/div[@class='jss0313 jss0322']/div[@id='dmaDrop']/div[@class='dz-preview dz-processing']/a[@class='dz-remove']";
        public static readonly string _fileDisplayTable = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[4]/div/div/div/div[3]/table/tbody/tr";
        public static readonly string _clearAllFilesButton = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[3]/span/span[1]";
        public static readonly string _generateConstitutiveModelBtn = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[5]/div/span";
        public static readonly string _deformationModeDropdownBtn = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[4]/div/div/div/div[3]/table/tbody/tr/td[8]/div/div/div/div";
        public static readonly string _density = "//*[@id='standard-number']";
        public static readonly string _replicateNumberDropdownBtn = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[4]/div/div/div/div[3]/table/tbody/tr/td[12]/div/div/div/div";
        public static readonly string _phase1 = "//div[contains(text(),'Phase 1 (DMA)')]";
        public static readonly string _phase2 = "/html/body/div[4]/div[2]/ul/li[2]";
        public static readonly string _phase3 = "/html/body/div[4]/div[2]/ul/li[3]";


        public static readonly string _deformModeVal1 = "/html/body/div[4]/div[2]/ul/li[1]";
        public static readonly string _deformModeVal2 = "/html/body/div[4]/div[2]/ul/li[2]";
             public static readonly string _deformModeVal3 = "/html/body/div[4]/div[2]/ul/li[3]";
        public static readonly string _deformModeVal4 = "/html/body/div[4]/div[2]/ul/li[4]";
        public static readonly string _deformModeVal5 = "/html/body/div[4]/div[2]/ul/li[5]";

        ///Visualize Model Data 
        public static readonly string _selectorModeIdentifier = "/html/body/div[3]/div/div/main/div[6]/div/div/div[1]/div/div/div[1]/div[1]/div/div/div";
        public static readonly string _chartTypeDropdown = "/html/body/div[3]/div/div/main/div[6]/div/div/div[1]/div/div/div[2]/div[1]/div/div/div";
        public static readonly string _chartTypeVal1 = "/html/body/div[5]/div[2]/ul/li[1]";
        public static readonly string _chartTypeVal2 = "/html/body/div[5]/div[2]/ul/li[2]";
        public static readonly string _chartTypeVal3 = "/html/body/div[5]/div[2]/ul/li[3]";
        public static readonly string _chartTypeVal4 = "/html/body/div[5]/div[2]/ul/li[4]";
        public static readonly string _chartTypeVal5 = "/html/body/div[5]/div[2]/ul/li[5]";
        public static readonly string _chartTypeVal6 = "/html/body/div[5]/div[2]/ul/li[6]";
        public static readonly string _chartTypeVal7 = "/html/body/div[5]/div[2]/ul/li[7]";
        public static readonly string _saveChartBtn = " /html/body/div[3]/div/div/main/div[6]/div/div/div[1]/div/div/div[2]/span[2]";

        //Export and save models
        
        public static readonly string _modelNameSelectButton = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[1]/div/div[3]/table/tbody/tr/td[1]/span/span[1]/input";
        public static readonly string _saveSelectedModelsButton = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[2]/span[1]/span[1]";
        public static readonly string _modelSavedTickIdentifier = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[1]/div/div[3]/table/tbody/tr/td[11]";
       public static readonly string _tick = "//*[local-name()='table' and @class ='jss01663']//*[local-name()='tbody' and @class='jss01705']//*[local-name()='tr' and @class='jss01668 jss01670 jss01669 jss01706']//*[local-name()='td' and @class='jss01677 jss01679 jss01708'][5]]//*[local-name()='svg' and @class='object SVGAnimatedString' and @style='fill: green;']";
        ///main/div[6]/div/div/div[2]/div/div/div[1]/div/div[3]/table/tbody/tr/td[11]/svg
        public static readonly string _tick1 = "#export > div > div > div.jss01444.jss01483.jss01497.jss01509.jss01523 > div > div.jss01644 > table > tbody > tr > td:nth-child(11) > svg ";

        ////html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[1]/div/div[3]/table/tbody/tr/td[11]/svg/path[2]

        public static readonly string _dmaUploadSecondFile = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[4]/div/div/div/div[3]/table/tbody/tr[2]/td[2]";

        //Load Your Models
        public static readonly string _loadYourModelsIdentifier = "/html/body/div[3]/div/div/div/div/div/div/div[2]/nav[1]/li[2]/div/p";
        public static readonly string _modelSearchboxButton = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[1]/div[2]/button";
        public static readonly string _modelSearchboxIdentifier = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[1]/div[1]/div/div/div/input";
        public static readonly string _modelNameIdentifier = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[3]/table/tbody/tr/td[3]";
        public static readonly string _modelNameCheckboxIdentifier = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[3]/table/tbody/tr[4]/td[1]/span/span[1]/input";
        public static readonly string _modelNameTextBox = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[1]";
        public static readonly string _loadConstitutiveModelButton = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[2]/div/span/span[1]";
        public static readonly string _visualizeModelDataButton = "/html/body/div[3]/div/div/div/div/div/div/div[2]/nav[2]/li[1]/div/p";
        public static readonly string _visualizeModelCss = "#root > div > div > div > div > div > div > div.jss0149 > nav:nth-child(4) > li.jss0184.jss0173.jss0176.jss0180.jss0181.jss0183.jss0171.jss0172 > div > p";

        //edit your models
        public static readonly string _editYourModelsIdentifier = "/html/body/div[3]/div/div/div/div/div/div/div[2]/nav[1]/li[3]/div/p";
        public static readonly string _searchboxEditModelButton = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[1]/div[2]/button";
        public static readonly string _searchBoxInputIdentifier = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[1]/div[1]/div/div/div/input";
        public static readonly string _checkboxEditModel = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[3]/table/tbody/tr[13]/td[1]/span/span[1]/input";
        public static readonly string _deleteSelectedModelBtn = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[2]/div/span[2]/span[1]";

        public static readonly string _deleteConfirmBtn = "/html/body/div[4]/div[2]/div[3]/button[2]";
        public static readonly string _modelEditCheckboxBtn = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[3]/table/tbody/tr[1]/td[1]/span/span[1]/input";
        public static readonly string _descrptionTextboxIdentifier = "//*[@id='edit_0_descinput']";
        public static readonly string _updateSelectedModelBtn = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[2]/div/span[1]/span[1]";


    }

}

