using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Tree;

namespace CW_Mind_Mapper_1
{
    public partial class FrmMain : DevComponents.DotNetBar.RibbonForm
    {
        private int js = 0, tabs = 0;
        private int saves = 0, opens = 0;
        private string tempstr;
        private string[] tempstrs = new string[10000];
        private string[] savestrs;
        private string[] openstrs;

        public FrmMain()
        {
            InitializeComponent();
        }

        private Node root;

        private void tabitem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            newtab();
            setmapbegin();
        }

        #region SaveMap

        void savenode(Node node)
        {
            tempstrs[saves++] = node.Text;
            tempstrs[saves++] = node.Nodes.Count.ToString();
            foreach (Node subnode in node.Nodes)
                if (subnode.Visible)
                    savenode(subnode);
        }

        void savemap()
        {
            saves = 0;
            savenode(root);
            savestrs = new string[saves];
            for (int i = 0; i < saves; ++i)
                savestrs[i] = tempstrs[i];
        }

        #endregion

        #region OpenMap

        void opennode(Node rnode)
        {
            Node node = new Node();
            node.Expanded = true;
            node.Name = (++js).ToString();
            node.Text = openstrs[opens++];
            rnode.Nodes.Add(node);
            int temp = Convert.ToInt32(openstrs[opens++]), i;
            for (i = 0; i < temp; ++i)
                opennode(node);
        }

        void openmap()
        {
            Gib.nowmmap.Nodes.Clear();
            js = opens = 1;
            root = new Node();
            root.Expanded = true;
            root.Name = (++js).ToString();
            root.Text = openstrs[0];
            Gib.nowmmap.Nodes.Add(root);
            Gib.nowmmap.SelectNode(root, eTreeAction.Mouse);
            int temp = Convert.ToInt32(openstrs[opens++]), i;
            for (i = 0; i < temp; ++i)
                opennode(root);
            Gib.nowmmap.SelectNode(root, eTreeAction.Mouse);
            Gib.nowmmap.Refresh();
        }

        #endregion

        private void addnode_Click(object sender, EventArgs e)
        {
            Node node = new Node();
            node.Expanded = true;
            node.Name = (++js).ToString();
            if (nodeinput.Text.Trim() == "")
                node.Text = "文本";
            else
                node.Text = nodeinput.Text.Trim();
            Gib.nowmmap.SelectedNode.Nodes.Add(node);
            Gib.nowmmap.SelectNode(node, eTreeAction.Mouse);
            Gib.nowmmap.Refresh();
        }

        private void mindmap_AfterNodeSelect(object sender, TreeGXNodeEventArgs e)
        {
            nodeinput.Text = Gib.nowmmap.SelectedNode.Text;
            nodeinput.Focus();
            nodeinput.SelectAll();
        }

        private void nodeinput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Gib.nowmmap.SelectedNode.Text = nodeinput.Text;
            }
            catch
            {
                //throw;
            }
        }

        private void delnode_Click(object sender, EventArgs e)
        {
            if (Gib.nowmmap.SelectedNode != root)
            {
                Gib.nowmmap.SelectedNode.Visible = false;
                Gib.nowmmap.Refresh();
            }
            else
                ToastNotification.Show(this, "不能删除根节点！", Properties.Resources.errorflag, 2000, eToastGlowColor.Red);
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            
            Gib.nowmmap.Focus();
        }

        bool saveasfile()
        {
            try
            {
                SaveFileDialog savefileDialog = new SaveFileDialog();
                savefileDialog.FileName = Path.GetFileName(Gib.tabfile[(int) Gib.nowmmap.Tag]);
                savefileDialog.Filter = "CW思维导图文件(*.cmm)|*.cmm";
                savefileDialog.FilterIndex = 2;
                savefileDialog.RestoreDirectory = true;
                Gib.nowmmap.Focus();
                if (savefileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(savefileDialog.FileName, savestrs, Encoding.Default);
                    tabv.SelectedTab.Text = nowfile.Text = Gib.tabfile[(int)Gib.nowmmap.Tag] = Path.GetFileName(savefileDialog.FileName);
                    filestatus.Text = "已保存";
                    nowfile.Refresh();
                    //filestatus.Refresh();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
                //throw;
            }
        }

        private bool savefileReturn;
        private void savefile_Click(object sender, EventArgs e)
        {
            try
            {
                savemap();
                if (!Gib.saved[(int) Gib.nowmmap.Tag])
                {
                    if (!saveasfile())
                        savefileReturn = false;
                    Gib.saved[(int) Gib.nowmmap.Tag] = true;
                }
                else
                    File.WriteAllLines(Gib.tabfile[(int) Gib.nowmmap.Tag], savestrs, Encoding.Default);
                //filestatus.Text = "已保存";
                savefileReturn = true;
            }
            catch
            {
                //savefileReturn = false;
                //throw;
            }
            Gib.nowmmap.Focus();
            savefileReturn = true;
        }

        void setmapbegin()
        {
            root = new Node();
            root.Expanded = true;
            root.Name = root.Text = "文本";
            Gib.nowmmap.Nodes.Add(root);
            Gib.nowmmap.SelectNode(root, eTreeAction.Mouse);

            Node node1 = new Node();
            node1.Expanded = true;
            node1.Name = node1.Text = "1";
            Gib.nowmmap.SelectedNode.Nodes.Add(node1);
            Gib.nowmmap.Refresh();

            Node node2 = new Node();
            node2.Expanded = true;
            node2.Name = node2.Text = "2";
            Gib.nowmmap.SelectedNode.Nodes.Add(node2);
            Gib.nowmmap.Refresh();

            Node node3 = new Node();
            node3.Expanded = true;
            node3.Name = node3.Text = "3";
            Gib.nowmmap.SelectedNode.Nodes.Add(node3);
            Gib.nowmmap.Refresh();

            Node node4 = new Node();
            node4.Expanded = true;
            node4.Name = node4.Text = "4";
            Gib.nowmmap.SelectedNode.Nodes.Add(node4);
            Gib.nowmmap.Refresh();
        }

        void newtab()
        {
            TabItem tabitem = new TabItem();
            TabControlPanel tabpanel = new TabControlPanel();
            TreeGX newmmap = new TreeGX();

            newmmap.AllowDrop = true;
            newmmap.AutoScrollMinSize = new System.Drawing.Size(60, 33);
            newmmap.BackColor = System.Drawing.Color.White;
            newmmap.CellEdit = true;
            newmmap.CommandBackColorGradientAngle = 90;
            newmmap.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
            newmmap.CommandMouseOverBackColorGradientAngle = 90;
            newmmap.Dock = System.Windows.Forms.DockStyle.Fill;
            newmmap.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
            newmmap.Font = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            newmmap.Location = new System.Drawing.Point(1, 1);
            newmmap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            newmmap.Name = "新文件";
            newmmap.NodesConnector = this.nodeConnector2;
            newmmap.NodeStyle = this.elementStyle1;
            newmmap.PathSeparator = ";";
            newmmap.RootConnector = this.nodeConnector1;
            newmmap.Size = new System.Drawing.Size(944, 409);
            newmmap.Styles.Add(this.elementStyle1);
            newmmap.Styles.Add(this.elementStyle2);
            newmmap.Styles.Add(this.elementStyle3);
            newmmap.Styles.Add(this.elementStyle4);
            newmmap.SuspendPaint = false;
            newmmap.TabIndex = 0;
            newmmap.Tag = tabs;
            newmmap.Text = "新文件";
            newmmap.AfterNodeSelect += new DevComponents.Tree.TreeGXNodeEventHandler(mindmap_AfterNodeSelect);

            tabitem.AttachedControl = tabpanel;
            tabitem.Name = "tabitem";
            tabitem.Tag = tabs++;
            tabitem.Text = "新文件";
            tabitem.Click += new System.EventHandler(tabitem_Click);

            tabpanel.Controls.Add(newmmap);
            tabpanel.DisabledBackColor = Color.Empty;
            tabpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tabpanel.Location = new System.Drawing.Point(0, 0);
            tabpanel.Name = "tabpanel";
            tabpanel.Padding = new System.Windows.Forms.Padding(1);
            tabpanel.Size = new System.Drawing.Size(946, 411);
            tabpanel.Style.BackColor1.Color = System.Drawing.Color.White;
            tabpanel.Style.Border = eBorderType.SingleLine;
            tabpanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            tabpanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
            | DevComponents.DotNetBar.eBorderSide.Top)));
            tabpanel.Style.GradientAngle = -90;
            tabpanel.TabItem = tabitem;

            tabv.Tabs.Add(tabitem);
            tabv.SelectedTab = tabitem;

            Gib.nowmmap = newmmap;
        }

        private void newfile_Click(object sender, EventArgs e)
        {
            newtab();
            setmapbegin();
            Gib.nowmmap.Focus();
        }

        private void tabv_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            try
            {
                Gib.nowmmap = (TreeGX) (tabv.SelectedTab.AttachedControl.Controls[0]);
                nowfile.Text = Path.GetFileName(Gib.tabfile[(int)Gib.nowmmap.Tag]);
                //filestatus.Text = Gib.allsaved[(int)Gib.nowmmap.Tag] == true ? "已保存" : "已修改";
                nowfile.Refresh();
                statusbar.Refresh();
                //filestatus.Refresh();
            }
            catch
            {
                //throw;
            }
        }

        private bool tabitemReturn;
        private void tabv_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            tabitemReturn = true;
            if (!Gib.saved[(int) Gib.nowmmap.Tag])
            {
                DialogResult tempResult = MessageBoxEx.Show(this, "你对此思维导读所做的更改尚未保存，是否保存？", "提示",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (tempResult == DialogResult.Yes)
                {
                    savefile_Click(null, null);
                    if (!savefileReturn)
                    {
                        try
                        {
                            e.Cancel = true;
                        }
                        catch
                        {
                        }

                        savefileReturn = false;
                    }
                }
                else if (tempResult == DialogResult.Cancel)
                {
                    try
                    {
                        e.Cancel = true;
                    }
                    catch
                    {
                    }

                    tabitemReturn = false;
                }
            }
            else
                savefile_Click(null, null);
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (Gib.nowmmap.SelectedNode != root)
                    Gib.nowmmap.SelectedNode = Gib.nowmmap.SelectedNode.Parent;
            }
            else if (e.KeyValue == 13)
                addnode_Click(null, null);
        }

        private void savefileas_Click(object sender, EventArgs e)
        {
            try
            {
                savemap();
                if(!saveasfile())
                    return;
                Gib.saved[(int) Gib.nowmmap.Tag] = true;
                //filestatus.Text = "已保存";
                //Gib.allsaved[(int) Gib.nowmmap.Tag] = true;
            }
            catch
            {
                //throw;
            }
            Gib.nowmmap.Focus();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                savefile_Click(null, null);
            if (e.Control && e.KeyCode == Keys.N)
                newfile_Click(null, null);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabItem tabpage in tabv.Tabs)
                if (tabpage.Visible)
                {
                    tabv.SelectedTab = tabpage;
                    tabv_TabItemClose(null, null);
                    if (tabitemReturn)
                        tabpage.Visible = false;
                    else
                    {
                        e.Cancel = true;
                        return;
                    }
                }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveimage_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                using (Bitmap bmp = new Bitmap(Gib.nowmmap.TreeSize.Width, Gib.nowmmap.TreeSize.Height))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                        Gib.nowmmap.PaintTo(g, true, Rectangle.Empty);
                    bmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
        }

        private void zoom_ValueChanged(object sender, EventArgs e)
        {
            Gib.nowmmap.Zoom = (float)zoom.Value / 100;
            zoom.Text = zoom.Value.ToString() + "%";
        }

        private void help_Click(object sender, EventArgs e)
        {
            FrmHelp frm = new FrmHelp();
            frm.ShowDialog();
        }
    }
}
