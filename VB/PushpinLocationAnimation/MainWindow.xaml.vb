Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Map
Imports System

Namespace LocationAnimation

	Partial Public Class MainWindow
		Inherits Window
		Private rand As New Random(CInt(Fix(DateTime.Now.Ticks)))

		Public Sub New()
			InitializeComponent()
			SelectRandomLocation()
		End Sub

		Private Sub PushpinLocationAnimation_Completed(ByVal sender As Object, ByVal e As EventArgs)
			SelectRandomLocation()
		End Sub

		Private Sub SelectRandomLocation()
			pushpin.Location = (New GeoPoint(rand.NextDouble() * 40, rand.NextDouble() * 40))
		End Sub
	End Class
End Namespace
