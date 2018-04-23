;#DropDB CustomizeTemplateContentExampleEasyTest

#Application CustomizeTemplateContentExample.Win
#Application CustomizeTemplateContentExample.Web

#IfDef CustomizeTemplateContentExample.Win

*Action About...
 
*Action OK

#EndIf

#IfDef CustomizeTemplateContentExample.Web

*Action Choose Theme(Black Glass)

#EndIf
