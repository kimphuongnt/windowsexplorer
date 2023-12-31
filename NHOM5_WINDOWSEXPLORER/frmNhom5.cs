using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace NHOM5_WINDOWSEXPLORER
{
    public partial class frmNhom5 : Form
    {
        TreeNode selectedNode;
        private ImageList treeViewImageList;
        private ImageList listViewImageList;
        private ImageList largeIconImageList;
        private ImageList smallIconImageList;
        private List<ListViewItem> currentItems = new List<ListViewItem>();
        private List<ListViewItem> cutItems = new List<ListViewItem>();
        private List<ListViewItem> listViewItems = new List<ListViewItem>();

        public frmNhom5()
        {
            InitializeComponent();
            HienThiTreeView();
            HienThiListView();
            HienThiImageList_TreeView();

            largeIconImageList = new ImageList();
            largeIconImageList.ImageSize = new Size(48, 48);
            largeIconImageList.Images.Add(Properties.Resources._299060_folder_icon);
            lstDanhMuc.LargeImageList = largeIconImageList;

            smallIconImageList = new ImageList();
            smallIconImageList.ImageSize = new Size(16, 16);
            smallIconImageList.Images.Add(Properties.Resources._299060_folder_icon);
            lstDanhMuc.LargeImageList = smallIconImageList;

        }

        private void HienThiImageList_TreeView()
        {
            treeViewImageList = new ImageList();
            treeViewImageList.Images.Add("Folder", Properties.Resources.icons8_folder_48);
            trvDanhMuc.ImageList = treeViewImageList;
        }

        private void HienThiTreeView()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                TreeNode driveNode = new TreeNode(drive);
                driveNode.Tag = drive;
                driveNode.ImageIndex =
                trvDanhMuc.Nodes.Add(driveNode);
                driveNode.Nodes.Add("");
            }
        }

        private void HienThiListView()
        {
            lstDanhMuc.View = View.Details;
            lstDanhMuc.Columns.Add("Name", 200);
            lstDanhMuc.Columns.Add("Type", 100);
            lstDanhMuc.Columns.Add("Size", 100);
            lstDanhMuc.Columns.Add("Date", 150);
        }

        private void loadMuc(string path)
        {
            lstDanhMuc.Items.Clear();

            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);

                foreach (var subDirectory in directory.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(subDirectory.Name);
                    item.SubItems.Add("Folder");
                    item.SubItems.Add("");
                    item.SubItems.Add(subDirectory.LastWriteTime.ToString());
                    item.Tag = subDirectory.FullName;
                    lstDanhMuc.Items.Add(item);
                }

                foreach (var file in directory.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add("File");
                    long fileSize = file.Length;
                    string fileSizeKB = fileSize.ToString("N0") + " KB";
                    item.SubItems.Add(fileSizeKB);
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.Tag = file.FullName;
                    lstDanhMuc.Items.Add(item);
                }
                txtPath.Text = path;
                lblDem.Text = "Tổng số mục: " + lstDanhMuc.Items.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private TreeNode FindNodeByTag(TreeNode node, string tag)
        {
            if (node.Tag as string == tag)
            {
                return node;
            }
            foreach (TreeNode child in node.Nodes)
            {
                TreeNode result = FindNodeByTag(child, tag);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        private void trvDanhMuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "")
            {
                e.Node.Nodes.Clear();
                string selectedPath = e.Node.Tag as string;

                try
                {
                    foreach (string directory in Directory.GetDirectories(selectedPath))
                    {
                        TreeNode node = new TreeNode(Path.GetFileName(directory));
                        node.Tag = directory;
                        node.Nodes.Add(""); // Add a dummy node to enable expansion
                        e.Node.Nodes.Add(node);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lstDanhMuc_DoubleClick(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedItems.Count == 1)
            {
                string path = lstDanhMuc.SelectedItems[0].Tag as string;
                if (Directory.Exists(path))
                {
                    loadMuc(path);
                }
                else if (File.Exists(path))
                {
                    try
                    {
                        Process.Start(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void trvDanhMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e.Node;
            string selectedPath = e.Node.Tag as string;
            loadMuc(selectedPath);
        }

        private void btnTaoFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Chọn thư mục cha";
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;
                string tenFolder = Interaction.InputBox("Nhập tên thư mục:", "Thêm thư mục", "NewFolder");

                if (!string.IsNullOrEmpty(tenFolder))
                {
                    string newFolderPath = Path.Combine(selectedPath, tenFolder);

                    try
                    {
                        Directory.CreateDirectory(newFolderPath);
                        TreeNode selectedNode = trvDanhMuc.SelectedNode;
                        if (selectedNode != null)
                        {
                            TreeNode newNode = new TreeNode(tenFolder);
                            newNode.Tag = newFolderPath;
                            selectedNode.Nodes.Add(newNode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo thư mục: " + ex.Message);
                    }
                }
            }
        }

        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string enteredPath = txtPath.Text;
                if (Directory.Exists(enteredPath) || File.Exists(enteredPath))
                {
                    if (Directory.Exists(enteredPath))
                    {
                        loadMuc(enteredPath);
                    }
                    else if (File.Exists(enteredPath))
                    {
                        try
                        {
                            Process.Start(enteredPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn không hợp lệ.");
                }
            }
        }

        private void btnTaoFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Chọn thư mục chứa tệp";
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;

                string tenTep = Interaction.InputBox("Nhập tên tệp:", "Thêm tệp", "NewFile.txt");

                if (!string.IsNullOrEmpty(tenTep))
                {
                    string newFilePath = Path.Combine(selectedPath, tenTep);

                    try
                    {
                        FileStream fs = File.Create(newFilePath);
                        fs.Close();
                        ListViewItem item = new ListViewItem(tenTep);
                        item.SubItems.Add(newFilePath);
                        lstDanhMuc.Items.Add(item);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo tệp: " + ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            try
            {
                CutSelectedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CutSelectedItems()
        {
            cutItems.Clear();

            foreach (ListViewItem selectedItem in lstDanhMuc.SelectedItems)
            {
                cutItems.Add((ListViewItem) selectedItem.Clone());
                lstDanhMuc.Items.Remove(selectedItem);
            }
        }

        private void PasteItems()
        {
            if (cutItems.Count > 0)
            {
                foreach (ListViewItem item in cutItems)
                {
                    lstDanhMuc.Items.Add((ListViewItem) item.Clone());
                }

                cutItems.Clear();
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                PasteItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            DoiTenThuMucChon();
        }
        private void DoiTenThuMucChon()
        {
            if (lstDanhMuc.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lstDanhMuc.SelectedItems[0];
                string currentName = selectedItem.Text;
                string newName = Interaction.InputBox("Nhập tên mới:", "Đổi tên", currentName);

                if (!string.IsNullOrEmpty(newName))
                {
                    selectedItem.Text = newName;
                }
            }
        }
        private void btnShare_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaThuMucChon();
        }
        private void XoaThuMucChon()
        {
            foreach (ListViewItem selectedItem in lstDanhMuc.SelectedItems)
            {
                string filePath = selectedItem.SubItems[1].Text;
                if (File.Exists(filePath))
                {
                    try
                    {
                        File.Delete(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (Directory.Exists(filePath))
                {
                    try
                    {
                        Directory.Delete(filePath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                lstDanhMuc.Items.Remove(selectedItem);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            trvDanhMuc_AfterSelect(sender, new TreeViewEventArgs(selectedNode));
        }


        private void SapXepBangTen()
        {
            listViewItems.Clear();
            foreach (ListViewItem item in lstDanhMuc.Items)
            {
                listViewItems.Add(item);
            }
            listViewItems.Sort((x, y) => string.Compare(x.Text, y.Text));
            lstDanhMuc.Items.Clear();
            lstDanhMuc.Items.AddRange(listViewItems.ToArray());
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SapXepBangTen();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SapXepBangNgay();
        }
        private void SapXepBangNgay()
        {
            listViewItems.Clear();
            foreach (ListViewItem item in lstDanhMuc.Items)
            {
                listViewItems.Add(item);
            }
            listViewItems.Sort((x, y) => DateTime.Compare(NgayCuaThuMuc(x), NgayCuaThuMuc(y)));
            lstDanhMuc.Items.Clear();
            lstDanhMuc.Items.AddRange(listViewItems.ToArray());
        }

        private DateTime NgayCuaThuMuc(ListViewItem item)
        {
            string filePath = item.SubItems[1].Text;
            if (File.Exists(filePath))
            {
                return File.GetLastWriteTime(filePath);
            }
            else if (Directory.Exists(filePath))
            {
                return Directory.GetLastWriteTime(filePath);
            }
            return DateTime.MinValue;
        }

        private void btnLargeIcons_Click(object sender, EventArgs e)
        {
            
            lstDanhMuc.View = View.LargeIcon;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstDanhMuc.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstDanhMuc.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstDanhMuc.View = View.Details;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstDanhMuc.Items)
            {
                item.Selected = true;
            }
        }
    }
}
