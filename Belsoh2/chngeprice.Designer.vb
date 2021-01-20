<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chngeprice
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.newprice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.currentprice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.changePrice2 = New DevExpress.XtraEditors.SimpleButton()
        Me.stockbox = New System.Windows.Forms.ListBox()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.searchprice = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl2 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newprice
        '
        Me.newprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newprice.Location = New System.Drawing.Point(17, 169)
        Me.newprice.Name = "newprice"
        Me.newprice.Size = New System.Drawing.Size(211, 44)
        Me.newprice.TabIndex = 22
        Me.newprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 29)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "New Price - Unit"
        '
        'currentprice
        '
        Me.currentprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentprice.Location = New System.Drawing.Point(17, 66)
        Me.currentprice.Name = "currentprice"
        Me.currentprice.ReadOnly = True
        Me.currentprice.Size = New System.Drawing.Size(211, 44)
        Me.currentprice.TabIndex = 22
        Me.currentprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Current Price - Unit"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.changePrice2)
        Me.GroupControl1.Controls.Add(Me.newprice)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.currentprice)
        Me.GroupControl1.Location = New System.Drawing.Point(408, 168)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(242, 324)
        Me.GroupControl1.TabIndex = 24
        Me.GroupControl1.Text = "Price"
        '
        'changePrice2
        '
        Me.changePrice2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changePrice2.Appearance.Options.UseFont = True
        Me.changePrice2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.changePrice2.ImageOptions.Image = Global.Belsoh2.My.Resources.Resources.replace_32x32
        Me.changePrice2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
        Me.changePrice2.Location = New System.Drawing.Point(44, 242)
        Me.changePrice2.Name = "changePrice2"
        Me.changePrice2.Size = New System.Drawing.Size(166, 57)
        Me.changePrice2.TabIndex = 26
        Me.changePrice2.Text = "Change "
        '
        'stockbox
        '
        Me.stockbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockbox.FormattingEnabled = True
        Me.stockbox.HorizontalScrollbar = True
        Me.stockbox.ItemHeight = 20
        Me.stockbox.Location = New System.Drawing.Point(12, 168)
        Me.stockbox.Name = "stockbox"
        Me.stockbox.ScrollAlwaysVisible = True
        Me.stockbox.Size = New System.Drawing.Size(374, 324)
        Me.stockbox.Sorted = True
        Me.stockbox.TabIndex = 25
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarHeaderItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 529)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(751, 35)
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "Connection"
        Me.BarHeaderItem1.Id = 6
        Me.BarHeaderItem1.ImageOptions.Image = Global.Belsoh2.My.Resources.Resources.radio_16x16
        Me.BarHeaderItem1.ImageOptions.LargeImage = Global.Belsoh2.My.Resources.Resources.radio_32x32
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "BarStaticItem2"
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.LeftIndent = 50
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.AllowDrawArrow = False
        Me.RibbonControl1.ExpandCollapseItem.AllowRightClickInMenu = False
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.searchprice, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarHeaderItem1, Me.RibbonGalleryBarItem1, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarEditItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 4
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.RibbonPageCategory1})
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1, Me.RepositoryItemSearchControl2})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl1.Size = New System.Drawing.Size(751, 164)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'searchprice
        '
        Me.searchprice.Caption = "Search"
        Me.searchprice.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.searchprice.Edit = Me.RepositoryItemSearchControl1
        Me.searchprice.EditWidth = 200
        Me.searchprice.Id = 1
        Me.searchprice.ImageOptions.Image = Global.Belsoh2.My.Resources.Resources.find_16x16
        Me.searchprice.ImageOptions.LargeImage = Global.Belsoh2.My.Resources.Resources.find_32x32
        Me.searchprice.Name = "searchprice"
        Me.searchprice.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Save"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.ImageOptions.LargeImage = Global.Belsoh2.My.Resources.Resources.save_32x32
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Cut"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.ImageOptions.LargeImage = Global.Belsoh2.My.Resources.Resources.cut_32x32
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Copy"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.LargeImage = Global.Belsoh2.My.Resources.Resources.copy_32x32
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Print"
        Me.BarButtonItem4.Id = 5
        Me.BarButtonItem4.ImageOptions.LargeImage = Global.Belsoh2.My.Resources.Resources.print_32x32
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "RibbonGalleryBarItem1"
        Me.RibbonGalleryBarItem1.Id = 7
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Search"
        Me.BarEditItem1.CaptionAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.BarEditItem1.Edit = Me.RepositoryItemSearchControl2
        Me.BarEditItem1.EditHeight = 30
        Me.BarEditItem1.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.BarEditItem1.EditValue = ""
        Me.BarEditItem1.EditWidth = 200
        Me.BarEditItem1.Id = 3
        Me.BarEditItem1.ImageOptions.Image = Global.Belsoh2.My.Resources.Resources.find_32x32
        Me.BarEditItem1.ImageOptions.LargeImage = Global.Belsoh2.My.Resources.Resources.find_32x32
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RepositoryItemSearchControl2
        '
        Me.RepositoryItemSearchControl2.AutoHeight = False
        Me.RepositoryItemSearchControl2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton(), New DevExpress.XtraEditors.Repository.MRUButton()})
        Me.RepositoryItemSearchControl2.FilterCondition = DevExpress.Data.Filtering.FilterCondition.StartsWith
        Me.RepositoryItemSearchControl2.FindDelay = 100
        Me.RepositoryItemSearchControl2.Name = "RepositoryItemSearchControl2"
        Me.RepositoryItemSearchControl2.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoShowClear
        Me.RepositoryItemSearchControl2.ShowMRUButton = True
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Text = "RibbonPageCategory1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.ImageOptions.Image = Global.Belsoh2.My.Resources.Resources.home_32x32
        Me.RibbonPage1.KeyTip = "H"
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Home"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1, "SA")
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2, "CU")
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3, "CO")
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4, "P")
        Me.RibbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows
        Me.RibbonPageGroup1.KeyTip = "0"
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.RibbonControl1
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(209, 108)
        Me.SearchControl1.MenuManager = Me.RibbonControl1
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton(), New DevExpress.XtraEditors.Repository.MRUButton()})
        Me.SearchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoShowClear
        Me.SearchControl1.Properties.ShowMRUButton = True
        Me.SearchControl1.Size = New System.Drawing.Size(333, 20)
        Me.SearchControl1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Search"
        '
        'chngeprice
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 564)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SearchControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.stockbox)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.MaximizeBox = False
        Me.Name = "chngeprice"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Belsoh Pharmacy"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newprice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents currentprice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents changePrice2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stockbox As ListBox
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents searchprice As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl2 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents Label3 As Label
End Class
