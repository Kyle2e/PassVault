Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

Public Class AccountPasswordsFrm

    Dim FileReader As Array
    Dim AccountValidation As Integer
    Dim StringAccountValidation As String

    Public Sub DecryptFile(ByVal sInputFilename As String, _
                    ByVal sOutputFilename As String, _
                     ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()

        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)

        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)

        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()

        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)

        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
        fsread.Close()
    End Sub
    Sub EncryptFile(ByVal sInputFilename As String, _
                  ByVal sOutputFilename As String, _
                  ByVal sKey As String)

        Dim fsInput As New FileStream(sInputFilename, _
                                    FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, _
                                    FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()

        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)


        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)


        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()

        Dim cryptostream As New CryptoStream(fsEncrypted, _
                                            desencrypt, _
                                            CryptoStreamMode.Write)


        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)

        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()
        fsInput.Close()
    End Sub

    Private Sub AccountPasswords_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        PassVault.Close()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Copybtn.Enabled = False
        Copybtn.Visible = False
        PasswordList.Items.Clear()
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & " \Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt") Then
            Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt")
        End If
        PassVault.Show()
        Me.Hide()
    End Sub

    Private Sub AddPasswordbtn_Click(sender As Object, e As EventArgs) Handles AddPasswordbtn.Click
        Copybtn.Enabled = False
        Copybtn.Visible = False
        Showbtn.Enabled = True
        Hidebtn.Enabled = True
        PasswordList.Items.Clear()
        AddPasswordFrm.Show()
    End Sub

    Private Sub AccountPasswordsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountValidation = My.Computer.FileSystem.ReadAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt")

        StringAccountValidation = CStr(AccountValidation)
        Showbtn.Enabled = False
        Hidebtn.Enabled = False
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Encrypted" & ".txt") Then
            Showbtn.Enabled = True
            Hidebtn.Enabled = True
        End If
    End Sub

    Private Sub Showbtn_Click(sender As Object, e As EventArgs) Handles Showbtn.Click
        AccountValidation = My.Computer.FileSystem.ReadAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt")
        StringAccountValidation = CStr(AccountValidation)
        Dim MasterKey As String = My.Settings.Keys
        Dim SecretKey As String = "0"
        Dim KeyReader As Array
        Dim KeyArray(1000) As String
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysEncrypted.txt") Then
            DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysEncrypted.txt", _
                    "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysDecrypted.txt", _
                    MasterKey)
            KeyReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysDecrypted.txt")
            KeyArray = KeyReader
            SecretKey = KeyArray(AccountValidation)
            Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysDecrypted.txt")
            DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Encrypted" & ".txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt", _
                            SecretKey)
        End If
        PasswordList.Items.Clear()
        If My.Computer.FileSystem.FileExists(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt")) Then
            FileReader = IO.File.ReadAllLines(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt"))
            Dim ArrayAmount As Integer = 0
            Do Until ArrayAmount = FileReader.Length
                PasswordList.Items.Add(FileReader(ArrayAmount))
                ArrayAmount = ArrayAmount + 1
            Loop
            Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt")
        Else
            PasswordList.Items.Add("")
        End If
    End Sub

    Private Sub Hidebtn_Click(sender As Object, e As EventArgs) Handles Hidebtn.Click
        Copybtn.Enabled = False
        Copybtn.Visible = False
        PasswordList.Items.Clear()
    End Sub

    Private Sub Copybtn_Click(sender As Object, e As EventArgs) Handles Copybtn.Click
            Clipboard.SetText(PasswordList.SelectedItem.ToString)
    End Sub

    Private Sub PasswordList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PasswordList.SelectedIndexChanged
        If PasswordList.SelectedIndex > 0 Then
            Copybtn.Enabled = True
            Copybtn.Visible = True
        Else
            Copybtn.Enabled = False
            Copybtn.Visible = False
        End If
    End Sub
End Class