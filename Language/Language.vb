Imports System.Windows.Forms
Public Class Language

#Region "Main"

	Public Sub UnmarkLanguages(english_ As ToolStripMenuItem, french_ As ToolStripMenuItem, thai_ As ToolStripMenuItem, yoruba_ As ToolStripMenuItem, chinese_ As ToolStripMenuItem, hausa_ As ToolStripMenuItem, igbo_ As ToolStripMenuItem)
		On Error Resume Next

		english_.Checked = False : french_.Checked = False : thai_.Checked = False : yoruba_.Checked = False : chinese_.Checked = False : hausa_.Checked = False : igbo_.Checked = False

	End Sub

	Public Sub MarkLanguage(s_language As ToolStripMenuItem, english_ As ToolStripMenuItem, french_ As ToolStripMenuItem, thai_ As ToolStripMenuItem, yoruba_ As ToolStripMenuItem, chinese_ As ToolStripMenuItem, hausa_ As ToolStripMenuItem, igbo_ As ToolStripMenuItem, Optional keyboard_ As ToolStripMenuItem = Nothing, Optional system_language As ToolStripMenuItem = Nothing)
		'		saveLanguage(s_language.Text)
		UnmarkLanguages(english_, french_, thai_, yoruba_, chinese_, hausa_, igbo_)

		Select Case s_language.Text
			Case "English"
				english_.Checked = True
			Case "français"
				french_.Checked = True
			Case "ไทย"
				thai_.Checked = True
			Case "Yorùbá"
				yoruba_.Checked = True
			Case "Hausa"
				hausa_.Checked = True
			Case "Igbo"
				igbo_.Checked = True
			Case "中文"
				chinese_.Checked = True
		End Select

		If keyboard_ IsNot Nothing Then
			AddHandler keyboard_.Click, New EventHandler(AddressOf KeyboardToolStripMenuItem_Click)
		End If
		If system_language IsNot Nothing Then
			AddHandler system_language.Click, New EventHandler(AddressOf SystemLanguageToolStripMenuItem_Click)
		End If
	End Sub

#End Region

#Region "Computer Memory Addresses"

	Public Sub KeyboardToolStripMenuItem_Click()
		Process.Start("osk")
	End Sub

	Public Sub SystemLanguageToolStripMenuItem_Click()
		Process.Start("Control", "/name Microsoft.Language")
	End Sub
#End Region

End Class
