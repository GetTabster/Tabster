﻿#region

using System;
using System.Windows.Forms;

#endregion

namespace Tabster.Controls
{
    internal class StaticTreeView : TreeView
    {
        private const int WM_LBUTTONDBLCLK = 0x0203; //515
        private const int WM_LBUTTONDOWN = 0x0201; //513
        private const int WM_LBUTTONUP = 0x0202; //514

        public bool AllowRootNodeSelection { get; set; }
        public bool AutoSelectChildNode { get; set; }

        public TreeNode FirstNode
        {
            get { return Nodes.Count > 0 ? Nodes[0] : null; }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || m.Msg == WM_LBUTTONUP || m.Msg == WM_LBUTTONDBLCLK)
            {
                var x = (Int16) m.LParam;
                var y = (Int16) ((int) m.LParam >> 16);

                var info = HitTest(x, y);

                if (info.Node != null)
                {
                    if (info.Node.Parent == null)
                    {
                        if (AutoSelectChildNode && info.Node.Nodes.Count > 0)
                        {
                            SelectedNode = info.Node.FirstNode;
                        }

                        else
                        {
                            return;
                        }
                    }
                }
            }

            base.WndProc(ref m);
        }

        #region Overrides

        protected override void OnBeforeCollapse(TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
            base.OnBeforeCollapse(e);
        }

        protected override void OnBeforeSelect(TreeViewCancelEventArgs e)
        {
            if (!AllowRootNodeSelection && e.Node.Nodes.Count > 0)
            {
                e.Cancel = true;
            }

            base.OnBeforeSelect(e);
        }

        #endregion
    }
}