Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    'para que funciones se deben agreagar la siguientes librerias de importacion.
    'Imports System
    'Imports System.IO
    'Imports System.Security.Cryptography
    'Imports System.Text

    Public Function EncriptarCadena(ByVal Cadena As String) As String

        Dim ValorEncryptado As String
        Dim EncryptionKey As String = "INFASDOFNSDAFNSAF28374"
        Dim ClearBytes As Byte() = Encoding.Unicode.GetBytes(Cadena)

        Using Encryptor As Aes = Aes.Create()

            Dim pdb As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            Encryptor.Key = pdb.GetBytes(32)
            Encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()

                Using cs As CryptoStream = New CryptoStream(ms, Encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(ClearBytes, 0, ClearBytes.Length)
                    cs.Close()
                End Using

                ValorEncryptado = Convert.ToBase64String(ms.ToArray())

            End Using

        End Using

        Return ValorEncryptado

    End Function

    Public Function DesencriptarCadena(ByVal cipherText As String) As String

        Dim ValorDesencriptador As String
        Dim EncryptionKey As String = "INFASDOFNSDAFNSAF28374"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)

        Using Encryptor As Aes = Aes.Create()

            Dim pdb As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            Encryptor.Key = pdb.GetBytes(32)
            Encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()

                Using cs As CryptoStream = New CryptoStream(ms, Encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using

                ValorDesencriptador = Encoding.Unicode.GetString(ms.ToArray())

            End Using

        End Using

        Return ValorDesencriptador

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEncriptarCadena.Click
        lbEncrypter.Text = EncriptarCadena(txtTextoAEncryptar.Text.Trim())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDesencriptarCadena.Click
        txtTextoDesencriptado.Text = DesencriptarCadena(txtDesencryptar.Text.Trim())
    End Sub
End Class
