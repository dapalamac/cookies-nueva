Public Class thanks
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        NameLabel.Text = Request.QueryString("name")

    End Sub

End Class