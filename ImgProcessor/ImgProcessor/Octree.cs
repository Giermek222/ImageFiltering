using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgProcessor
{

    enum CubeSide : int
    {
        TopLeftFront = 0,
        TopRightFront = 1,
        BottomRightFront = 2,
        BottomLeftFront = 3,
        TopLeftBottom = 4,
        TopRightBottom = 5,
        BottomRightBack = 6,
        BottomLeftBack = 7
    }

    public class Octree
    {
        public int color_count = 0;
        public bool is_leaf = false;
        public int depth;

        Color begin, end;
        Octree[] children;

        int mid_R;
        int mid_G;
        int mid_B;
        int max_depth;
        public Octree()
        {

        }
       
        public Octree(Color _begin, Color _end, int _depth = 0, int _max_depth = 7)
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
            max_depth = _max_depth;
            if (depth == 7) is_leaf = true;
        }

        public Color insert(Color color)
        {

            color_count += 1;
            if (color.R < mid_R)
            {
                if (color.G < mid_G)
                {
                    if (color.B < mid_B)
                    {
                        if (children[0] == null)
                            children[0] = new Octree(
                                begin,
                                Color.FromArgb(255, mid_R, mid_G, mid_B),
                                depth + 1, max_depth);
                        
                        if (depth < max_depth)
                            return children[0].insert(color);
                        else
                            return Color.FromArgb(255,mid_R,mid_G,mid_B);
                    }
                    else
                    {
                        if (children[1] == null)
                            children[1] = new Octree(
                            Color.FromArgb(255, begin.R, begin.G, mid_B),
                            Color.FromArgb(255, mid_R, mid_G, end.B),
                            depth + 1, max_depth);
                        
                        if (depth < max_depth)
                            return children[1].insert(color);
                        else
                            return Color.FromArgb(255, mid_R, mid_G, mid_B);
                    }
                }
                else
                {
                    if (color.B < mid_B)
                    {
                        if (children[2] == null)
                            children[2] = new Octree(
                            Color.FromArgb(255, begin.R, mid_G, begin.B),
                            Color.FromArgb(255, mid_R, end.G, mid_B),
                            depth + 1, max_depth);
                        
                        if (depth < max_depth)
                            return children[2].insert(color);
                        else
                            return Color.FromArgb(255, mid_R, mid_G, mid_B);
                    }
                    else
                    {
                        if (children[3] == null)
                            children[3] = new Octree(
                            Color.FromArgb(255, begin.R, mid_G, mid_B),
                            Color.FromArgb(255, mid_R, end.G, end.B),
                            depth + 1, max_depth);
                        
                        if (depth < max_depth)
                            return children[3].insert(color);
                        else
                            return Color.FromArgb(255, mid_R, mid_G, mid_B);
                    }
                }
            }
            else
            {
                if (color.G < mid_G)
                {
                    if (color.B < mid_B)
                    {
                        if (children[4] == null)
                            children[4] = new Octree(
                            Color.FromArgb(255, mid_R, begin.G, begin.B),
                            Color.FromArgb(255, end.R, mid_G, mid_B),
                            depth + 1, max_depth);
                        
                        if (depth < max_depth)
                            return children[4].insert(color);
                        else
                            return Color.FromArgb(255, mid_R, mid_G, mid_B);
                    }
                    else
                    {
                        if (children[5] == null)
                            children[5] = new Octree(
                            Color.FromArgb(255, mid_R, begin.G, mid_B),
                            Color.FromArgb(255, end.R, mid_G, end.B),
                            depth + 1, max_depth);
                     
                        if (depth < max_depth)
                            return children[5].insert(color);
                        else
                            return Color.FromArgb(255, mid_R, mid_G, mid_B);
                    }
                }
                else
                    if (color.B < mid_B)
                {
                    if (children[6] == null)
                        children[6] = new Octree(
                        Color.FromArgb(255, mid_R, mid_G, begin.B),
                        Color.FromArgb(255, end.R, end.G, mid_B),
                        depth + 1, max_depth);
                  
                    if (depth < max_depth)
                        return children[6].insert(color);
                    else
                        return Color.FromArgb(255, mid_R, mid_G, mid_B);

                }
                    else
                {
                    if (children[7] == null)
                        children[7] = new Octree(
                        Color.FromArgb(255, mid_R, mid_G, mid_B),
                        end,
                        depth + 1, max_depth);
         
                    if (depth < max_depth)
                        return children[7].insert(color);
                    else
                        return Color.FromArgb(255, mid_R, mid_G, mid_B);
                }
            }
            
        }


        
                            
    };
}
