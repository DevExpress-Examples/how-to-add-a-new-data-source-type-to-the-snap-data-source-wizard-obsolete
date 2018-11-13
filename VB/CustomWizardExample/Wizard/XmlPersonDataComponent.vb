Imports System.Xml.Linq
Imports System.Collections.Generic
Imports DevExpress.DataAccess
Imports System.ComponentModel

Namespace CustomWizardExample.Wizard
    Public Class XmlPersonDataComponent
        Inherits List(Of Person)
        Implements IDataComponent

        Private Const xmlPersonDataSource As String = "Persons"
        Private Const xml_Name As String = "Name"
        Private Const xml_Person As String = "Person"
        Private Const xml_FirstName As String = "FirstName"
        Private Const xml_SecondName As String = "SecondName"


        Private ReadOnly fileName_Renamed As String
        Public Event Disposed As EventHandler Implements IComponent.Disposed

        Public Sub New(ByVal fileName As String)
            Me.fileName_Renamed = fileName
        End Sub

        Public Property Name() As String Implements IDataComponent.Name
        Public ReadOnly Property DataMember() As String Implements IDataComponent.DataMember
            Get
                Return String.Empty
            End Get
        End Property
        Public ReadOnly Property FileName() As String
            Get
                Return fileName_Renamed
            End Get
        End Property

        Public Property Site As ISite Implements IComponent.Site

        Public Sub Fill(ByVal sourceParameters As IEnumerable(Of DevExpress.Data.IParameter)) Implements IDataComponent.Fill
            Dim root = XDocument.Load(Me.fileName_Renamed).Root
            LoadFromXml(root)
        End Sub
        Public Sub LoadFromXml(ByVal element As XElement) Implements IDataComponent.LoadFromXml
            Clear()

            Dim name_Renamed As String = GetAttributeValue(element, xml_Name)
            If Not String.IsNullOrEmpty(name_Renamed) Then
                Name = name_Renamed
            End If
            For Each unit In element.Elements()
                Dim firstName = GetAttributeValue(unit, "FirstName")
                Dim secondName = GetAttributeValue(unit, "SecondName")
                Dim person = New Person() With {.FirstName = firstName, .SecondName = secondName}
                Add(person)
            Next unit
        End Sub
        Public Function SaveToXml() As XElement Implements IDataComponent.SaveToXml
            Dim element As New XElement(xmlPersonDataSource)

            If Not String.IsNullOrEmpty(Name) Then
                element.Add(New XAttribute(xml_Name, Name))
            End If
            For Each unit In Me
                Dim person As New XElement(xml_Person)
                person.Add(New XAttribute(xml_FirstName, unit.FirstName))
                person.Add(New XAttribute(xml_SecondName, unit.SecondName))
                element.Add(person)
            Next unit

            Return element
        End Function
        Private Function GetAttributeValue(ByVal element As XElement, ByVal attributeName As String) As String
            Dim attrbute As XAttribute = element.Attribute(attributeName)
            Return If(attrbute Is Nothing, Nothing, attrbute.Value)
        End Function

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
        End Sub
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            'do nothing
        End Sub
    End Class
End Namespace
