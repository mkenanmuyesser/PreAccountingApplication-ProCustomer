using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProCustomer.Classes
{
    class DataLoad
    {
        static ProCustomerDBEntities entities = Program.entities;
        public static void UrunTreeDoldur(TreeView tre, TreeNode node)
        {

            if (node == null)
            {
                tre.Nodes.Clear();
                foreach (var item in entities.UrunGrups.Where(a => a.AltGrupID == null))
                {
                    TreeNode yeninode = new TreeNode() { Text = item.GrupTanim, Tag = item };
                    tre.Nodes.Add(yeninode);
                    UrunTreeDoldur(tre, yeninode);
                }
            }
            else
            {
                int altid = (node.Tag as UrunGrup).ID;
                foreach (var item in entities.UrunGrups.Where(a => a.AltGrupID == altid))
                {
                    TreeNode yenialtnode = new TreeNode() { Text = item.GrupTanim, Tag = item };
                    node.Nodes.Add(yenialtnode);
                }
            }
        }

        public static void MusteriTreeDoldur(TreeView tre, TreeNode node)
        {

            if (node == null)
            {
                tre.Nodes.Clear();
                foreach (var item in entities.MusteriGrups.Where(a => a.AltGrupID == null))
                {
                    TreeNode yeninode = new TreeNode() { Text = item.GrupTanim, Tag = item };
                    tre.Nodes.Add(yeninode);
                    MusteriTreeDoldur(tre, yeninode);
                }
            }
            else
            {
                int altid = (node.Tag as MusteriGrup).ID;
                foreach (var item in entities.MusteriGrups.Where(a => a.AltGrupID == altid))
                {
                    TreeNode yenialtnode = new TreeNode() { Text = item.GrupTanim, Tag = item };
                    node.Nodes.Add(yenialtnode);
                }
            }
        }        
    }
}
