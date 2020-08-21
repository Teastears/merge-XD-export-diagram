using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD合并导出图.Model
{
    public class Artboard
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int ViewportHeight { get; set; }
    }
}
