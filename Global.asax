﻿<%@ Application Language="C#" %>

<script runat="server">
    void Application_Start(object sender, EventArgs e)  {
        System.Web.WebPages.WebPageHttpHandler.DisableWebPagesResponseHeader = true;
    }
</script>
