Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

Public Class PassVault
    Function GenerateKey() As String

        Dim desCrypto As DESCryptoServiceProvider = DESCryptoServiceProvider.Create()
        Return ASCIIEncoding.ASCII.GetString(desCrypto.Key)

    End Function
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

    Dim PasswordReader As Array
    Dim UserNameReader As Array
    Dim UserNameArray(1000) As String
    Dim PasswordArray(1000) As String
    Dim ArrayLength As Integer

    Private Sub CreateAccountBtn_Click(sender As Object, e As EventArgs) Handles CreateAccountBtn.Click

        LoginPasswordtxt.Clear()
        LoginUserNametxt.Clear()

        CreateAccountFrm.Show()
        Me.Hide()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt")
        End If
        Dim LoginUserName As String
        Dim LoginPassword As String
        Dim Counter As Integer = 0
        LoginUserName = LoginUserNametxt.Text
        LoginPassword = LoginPasswordtxt.Text

        LoginPasswordtxt.Clear()
        LoginUserNametxt.Clear()
        DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameEncrypted.txt", _
                    "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", _
                    My.Settings.LogKey)
        DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordEncrypted.txt", _
                     "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", _
                    My.Settings.PassKey)

        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt") Then
            ArrayLength = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt").Length
            PasswordReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt")
            UserNameReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt")
            UserNameArray = UserNameReader
            PasswordArray = PasswordReader
        End If
        Do Until Counter = ArrayLength
            If UserNameArray(Counter) = LoginUserName And PasswordArray(Counter) = LoginPassword Then
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt", Counter, True)
                AccountPasswordsFrm.Show()
                Me.Hide()
                Exit Do
            End If
            Counter = Counter + 1
        Loop
        Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt")
        Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt")
        If Counter = ArrayLength Then
            MsgBox("User Name Or Password Is Incorrect")
        End If
    End Sub

    Private Sub PassVault_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt") Or My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordEncrypted.txt") Then
        Else
            MsgBox("No Account Infomation On File")
        End If
    End Sub
End Class
