using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.Templates;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;

public partial class Default : BaseXafPage {
    protected override ContextActionsMenu CreateContextActionsMenu() {
        return new ContextActionsMenu(this, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports");
    }
    public override Control InnerContentPlaceHolder {
        get {
            return Content;
        }
    }
    protected void Page_Init() {
        //Uncomment the code below if you use the Classic Web UI.
        //CustomizeTemplateContent += delegate(object sender, CustomizeTemplateContentEventArgs e) {
        //    DefaultVerticalTemplateContent content = TemplateContent as DefaultVerticalTemplateContent;
        //    if (content == null) return;
        //    content.HeaderImageControl.DefaultThemeImageLocation = "";
        //    content.HeaderImageControl.ImageName = "Logo";
        //};
    }

}
