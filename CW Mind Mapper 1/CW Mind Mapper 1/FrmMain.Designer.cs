namespace CW_Mind_Mapper_1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.mmap = new DevComponents.Tree.TreeGX();
            this.nodeConnector2 = new DevComponents.Tree.NodeConnector();
            this.elementStyle1 = new DevComponents.Tree.ElementStyle();
            this.nodeConnector1 = new DevComponents.Tree.NodeConnector();
            this.elementStyle2 = new DevComponents.Tree.ElementStyle();
            this.elementStyle3 = new DevComponents.Tree.ElementStyle();
            this.elementStyle4 = new DevComponents.Tree.ElementStyle();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.zoom = new DevComponents.DotNetBar.Controls.Slider();
            this.controlContainerItem5 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.nodeinput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addnode = new DevComponents.DotNetBar.ButtonX();
            this.delnode = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.help = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem6 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.saveimage = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem4 = new DevComponents.DotNetBar.ControlContainerItem();
            this.buttonfile = new DevComponents.DotNetBar.ApplicationButton();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.reflectionLabel3 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.aboutpage = new DevComponents.DotNetBar.SuperTabItem();
            this.newfile = new DevComponents.DotNetBar.ButtonItem();
            this.openfile = new DevComponents.DotNetBar.ButtonItem();
            this.savefile = new DevComponents.DotNetBar.ButtonItem();
            this.savefileas = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusbar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.nowfile = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.filestatus = new DevComponents.DotNetBar.LabelItem();
            this.tabv = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.node1 = new DevComponents.Tree.Node();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.node2 = new DevComponents.Tree.Node();
            ((System.ComponentModel.ISupportInitialize)(this.mmap)).BeginInit();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonBar3.SuspendLayout();
            this.ribbonBar1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonBar4.SuspendLayout();
            this.ribbonBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).BeginInit();
            this.tabv.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // mmap
            // 
            this.mmap.AllowDrop = true;
            this.mmap.AutoScrollMinSize = new System.Drawing.Size(60, 33);
            this.mmap.BackColor = System.Drawing.Color.White;
            this.mmap.CellEdit = true;
            this.mmap.CommandBackColorGradientAngle = 90;
            this.mmap.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
            this.mmap.CommandMouseOverBackColorGradientAngle = 90;
            this.mmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmap.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
            this.mmap.Font = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mmap.Location = new System.Drawing.Point(1, 1);
            this.mmap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mmap.Name = "mmap";
            this.mmap.NodesConnector = this.nodeConnector2;
            this.mmap.NodeStyle = this.elementStyle1;
            this.mmap.PathSeparator = ";";
            this.mmap.RootConnector = this.nodeConnector1;
            this.mmap.Size = new System.Drawing.Size(985, 480);
            this.mmap.Styles.Add(this.elementStyle1);
            this.mmap.Styles.Add(this.elementStyle2);
            this.mmap.Styles.Add(this.elementStyle3);
            this.mmap.Styles.Add(this.elementStyle4);
            this.mmap.SuspendPaint = false;
            this.mmap.TabIndex = 0;
            this.mmap.Text = "图像保存";
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineWidth = 5;
            // 
            // elementStyle1
            // 
            this.elementStyle1.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2;
            this.elementStyle1.BackColorGradientAngle = 90;
            this.elementStyle1.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground;
            this.elementStyle1.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderBottomWidth = 1;
            this.elementStyle1.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
            this.elementStyle1.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderLeftWidth = 1;
            this.elementStyle1.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderRightWidth = 1;
            this.elementStyle1.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle1.BorderTopWidth = 1;
            this.elementStyle1.CornerDiameter = 4;
            this.elementStyle1.CornerType = DevComponents.Tree.eCornerType.Rounded;
            this.elementStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.PaddingBottom = 3;
            this.elementStyle1.PaddingLeft = 3;
            this.elementStyle1.PaddingRight = 3;
            this.elementStyle1.PaddingTop = 3;
            this.elementStyle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineWidth = 5;
            // 
            // elementStyle2
            // 
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle2.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.Tree.eCornerType.Rounded;
            this.elementStyle2.Description = "Blue";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 3;
            this.elementStyle2.PaddingLeft = 3;
            this.elementStyle2.PaddingRight = 3;
            this.elementStyle2.PaddingTop = 3;
            this.elementStyle2.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle3
            // 
            this.elementStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.elementStyle3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.elementStyle3.BackColorGradientAngle = 90;
            this.elementStyle3.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle3.BorderBottomWidth = 1;
            this.elementStyle3.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle3.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle3.BorderLeftWidth = 1;
            this.elementStyle3.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle3.BorderRightWidth = 1;
            this.elementStyle3.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle3.BorderTopWidth = 1;
            this.elementStyle3.CornerDiameter = 4;
            this.elementStyle3.CornerType = DevComponents.Tree.eCornerType.Rounded;
            this.elementStyle3.Description = "Yellow";
            this.elementStyle3.Name = "elementStyle3";
            this.elementStyle3.PaddingBottom = 3;
            this.elementStyle3.PaddingLeft = 3;
            this.elementStyle3.PaddingRight = 3;
            this.elementStyle3.PaddingTop = 3;
            this.elementStyle3.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle4
            // 
            this.elementStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.elementStyle4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(153)))), ((int)(((byte)(183)))));
            this.elementStyle4.BackColorGradientAngle = 90;
            this.elementStyle4.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle4.BorderBottomWidth = 1;
            this.elementStyle4.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle4.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle4.BorderLeftWidth = 1;
            this.elementStyle4.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle4.BorderRightWidth = 1;
            this.elementStyle4.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
            this.elementStyle4.BorderTopWidth = 1;
            this.elementStyle4.CornerDiameter = 4;
            this.elementStyle4.CornerType = DevComponents.Tree.eCornerType.Rounded;
            this.elementStyle4.Description = "SilverMist";
            this.elementStyle4.Name = "elementStyle4";
            this.elementStyle4.PaddingBottom = 3;
            this.elementStyle4.PaddingLeft = 3;
            this.elementStyle4.PaddingRight = 3;
            this.elementStyle4.PaddingTop = 3;
            this.elementStyle4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(113)))));
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonfile,
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(987, 135);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 2;
            this.ribbonControl1.Text = "ribbonBar";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel1.Size = new System.Drawing.Size(987, 76);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Controls.Add(this.zoom);
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem5});
            this.ribbonBar3.Location = new System.Drawing.Point(392, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(288, 74);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Text = "放大";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // zoom
            // 
            this.zoom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.zoom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.zoom.LabelWidth = 45;
            this.zoom.Location = new System.Drawing.Point(4, 15);
            this.zoom.Maximum = 400;
            this.zoom.Minimum = 20;
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(262, 23);
            this.zoom.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.zoom.TabIndex = 0;
            this.zoom.Text = "100%";
            this.zoom.Value = 100;
            this.zoom.ValueChanged += new System.EventHandler(this.zoom_ValueChanged);
            // 
            // controlContainerItem5
            // 
            this.controlContainerItem5.AllowItemResize = false;
            this.controlContainerItem5.Control = this.zoom;
            this.controlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem5.Name = "controlContainerItem5";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Controls.Add(this.nodeinput);
            this.ribbonBar1.Controls.Add(this.addnode);
            this.ribbonBar1.Controls.Add(this.delnode);
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1,
            this.controlContainerItem2,
            this.controlContainerItem3});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(389, 74);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "节点操作";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // nodeinput
            // 
            this.nodeinput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nodeinput.Border.Class = "TextBoxBorder";
            this.nodeinput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nodeinput.DisabledBackColor = System.Drawing.Color.White;
            this.nodeinput.ForeColor = System.Drawing.Color.Black;
            this.nodeinput.Location = new System.Drawing.Point(4, 13);
            this.nodeinput.Name = "nodeinput";
            this.nodeinput.PreventEnterBeep = true;
            this.nodeinput.Size = new System.Drawing.Size(169, 27);
            this.nodeinput.TabIndex = 2;
            this.nodeinput.WatermarkText = "在此处输入节点名称";
            this.nodeinput.TextChanged += new System.EventHandler(this.nodeinput_TextChanged);
            this.nodeinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // addnode
            // 
            this.addnode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addnode.BackColor = System.Drawing.Color.White;
            this.addnode.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.addnode.FocusCuesEnabled = false;
            this.addnode.Location = new System.Drawing.Point(178, 11);
            this.addnode.Name = "addnode";
            this.addnode.Size = new System.Drawing.Size(100, 30);
            this.addnode.Symbol = "";
            this.addnode.SymbolSize = 12F;
            this.addnode.TabIndex = 1;
            this.addnode.Text = "添加";
            this.addnode.Click += new System.EventHandler(this.addnode_Click);
            // 
            // delnode
            // 
            this.delnode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.delnode.BackColor = System.Drawing.Color.White;
            this.delnode.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.delnode.FocusCuesEnabled = false;
            this.delnode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delnode.Location = new System.Drawing.Point(283, 11);
            this.delnode.Name = "delnode";
            this.delnode.Size = new System.Drawing.Size(100, 30);
            this.delnode.Symbol = "";
            this.delnode.SymbolSize = 12F;
            this.delnode.TabIndex = 3;
            this.delnode.Text = "删除";
            this.delnode.Click += new System.EventHandler(this.delnode_Click);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.nodeinput;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.addnode;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.Control = this.delnode;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel2.Size = new System.Drawing.Size(987, 76);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Controls.Add(this.help);
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem6});
            this.ribbonBar4.Location = new System.Drawing.Point(200, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(116, 74);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar4.TabIndex = 1;
            this.ribbonBar4.Text = "查看帮助";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // help
            // 
            this.help.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.help.BackColor = System.Drawing.Color.White;
            this.help.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.help.FocusCuesEnabled = false;
            this.help.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.help.Location = new System.Drawing.Point(4, 11);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(106, 30);
            this.help.Symbol = "";
            this.help.SymbolSize = 12F;
            this.help.TabIndex = 2;
            this.help.Text = "帮助";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // controlContainerItem6
            // 
            this.controlContainerItem6.AllowItemResize = false;
            this.controlContainerItem6.Control = this.help;
            this.controlContainerItem6.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem6.Name = "controlContainerItem6";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Controls.Add(this.saveimage);
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem4});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(197, 74);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "图像保存";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // saveimage
            // 
            this.saveimage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveimage.BackColor = System.Drawing.Color.White;
            this.saveimage.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.saveimage.FocusCuesEnabled = false;
            this.saveimage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveimage.Location = new System.Drawing.Point(4, 11);
            this.saveimage.Name = "saveimage";
            this.saveimage.Size = new System.Drawing.Size(187, 30);
            this.saveimage.Symbol = "";
            this.saveimage.SymbolSize = 12F;
            this.saveimage.TabIndex = 0;
            this.saveimage.Text = "保存为图片格式";
            this.saveimage.Click += new System.EventHandler(this.saveimage_Click);
            // 
            // controlContainerItem4
            // 
            this.controlContainerItem4.AllowItemResize = false;
            this.controlContainerItem4.Control = this.saveimage;
            this.controlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem4.Name = "controlContainerItem4";
            // 
            // buttonfile
            // 
            this.buttonfile.AutoExpandOnClick = true;
            this.buttonfile.BackstageTab = this.superTabControl1;
            this.buttonfile.CanCustomize = false;
            this.buttonfile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonfile.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonfile.ImagePaddingHorizontal = 0;
            this.buttonfile.ImagePaddingVertical = 1;
            this.buttonfile.Name = "buttonfile";
            this.buttonfile.ShowSubItems = false;
            this.buttonfile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.buttonfile.Text = "文件";
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.ControlBox.Visible = false;
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.ItemPadding.Left = 6;
            this.superTabControl1.ItemPadding.Right = 4;
            this.superTabControl1.ItemPadding.Top = 4;
            this.superTabControl1.Location = new System.Drawing.Point(1, 1);
            this.superTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = false;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.superTabControl1.SelectedTabIndex = 7;
            this.superTabControl1.Size = new System.Drawing.Size(995, 676);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabHorizontalSpacing = 16;
            this.superTabControl1.TabIndex = 4;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.newfile,
            this.openfile,
            this.savefile,
            this.savefileas,
            this.aboutpage});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.TabVerticalSpacing = 8;
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel4.Controls.Add(this.reflectionLabel3);
            this.superTabControlPanel4.Controls.Add(this.reflectionLabel2);
            this.superTabControlPanel4.Controls.Add(this.reflectionLabel1);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(96, 0);
            this.superTabControlPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(899, 676);
            this.superTabControlPanel4.TabIndex = 4;
            this.superTabControlPanel4.TabItem = this.aboutpage;
            // 
            // reflectionLabel3
            // 
            this.reflectionLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reflectionLabel3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel3.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.reflectionLabel3.Location = new System.Drawing.Point(116, 478);
            this.reflectionLabel3.Name = "reflectionLabel3";
            this.reflectionLabel3.Size = new System.Drawing.Size(685, 138);
            this.reflectionLabel3.TabIndex = 0;
            this.reflectionLabel3.Text = "Copyright, CW, 2014. All Right Reserved.";
            // 
            // reflectionLabel2
            // 
            this.reflectionLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reflectionLabel2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.reflectionLabel2.Location = new System.Drawing.Point(147, 230);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(702, 261);
            this.reflectionLabel2.TabIndex = 0;
            this.reflectionLabel2.Text = "                   本程序由\r\n北京四中 2016届 初二(3)班 陈为\r\n                   制作出品";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reflectionLabel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(26, 47);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(880, 189);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "CW Mind Mapper 1.0.0";
            // 
            // aboutpage
            // 
            this.aboutpage.AttachedControl = this.superTabControlPanel4;
            this.aboutpage.GlobalItem = false;
            this.aboutpage.KeyTips = "H";
            this.aboutpage.Name = "aboutpage";
            this.aboutpage.Text = "关于";
            // 
            // newfile
            // 
            this.newfile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.newfile.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.newfile.ImagePaddingHorizontal = 18;
            this.newfile.ImagePaddingVertical = 10;
            this.newfile.Name = "newfile";
            this.newfile.Stretch = true;
            this.newfile.Text = "  新建";
            this.newfile.Click += new System.EventHandler(this.newfile_Click);
            // 
            // openfile
            // 
            this.openfile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.openfile.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.openfile.ImagePaddingHorizontal = 18;
            this.openfile.ImagePaddingVertical = 10;
            this.openfile.Name = "openfile";
            this.openfile.Stretch = true;
            this.openfile.Text = "  打开";
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // savefile
            // 
            this.savefile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.savefile.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.savefile.ImagePaddingHorizontal = 18;
            this.savefile.ImagePaddingVertical = 10;
            this.savefile.Name = "savefile";
            this.savefile.Stretch = true;
            this.savefile.Text = "  保存";
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // savefileas
            // 
            this.savefileas.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.savefileas.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.savefileas.ImagePaddingHorizontal = 18;
            this.savefileas.ImagePaddingVertical = 10;
            this.savefileas.Name = "savefileas";
            this.savefileas.Stretch = true;
            this.savefileas.Text = "  另存为";
            this.savefileas.Click += new System.EventHandler(this.savefileas_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer4});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.galleryContainer1});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            // 
            // 
            // 
            this.galleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "实用工具";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "其他工具";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // statusbar
            // 
            // 
            // 
            // 
            this.statusbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusbar.ContainerControlProcessDialogKey = true;
            this.statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusbar.DragDropSupport = true;
            this.statusbar.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.nowfile,
            this.labelItem1,
            this.filestatus});
            this.statusbar.Location = new System.Drawing.Point(5, 652);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(987, 24);
            this.statusbar.TabIndex = 5;
            this.statusbar.Text = "状态栏";
            // 
            // nowfile
            // 
            this.nowfile.Name = "nowfile";
            this.nowfile.Text = "新文件";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "|";
            this.labelItem1.Visible = false;
            // 
            // filestatus
            // 
            this.filestatus.Name = "filestatus";
            this.filestatus.Text = "未保存";
            this.filestatus.Visible = false;
            // 
            // tabv
            // 
            this.tabv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabv.AutoCloseTabs = true;
            this.tabv.BackColor = System.Drawing.Color.White;
            this.tabv.CanReorderTabs = true;
            this.tabv.CloseButtonOnTabsVisible = true;
            this.tabv.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabv.CloseButtonVisible = true;
            this.tabv.Controls.Add(this.tabControlPanel1);
            this.tabv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabv.ForeColor = System.Drawing.Color.Black;
            this.tabv.Location = new System.Drawing.Point(0, 0);
            this.tabv.Name = "tabv";
            this.tabv.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabv.SelectedTabIndex = 0;
            this.tabv.Size = new System.Drawing.Size(987, 515);
            this.tabv.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabv.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Bottom;
            this.tabv.TabIndex = 1;
            this.tabv.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabv.Tabs.Add(this.tabItem1);
            this.tabv.Text = "tabv";
            this.tabv.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabv_SelectedTabChanged);
            this.tabv.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabv_TabItemClose);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.mmap);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 0);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(987, 482);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Top)));
            this.tabControlPanel1.Style.GradientAngle = -90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "tabItem1";
            this.tabItem1.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tabv);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(5, 136);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(987, 540);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Text = "buttonX1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG Files | *.png";
            this.saveFileDialog1.Title = "Save TreeGX control content to image";
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Text = "buttonX1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 678);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Mind Mapper 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mmap)).EndInit();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonBar3.ResumeLayout(false);
            this.ribbonBar1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonBar4.ResumeLayout(false);
            this.ribbonBar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabv)).EndInit();
            this.tabv.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.Tree.TreeGX mmap;
        private DevComponents.Tree.NodeConnector nodeConnector2;
        private DevComponents.Tree.ElementStyle elementStyle1;
        private DevComponents.Tree.NodeConnector nodeConnector1;
        private DevComponents.Tree.ElementStyle elementStyle2;
        private DevComponents.Tree.ElementStyle elementStyle3;
        private DevComponents.Tree.ElementStyle elementStyle4;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ApplicationButton buttonfile;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem aboutpage;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonX addnode;
        private DevComponents.DotNetBar.Controls.TextBoxX nodeinput;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.ButtonX delnode;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        private DevComponents.DotNetBar.ButtonItem openfile;
        private DevComponents.DotNetBar.ButtonItem savefile;
        private DevComponents.DotNetBar.ButtonItem savefileas;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevComponents.DotNetBar.Metro.MetroStatusBar statusbar;
        private DevComponents.DotNetBar.LabelItem nowfile;
        private DevComponents.DotNetBar.TabControl tabv;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private System.Windows.Forms.Panel MainPanel;
        private DevComponents.Tree.Node node1;
        private DevComponents.DotNetBar.ButtonItem newfile;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem filestatus;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel3;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonX saveimage;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevComponents.Tree.Node node2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.Controls.Slider zoom;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonX help;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem6;


    }
}

