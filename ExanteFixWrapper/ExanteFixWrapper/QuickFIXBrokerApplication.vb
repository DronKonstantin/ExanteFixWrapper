﻿Imports QuickFix
Imports QuickFix44

Public Class QuickFIXBrokerApplication
    Implements QuickFix.Application
    Private orderStatusCallback As OrderStatusCallbackFIX = Nothing
    Delegate Sub OrderStatusCallbackFIX(message As QuickFix.Message)

    Private fixPassword As String
    Public Sub New(fixPassword As String, orderStatusCallback As OrderStatusCallbackFIX)
        Me.fixPassword = fixPassword
        Me.orderStatusCallback = orderStatusCallback
    End Sub
    Public Sub fromAdmin(Param As QuickFix.Message, Param1 As SessionID) Implements Application.fromAdmin

    End Sub

    Public Sub fromApp(message As QuickFix.Message, sessionID As SessionID) Implements Application.fromApp
        Dim messageType = New MsgType()
        message.getHeader().getField(messageType)
        If messageType.getValue() = MsgType.ExecutionReport Then
            orderStatusCallback.Invoke(message)
        End If

    End Sub

    Public Sub onCreate(Param As SessionID) Implements Application.onCreate

    End Sub

    Public Sub onLogon(sessionID As SessionID) Implements Application.onLogon

    End Sub

    Public Sub onLogout(Param As SessionID) Implements Application.onLogout

    End Sub

    Public Sub toAdmin(message As QuickFix.Message, sessionID As SessionID) Implements Application.toAdmin
        Dim msgType As MsgType = New MsgType()
        message.getHeader().getField(msgType)
        If msgType.getValue = QuickFix.MsgType.Logon Then
            message.setField(New Password(Me.fixPassword))
        End If
    End Sub

    Public Sub toApp(Param As QuickFix.Message, Param1 As SessionID) Implements Application.toApp

    End Sub

End Class
