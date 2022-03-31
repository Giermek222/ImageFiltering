using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgProcessor
{
    public static class leafs { 
        public static int no_of_leafs = 0;
        public static int max_depth = 0;
        public static List<List<Octree>> leaf_list = new List<List<Octree>>() {
            new List<Octree>(),
            new List<Octree>(),
            new List<Octree>(),
            new List<Octree>(),
            new List<Octree>(),
            new List<Octree>(),
            new List<Octree>(),
            new List<Octree>(),
            new List<Octree>()
        };
    }
    public class Octree
    {
        public int color_count = 0;
        public bool is_leaf = false;
        public int depth;


        Color begin, end;
        Octree[] children;
        Octree parent;

        int mid_R;
        int mid_G;
        int mid_B;
        int max_leafs;
        public Octree()
        {

        }

        public Octree(Color _begin, Color _end, int _max_leafs, int _depth = 0, Octree _parent = null)
        {

            if (_begin.R > _end.R || _begin.G > _end.G || _begin.B > _end.B)
            {
                return;
            }
            children = new Octree[8];
            begin = _begin;
            end = _end;
            depth = _depth;
            mid_R = (end.R - begin.R) / 2 + begin.R;
            mid_G = (end.G - begin.G) / 2 + begin.G;
            mid_B = (end.B - begin.B) / 2 + begin.B;
            max_leafs = _max_leafs;
            parent = _parent;

        }

        private Color buildHelper(int rb, int gb, int bb, int re, int ge, int be, int index, Color color)
        {
            if (depth < 7 && !is_leaf)
            {
                if (children[index] == null)
                    children[index] = new Octree(
                        Color.FromArgb(255, rb, gb, bb),
                        Color.FromArgb(255, re, ge, be),
                         max_leafs, depth + 1, this);

                return children[index].build(color);
            }

            is_leaf = true;
            if (!leafs.leaf_list.ElementAt(depth).Contains(this))
            {
                leafs.no_of_leafs++;
                leafs.leaf_list.ElementAt(depth).Add(this);
                if (depth > leafs.max_depth) leafs.max_depth = depth;
            }


            return Color.FromArgb(255, mid_R, mid_G, mid_B);
        }
        private void reduceTree()
        {
            Random rand = new Random();
            Octree leaf_to_go = leafs.leaf_list.ElementAt(leafs.max_depth).ElementAt(0);
            leafs.leaf_list.ElementAt(leafs.max_depth).Remove(leaf_to_go);
            Octree parent = leaf_to_go.parent;
            parent.is_leaf = true;
            leafs.no_of_leafs++;
            leafs.leaf_list.ElementAt(parent.depth).Add(parent);
            for (int i = 0; i < 8; ++i)
            {
                if (parent.children[i] != null)
                {
                    leafs.leaf_list.ElementAt(leafs.max_depth).Remove(parent.children[i]);
                    leafs.no_of_leafs--;
                }
            }
            if (leafs.leaf_list.ElementAt(leafs.max_depth).Count == 0)
                leafs.max_depth--;
        }

        public void insert(Color color)
        {
            build(color);
            if (leafs.no_of_leafs > max_leafs)
                do { reduceTree(); } while (leafs.no_of_leafs > max_leafs);

        }
        public Color build(Color color)
        {

            color_count += 1;


            if (color.R < mid_R)
            {
                if (color.G < mid_G)
                {
                    if (color.B < mid_B)
                        return buildHelper(begin.R, begin.G, begin.B, mid_R, mid_G, mid_B, 0, color);
                    else
                        return buildHelper(begin.R, begin.G, mid_B, mid_R, mid_G, end.B, 1, color);
                }
                else
                {
                    if (color.B < mid_B)
                        return buildHelper(begin.R, mid_G, begin.B, mid_R, end.G, mid_B, 2, color);
                    else
                        return buildHelper(begin.R, mid_G, mid_B, mid_R, end.G, end.B, 3, color);
                }
            }
            else
            {
                if (color.G < mid_G)
                {
                    if (color.B < mid_B)
                        return buildHelper(mid_R, begin.G, begin.B, end.R, mid_G, mid_B, 4, color);
                    else
                        return buildHelper(mid_R, begin.G, mid_B, end.R, mid_G, end.B, 5, color);
                }
                else
                    if (color.B < mid_B)
                    return buildHelper(mid_R, mid_G, begin.B, end.R, end.G, mid_B, 6, color);
                else
                    return buildHelper(mid_R, mid_G, mid_B, end.R, end.G, end.B, 7, color);
            }



        }


        private Color getColorHelper(Color color, int index)
        {
            if (this.is_leaf)
                return Color.FromArgb(255, mid_R, mid_G, mid_B);
            else
                return children[index].GetColor(color);
        }
        public Color GetColor(Color color)
        {
            if (color.R < mid_R)
            {
                if (color.G < mid_G)
                {
                    if (color.B < mid_B)
                        return getColorHelper(color, 0);
                    else
                        return getColorHelper(color, 1);
                }
                else
                {
                    if (color.B < mid_B)
                        return getColorHelper(color, 2);
                    else
                        return getColorHelper(color, 3);
                }
            }
            else
            {
                if (color.G < mid_G)
                {
                    if (color.B < mid_B)
                        return getColorHelper(color, 4);
                    else
                        return getColorHelper(color, 5);
                }
                else
                    if (color.B < mid_B)
                    return getColorHelper(color, 6);
                else
                    return getColorHelper(color, 7);
            }
        }
    };
}
