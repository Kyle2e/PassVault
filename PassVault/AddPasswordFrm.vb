Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

Public Class AddPasswordFrm

    Dim AccountNameLabel As String = "Account Name: "
    Dim AccountName As String = ""
    Dim Space1 As String = "" + Environment.NewLine
    Dim UserNameLabel As String = "User Name: "
    Dim UserName As String = ""
    Dim Space2 As String = "" + Environment.NewLine
    Dim PasswordLabel As String = "Password: "
    Dim Password As String = ""
    Dim Space3 As String = "" + Environment.NewLine
    Dim Line As String = "________________________________________________________"
    Dim AccountValidation As Integer
    Dim StringAccountValidation As String


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
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim ArrayLength As Integer
        Dim SecretKey As String
        Dim KeyReader As Array
        Dim OriginalKey As String = "0"
        Dim KeyArray(1000) As String
        Dim OriginalKeyArray(1000) As String
        Dim Counter2 As Integer = 0
        Dim Counter As Integer = 0
        SecretKey = GenerateKey()
        AccountValidation = My.Computer.FileSystem.ReadAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt")
        If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysEncrypted.txt") Then
            DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysEncrypted.txt", _
                    "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", _
                    My.Settings.Keys)
            Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\KeysEncrypted.txt")
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault") Then
            If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt") Then
                ArrayLength = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt").Length
                KeyReader = IO.File.ReadAllLines("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt")
                OriginalKeyArray = KeyReader
                OriginalKey = OriginalKeyArray(AccountValidation)
                Do Until Counter2 = ArrayLength
                    KeyArray(Counter2) = KeyReader(Counter2)
                    Counter2 = Counter2 + 1
                Loop
                KeyArray(AccountValidation) = SecretKey
            End If
        End If
        ArrayLength = ArrayLength + 1
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault") Then
            If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt") Then
                Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt")
                Do Until Counter = ArrayLength
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", KeyArray(Counter), True)
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", Space1, True)
                    Counter = Counter + 1
                Loop
                EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys" & "Encrypted" & ".txt", _
                            SecretKey)
                Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt")
            Else
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", SecretKey, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", Space1, True)
                EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys" & "Encrypted" & ".txt", _
                            SecretKey)
                Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt")
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\Pass Vault")
            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", SecretKey, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", Space1, True)
            EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys" & "Encrypted" & ".txt", _
                            SecretKey)
            Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\Keys.txt")
        End If
        My.Settings.Keys = SecretKey
        AccountName = AccountNametxt.Text
        UserName = UserNametxt.Text
        Password = Passwordtxt.Text
        StringAccountValidation = CStr(AccountValidation)
        AccountNametxt.Clear()
        UserNametxt.Clear()
        Passwordtxt.Clear()
        Dim FileReader2 As Array
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault") Then
            If My.Computer.FileSystem.FileExists("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Encrypted" & ".txt") Then
                DecryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Encrypted" & ".txt", _
                           "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt", _
                          OriginalKey)
                Dim Hello As String
                Dim ArrayAmount As Integer = 0
                FileReader2 = IO.File.ReadAllLines(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt"))
                Do Until ArrayAmount = FileReader2.Length
                    Hello = FileReader2(ArrayAmount)
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Hello, True)
                    My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                    ArrayAmount = ArrayAmount + 1
                Loop
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", AccountNameLabel, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", AccountName, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", UserNameLabel, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", UserName, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", PasswordLabel, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Password, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Line, True)
                My.Computer.FileSystem.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", Space1, True)
                EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Encrypted" & ".txt", _
                            SecretKey)
                'Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Decrypted" & ".txt")
                Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "A.txt")
                Me.Hide()
                AccountPasswordsFrm.Show()
            Else
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), AccountNameLabel, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), AccountName, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), UserNameLabel, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), UserName, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), PasswordLabel, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Password, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Line, True)
                My.Computer.FileSystem.WriteAllText(String.Concat("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt"), Space1, True)
                EncryptFile("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt", _
                            "C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & "Encrypted" & ".txt", _
                            SecretKey)
                Kill("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\AccountPassword" & StringAccountValidation & ".txt")
                Me.Hide()
                AccountPasswordsFrm.Show()
            End If
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        AccountValidation = My.Computer.FileSystem.ReadAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt")
        AccountNametxt.Clear()
        UserNametxt.Clear()
        Passwordtxt.Clear()

        Me.Hide()
    End Sub

    Private Sub AddPasswordFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountValidation = My.Computer.FileSystem.ReadAllText("C:\Users\" & Environment.UserName & "\Documents\Pass Vault\TempAccountValidation.txt")
    End Sub
End Class