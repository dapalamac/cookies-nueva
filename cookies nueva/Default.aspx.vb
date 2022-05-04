Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim httpcookie As HttpCookie = Request.Cookies("UserInfo")

        If httpcookie Is Nothing Then

            textdiv.Visible = True

        Else

            msgDiv.Visible = True
            welcomelabel.Text = "Welcome back " & httpcookie.Values("ClientName")

        End If



    End Sub

    Protected Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click

        Dim httpcookie As New HttpCookie("UserInfo")
        httpcookie.Values.Add("ClientName", NameTextBox.Text)
        httpcookie.Expires = DateTime.Now.AddDays(1)

        Response.Cookies.Add(httpcookie)


        Response.Redirect("thanks.aspx?name=" & NameTextBox.Text)


    End Sub
End Class