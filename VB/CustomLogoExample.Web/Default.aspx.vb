Imports System.Web.UI
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers

Partial Public Class [Default]
    Inherits BaseXafPage

    Protected Overrides Function CreateContextActionsMenu() As ContextActionsMenu
        Return New ContextActionsMenu(Me, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports")
    End Function
    Public Overrides ReadOnly Property InnerContentPlaceHolder() As Control
        Get
            Return Content
        End Get
    End Property
    Protected Sub Page_Init()
        AddHandler CustomizeTemplateContent, Sub(sender As Object, e As CustomizeTemplateContentEventArgs)
            Dim _content As DefaultVerticalTemplateContent = TryCast(TemplateContent, DefaultVerticalTemplateContent)
            If _content Is Nothing Then
                Return
            End If
            _content.HeaderImageControl.DefaultThemeImageLocation = ""
            _content.HeaderImageControl.ImageName = WebApplication.Instance.Model.Application.Logo
        End Sub
    End Sub
End Class
