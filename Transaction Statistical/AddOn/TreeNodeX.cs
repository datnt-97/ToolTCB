using System;
using System.Collections;
using System.Windows.Forms;


/// <summary>
/// CustomTreeNode Extends TreeNode class to add the functionality of applying CSS 
/// and adding Attributes to a node
/// </summary>
public class TreeNodeX : TreeNode
{
    public TreeNodeX() : base() { }
    //
    // Summary:
    //     Initializes a new instance of the System.Windows.Forms.TreeNode class with the
    //     specified label text.
    //
    // Parameters:
    //   text:
    //     The label System.Windows.Forms.TreeNode.Text of the new tree node.
    public TreeNodeX(string text) : base()
    { this.Text = text; }
    //
    // Summary:
    //     Initializes a new instance of the System.Windows.Forms.TreeNode class with the
    //     specified label text and child tree nodes.
    //
    // Parameters:
    //   text:
    //     The label System.Windows.Forms.TreeNode.Text of the new tree node.
    //
    //   children:
    //     An array of child System.Windows.Forms.TreeNode objects.
    public TreeNodeX(string text, TreeNode[] children) : base() { }
    //
    // Summary:
    //     Initializes a new instance of the System.Windows.Forms.TreeNode class with the
    //     specified label text and images to display when the tree node is in a selected
    //     and unselected state.
    //
    // Parameters:
    //   text:
    //     The label System.Windows.Forms.TreeNode.Text of the new tree node.
    //
    //   imageIndex:
    //     The index value of System.Drawing.Image to display when the tree node is unselected.
    //
    //   selectedImageIndex:
    //     The index value of System.Drawing.Image to display when the tree node is selected.
    public TreeNodeX(string text, int imageIndex, int selectedImageIndex) : base() { }
    //
    // Summary:
    //     Initializes a new instance of the System.Windows.Forms.TreeNode class with the
    //     specified label text, child tree nodes, and images to display when the tree node
    //     is in a selected and unselected state.
    //
    // Parameters:
    //   text:
    //     The label System.Windows.Forms.TreeNode.Text of the new tree node.
    //
    //   imageIndex:
    //     The index value of System.Drawing.Image to display when the tree node is unselected.
    //
    //   selectedImageIndex:
    //     The index value of System.Drawing.Image to display when the tree node is selected.
    //
    //   children:
    //     An array of child System.Windows.Forms.TreeNode objects.
    public TreeNodeX(string text, int imageIndex, int selectedImageIndex, TreeNode[] children) : base() { }
    
    public string FullPath() 
    {
        string s = this.Key;
        TreeNodeX parent =(TreeNodeX)this.Parent;
        while(parent !=null && parent.Key!=null)
        {
            s = parent.Key + "\\" + s;
            parent = (TreeNodeX)parent.Parent;
        }
        return s;
    }
    public string Key { get; set; }
    public TreeNodeX(string text, string key)
    {
        this.Key = key;
        this.Text = text;
    }
}
