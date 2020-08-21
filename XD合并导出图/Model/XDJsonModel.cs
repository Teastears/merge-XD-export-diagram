using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD合并导出图.Model
{
    public class XDJsonModel
    {
        // public List<Artboard> artboards { set; get; }
        public string version { get; set; }
        public JObject artboards { get; set; }
    }
}
