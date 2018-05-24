Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers

Partial Public Class [Default]
    Inherits BaseXafPage

    Protected Overrides Function CreateContextActionsMenu() As ContextActionsMenu
        Return New ContextActionsMenu(Me, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports")
    End Function
    Protected Sub Page_Init()
        AddHandler CustomizeTemplateContent, Sub(s, e)
            Dim content As IHeaderImageControlContainer = TryCast(TemplateContent, IHeaderImageControlContainer)
            If content Is Nothing Then
                Return
            End If
            content.HeaderImageControl.DefaultThemeImageLocation = "Images"
                                                 content.HeaderImageControl.ImageName = "CustomLogoExample.Web.Images.CustomLogo.svg"
                                                 content.HeaderImageControl.Width = Unit.Pixel(100)
                                                 content.HeaderImageControl.Height = Unit.Pixel(40)
                                             End Sub

    End Sub
    Public Overrides ReadOnly Property InnerContentPlaceHolder() As Control
        Get
            Return Content
        End Get
    End Property
End Class
