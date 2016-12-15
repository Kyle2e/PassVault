Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

Public Class CreateAccountFrm
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

    Dim AccountValidation As Integer
    Dim StringAccountValidation As String

    Private Sub Createbtn_Click(sender As Object, e As EventArgs) Handles Createbtn.Click

        Dim Space1 As String = "" + Environment.NewLine
        Dim CreateUserName As String
        Dim CreatePassword As String
        Dim RetypePassword As String
        Dim ArrayLength As Integer = 0
        Dim Counter As Integer = 0
        Dim Counter2 As Integer = 0
        Dim PasswordReader As Array
        Dim UserNameReader As Array
        Dim Validation1 As Boolean = False
        Dim Validation2 As Boolean = False
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault") Then
            If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt") Then
                ArrayLength = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt").Length
                PasswordReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt")
                UserNameReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt")
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\Pass Vault")
            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", "", True)
            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", "", True)
            ArrayLength = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt").Length
            PasswordReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt")
            UserNameReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt")
        End If

        CreateUserName = CreateUserNametxt.Text
        CreatePassword = CreatePasswordtxt.Text
        RetypePassword = RetypePasswordtxt.Text

        CreateUserNametxt.Clear()
        CreatePasswordtxt.Clear()
        RetypePasswordtxt.Clear()
        Do Until Counter = ArrayLength
            If CreateUserName = UserNameReader(Counter) Then
                MsgBox("User Name Is Already In Use")
                Exit Do
            End If
            Counter = Counter + 1
        Loop
        If Counter = ArrayLength Then
            Do Until Counter2 = ArrayLength
                If CreatePassword = PasswordReader(Counter2) Then
                    MsgBox("Password Is Already In Use")
                    Exit Do
                End If
                Counter2 = Counter2 + 1
            Loop
        End If
        If Counter = ArrayLength And Counter2 = ArrayLength Then
            Dim LogKey = GenerateKey()
            Dim PassKey = GenerateKey()
            If CreatePassword = RetypePassword Then
                If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault") Then
                    If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameEncrypted.txt") And My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordEncrypted.txt") Then
                        DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameEncrypted.txt", _
                                     "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameDecrypted.txt", _
                                    My.Settings.LogKey)
                        DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordEncrypted.txt", _
                                     "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordDecrypted.txt", _
                                    My.Settings.PassKey)
                        Dim FileReader3 As Array
                        Dim ArrayAmount As Integer = 0
                        Dim Hello As String
                        FileReader3 = IO.File.ReadAllLines(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameDecrypted.txt"))
                        Do Until ArrayAmount = FileReader3.Length
                            Hello = FileReader3(ArrayAmount)
                            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameA", Hello, True)
                            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameA", Space1, True)
                            ArrayAmount = ArrayAmount + 1
                        Loop
                        FileReader3 = IO.File.ReadAllLines(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordDecrypted.txt"))
                        Do Until ArrayAmount = FileReader3.Length
                            Hello = FileReader3(ArrayAmount)
                            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordA", Hello, True)
                            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordA", Space1, True)
                            ArrayAmount = ArrayAmount + 1
                        Loop
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameA.txt", CreateUserName, True)
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserNameA.txt", Space1, True)
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordA.txt", CreatePassword, True)
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPasswordA.txt", Space1, True)
                        EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", _
                                "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName" & "Encrypted" & ".txt", _
                                LogKey)
                        My.Settings.LogKey = LogKey
                        EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", _
                                "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword" & "Encrypted" & ".txt", _
                                PassKey)
                        My.Settings.PassKey = PassKey
                        Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt")
                        Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt")
                        PassVault.Show()
                        Me.Hide()
                    Else
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", CreateUserName, True)
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", Space1, True)
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", CreatePassword, True)
                        My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", Space1, True)
                        EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", _
                                "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName" & "Encrypted" & ".txt", _
                                LogKey)
                        My.Settings.LogKey = LogKey
                        EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", _
                                "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword" & "Encrypted" & ".txt", _
                                PassKey)
                        My.Settings.PassKey = PassKey
                        Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt")
                        Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt")
                        PassVault.Show()
                        Me.Hide()
                    End If
                Else
                    My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\Pass Vault")
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", CreateUserName, True)
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", Space1, True)
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", CreatePassword, True)
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", Space1, True)
                    EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName" & "Encrypted" & ".txt", _
                            LogKey)
                    My.Settings.LogKey = LogKey
                    EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword" & "Encrypted" & ".txt", _
                            PassKey)
                    My.Settings.PassKey = PassKey
                    Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginUserName.txt")
                    Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\LoginPassword.txt")
                    PassVault.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Passwords do not match")
                CreateUserNametxt.Clear()
                CreatePasswordtxt.Clear()
                RetypePasswordtxt.Clear()
            End If
        End If
    End Sub

    Private Sub CreateBackbtn_Click(sender As Object, e As EventArgs) Handles CreateBackbtn.Click

        CreateUserNametxt.Clear()
        CreatePasswordtxt.Clear()
        RetypePasswordtxt.Clear()

        PassVault.Show()
        Me.Hide()
    End Sub

    Private Sub CreateAcountFrm_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        PassVault.Close()
    End Sub
End Class