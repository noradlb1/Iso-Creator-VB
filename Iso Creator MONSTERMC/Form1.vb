Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Imports BER.CDCat.Export
Imports System.ComponentModel
Partial Public Class Form1
    Inherits Form
    Private Sub statusgood(log As String)
        'Create For Log Window
        lblStatus.Text = log & " -Status OK"
        'Do Events
        Call Application.DoEvents()
    End Sub
    Private Sub statusbad(log As String)
        lblStatus.Text = log & " -Status BAD"
        'Do Events
        Call Application.DoEvents()
    End Sub
    Private m_thread As Thread = Nothing
    Private m_creator As IsoCreator.IsoCreator = Nothing
    Private Delegate Sub SetLabelDelegate(text As String)
    Private Delegate Sub SetNumericValueDelegate(value As Integer)
    Private Sub creator_Abort(sender As Object, e As AbortEventArgs)
        MessageBox.Show(e.Message, "Abort", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        MessageBox.Show("The ISO creating process has been stopped.", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Button2.Invoke(New Action(Sub() Button2.Enabled = False))
        progressBar.Invoke(New Action(Sub() progressBar.Value = 0))
        progressBar.Invoke(New Action(Sub() progressBar.Maximum = 0))
        labelStatus.Invoke(New Action(Sub() labelStatus.Text = "Process not started"))
    End Sub

    Private Sub creator_Finished(sender As Object, e As FinishEventArgs)
        MessageBox.Show(e.Message, "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Button2.Invoke(New Action(Sub() Button2.Enabled = False))
        progressBar.Invoke(New Action(Sub() progressBar.Value = 0))
        labelStatus.Invoke(New Action(Sub() labelStatus.Text = "Process not started"))
        lblStatus.Invoke(New Action(Sub() lblStatus.Text = ""))
    End Sub
    Private Sub SetLabelStatus(text As String)
        labelStatus.Text = text
        labelStatus.Refresh()
    End Sub
    Private Sub SetProgressValue(value As Integer)
        progressBar.Value = value
    End Sub
    Private Sub SetProgressMaximum(maximum As Integer)
        progressBar.Maximum = maximum
    End Sub
    Private Sub creator_Progress(sender As Object, e As ProgressEventArgs)
        If Not Equals(e.Action, Nothing) Then
            If Not InvokeRequired Then
                SetLabelStatus(e.Action)
            Else
                Invoke(New SetLabelDelegate(AddressOf SetLabelStatus), e.Action)
            End If
        End If
        If e.Maximum <> -1 Then
            If Not InvokeRequired Then
                SetProgressMaximum(e.Maximum)
            Else
                Invoke(New SetNumericValueDelegate(AddressOf SetProgressMaximum), e.Maximum)
            End If
        End If
        If Not InvokeRequired Then
            progressBar.Value = If(e.Current <= progressBar.Maximum, e.Current, progressBar.Maximum)
        Else
            Dim value = If(e.Current <= progressBar.Maximum, e.Current, progressBar.Maximum)
            Invoke(New SetNumericValueDelegate(AddressOf SetProgressValue), value)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As FolderBrowserDialog = New FolderBrowserDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            txtPath.Text = dialog.SelectedPath
            textBoxVolumeName.Text = New DirectoryInfo(dialog.SelectedPath).Name & ".iso"
            Dim result = MessageBox.Show("Do you want to create an ISO of this folder?", "gg", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim savedialog = MessageBox.Show("Do you want to save the .iso in a custom location?", "ggggg", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If savedialog = DialogResult.No Then
                    If m_thread Is Nothing OrElse Not m_thread.IsAlive Then
                        If Not Equals(textBoxVolumeName.Text.Trim(), "") Then
                            m_thread = New Thread(New ParameterizedThreadStart(AddressOf m_creator.Folder2Iso))
                            m_thread.Start(New IsoCreator.IsoCreator.IsoCreatorFolderArgs(txtPath.Text, Application.StartupPath & "\" & textBoxVolumeName.Text, textBoxVolumeName.Text))

                            Button2.Enabled = True
                        Else
                            MessageBox.Show("Please insert a name for the volume", "No volume name", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        End If
                    End If
                ElseIf result = DialogResult.Yes Then
                    Dim savepath = String.Empty
                    Dim savename = String.Empty
                    Dim saveme As SaveFileDialog = New SaveFileDialog()
                    saveme.Filter = "PS3 Disk Images (*.iso)|*.iso"
                    If saveme.ShowDialog() = DialogResult.OK Then
                        savepath = saveme.FileName
                        savename = New FileInfo(saveme.FileName).Name
                        textBoxVolumeName.Text = savename
                        'TabControl1.SelectedIndex = 3
                    End If
                    If m_thread Is Nothing OrElse Not m_thread.IsAlive Then
                        If Not Equals(textBoxVolumeName.Text.Trim(), "") Then
                            m_thread = New Thread(New ParameterizedThreadStart(AddressOf m_creator.Folder2Iso))
                            m_thread.Start(New IsoCreator.IsoCreator.IsoCreatorFolderArgs(txtPath.Text, savepath, savename))

                            Button2.Enabled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If m_creator IsNot Nothing AndAlso m_thread IsNot Nothing AndAlso m_thread.IsAlive Then
            m_thread.Abort()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_creator = New IsoCreator.IsoCreator()
        AddHandler m_creator.Progress, New ProgressDelegate(AddressOf creator_Progress)
        AddHandler m_creator.Finish, New FinishDelegate(AddressOf creator_Finished)
        AddHandler m_creator.Abort, New AbortDelegate(AddressOf creator_Abort)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If m_creator IsNot Nothing AndAlso m_thread IsNot Nothing AndAlso m_thread.IsAlive Then
            m_thread.Abort()
            Button2.Enabled = False
        End If
    End Sub

    Private Sub LinkDiscord_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDiscord.LinkClicked

    End Sub

    Private Sub LinkTelegram_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkTelegram.LinkClicked

    End Sub

    Private Sub LinkYoutube_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkYoutube.LinkClicked

    End Sub

End Class

