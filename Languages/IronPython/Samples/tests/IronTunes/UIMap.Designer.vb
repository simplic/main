﻿'------------------------------------------------------------------------------
'  <auto-generated>
'      This code was generated by coded UI test builder.
'      Version: 10.0.0.0
'
'      Changes to this file may cause incorrect behavior and will be lost if
'      the code is regenerated.
'  </auto-generated>
' ------------------------------------------------------------------------------

Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Input
Imports Microsoft.VisualStudio.TestTools.UITest.Extension
Imports Microsoft.VisualStudio.TestTools.UITesting
Imports Microsoft.VisualStudio.TestTools.UITesting.WinControls
Imports Microsoft.VisualStudio.TestTools.UITesting.WpfControls
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard
Imports Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse
Imports MouseButtons = System.Windows.Forms.MouseButtons

Namespace IronTunes
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Partial Public Class UIMap
        
        '''<summary>
        '''ManipulateUI - Use 'ManipulateUIParams' to pass parameters into this method.
        '''</summary>
        Public Sub ManipulateUI()
            Dim uIIronTunesTitleBar As WpfTitleBar = Me.UIIronTunesWindow.UIIronTunesTitleBar
            Dim uIAddDirButton As WpfButton = Me.UIIronTunesWindow.UIAddDirButton
            Dim uIOKButton As WinButton = Me.UIBrowseForFolderWindow.UIOKWindow.UIOKButton
            Dim uIVolumeSlider As WpfSlider = Me.UIIronTunesWindow.UIVolumeSlider

            'Click 'IronTunes' title bar
            Mouse.Click(uIIronTunesTitleBar, New Point(490, 10))

            'Click 'Add Dir' button
            Mouse.Click(uIAddDirButton, New Point(49, 35))

            'Click 'OK' button
            Mouse.Click(uIOKButton, New Point(60, 9))

            'Set position '53.73' in 'Volume' slider
            uIVolumeSlider.PositionAsString = Me.ManipulateUIParams.UIVolumeSliderPositionAsString
        End Sub
        
        '''<summary>
        '''AssertVolume - Use 'AssertVolumeExpectedValues' to pass parameters into this method.
        '''</summary>
        Public Sub AssertVolume()
            Dim uIVolumeSlider As WpfSlider = Me.UIIronTunesWindow.UIVolumeSlider

            'Verify that 'Volume' slider's property 'Position' equals '53.73'
            Assert.AreEqual(Me.AssertVolumeExpectedValues.UIVolumeSliderPosition, uIVolumeSlider.Position)
        End Sub
        
        '''<summary>
        '''CloseIronTunes
        '''</summary>
        Public Sub CloseIronTunes()
            Dim uIIronTunesTitleBar As WpfTitleBar = Me.UIIronTunesWindow.UIIronTunesTitleBar
            Dim uICloseButton As WpfButton = Me.UIIronTunesWindow.UIIronTunesTitleBar.UICloseButton

            'Click 'IronTunes' title bar
            Mouse.Click(uIIronTunesTitleBar, New Point(640, 7))

            'Click 'Close' button
            Mouse.Click(uICloseButton, New Point(5, 13))
        End Sub
        
        #Region "Properties"
        Public Overridable ReadOnly Property ManipulateUIParams() As ManipulateUIParams
            Get
                If (Me.mManipulateUIParams Is Nothing) Then
                    Me.mManipulateUIParams = New ManipulateUIParams()
                End If
                Return Me.mManipulateUIParams
            End Get
        End Property
        
        Public Overridable ReadOnly Property AssertVolumeExpectedValues() As AssertVolumeExpectedValues
            Get
                If (Me.mAssertVolumeExpectedValues Is Nothing) Then
                    Me.mAssertVolumeExpectedValues = New AssertVolumeExpectedValues()
                End If
                Return Me.mAssertVolumeExpectedValues
            End Get
        End Property
        
        Public ReadOnly Property UIIronTunesWindow() As UIIronTunesWindow
            Get
                If (Me.mUIIronTunesWindow Is Nothing) Then
                    Me.mUIIronTunesWindow = New UIIronTunesWindow()
                End If
                Return Me.mUIIronTunesWindow
            End Get
        End Property
        
        Public ReadOnly Property UIBrowseForFolderWindow() As UIBrowseForFolderWindow
            Get
                If (Me.mUIBrowseForFolderWindow Is Nothing) Then
                    Me.mUIBrowseForFolderWindow = New UIBrowseForFolderWindow()
                End If
                Return Me.mUIBrowseForFolderWindow
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mManipulateUIParams As ManipulateUIParams
        
        Private mAssertVolumeExpectedValues As AssertVolumeExpectedValues
        
        Private mUIIronTunesWindow As UIIronTunesWindow
        
        Private mUIBrowseForFolderWindow As UIBrowseForFolderWindow
        #End Region
    End Class
    
    '''<summary>
    '''Parameters to be passed into 'ManipulateUI'
    '''</summary>
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class ManipulateUIParams
        
        #Region "Fields"
        '''<summary>
        '''Set position '53.73' in 'Volume' slider
        '''</summary>
        Public UIVolumeSliderPositionAsString As String = "53.73"
        #End Region
    End Class
    
    '''<summary>
    '''Parameters to be passed into 'AssertVolume'
    '''</summary>
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class AssertVolumeExpectedValues
        
        #Region "Fields"
        '''<summary>
        '''Verify that 'Volume' slider's property 'Position' equals '53.73'
        '''</summary>
        Public UIVolumeSliderPosition As Double = 53.73R
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UIIronTunesWindow
        Inherits WpfWindow
        
        Public Sub New()
            MyBase.New
            Me.SearchProperties(WpfWindow.PropertyNames.Name) = "IronTunes"
            Me.SearchProperties.Add(New PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains))
            Me.WindowTitles.Add("IronTunes")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIIronTunesTitleBar() As UIIronTunesTitleBar
            Get
                If (Me.mUIIronTunesTitleBar Is Nothing) Then
                    Me.mUIIronTunesTitleBar = New UIIronTunesTitleBar(Me)
                End If
                Return Me.mUIIronTunesTitleBar
            End Get
        End Property
        
        Public ReadOnly Property UIAddDirButton() As WpfButton
            Get
                If (Me.mUIAddDirButton Is Nothing) Then
                    Me.mUIAddDirButton = New WpfButton(Me)
                    Me.mUIAddDirButton.SearchProperties(WpfButton.PropertyNames.AutomationId) = "AddDir"
                    Me.mUIAddDirButton.WindowTitles.Add("IronTunes")
                End If
                Return Me.mUIAddDirButton
            End Get
        End Property
        
        Public ReadOnly Property UIVolumeSlider() As WpfSlider
            Get
                If (Me.mUIVolumeSlider Is Nothing) Then
                    Me.mUIVolumeSlider = New WpfSlider(Me)
                    Me.mUIVolumeSlider.SearchProperties(WpfSlider.PropertyNames.AutomationId) = "Volume"
                    Me.mUIVolumeSlider.WindowTitles.Add("IronTunes")
                End If
                Return Me.mUIVolumeSlider
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIIronTunesTitleBar As UIIronTunesTitleBar
        
        Private mUIAddDirButton As WpfButton
        
        Private mUIVolumeSlider As WpfSlider
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UIIronTunesTitleBar
        Inherits WpfTitleBar
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.SearchProperties(WpfTitleBar.PropertyNames.AutomationId) = "TitleBar"
            Me.WindowTitles.Add("IronTunes")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UICloseButton() As WpfButton
            Get
                If (Me.mUICloseButton Is Nothing) Then
                    Me.mUICloseButton = New WpfButton(Me)
                    Me.mUICloseButton.SearchProperties(WpfButton.PropertyNames.AutomationId) = "Close"
                    Me.mUICloseButton.WindowTitles.Add("IronTunes")
                End If
                Return Me.mUICloseButton
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUICloseButton As WpfButton
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UIBrowseForFolderWindow
        Inherits WinWindow
        
        Public Sub New()
            MyBase.New
            Me.SearchProperties(WinWindow.PropertyNames.Name) = "Browse For Folder"
            Me.SearchProperties(WinWindow.PropertyNames.ClassName) = "#32770"
            Me.WindowTitles.Add("Browse For Folder")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIOKWindow() As UIOKWindow
            Get
                If (Me.mUIOKWindow Is Nothing) Then
                    Me.mUIOKWindow = New UIOKWindow(Me)
                End If
                Return Me.mUIOKWindow
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIOKWindow As UIOKWindow
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "10.0.30319.1")>  _
    Public Class UIOKWindow
        Inherits WinWindow
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.SearchProperties(WinWindow.PropertyNames.ControlId) = "1"
            Me.WindowTitles.Add("Browse For Folder")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIOKButton() As WinButton
            Get
                If (Me.mUIOKButton Is Nothing) Then
                    Me.mUIOKButton = New WinButton(Me)
                    Me.mUIOKButton.SearchProperties(WinButton.PropertyNames.Name) = "OK"
                    Me.mUIOKButton.WindowTitles.Add("Browse For Folder")
                End If
                Return Me.mUIOKButton
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIOKButton As WinButton
        #End Region
    End Class
End Namespace