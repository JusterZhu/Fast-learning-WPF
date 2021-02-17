using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juster.Music.Models
{
    /// <summary>
    /// 歌单
    /// </summary>
    public class SongSheetModel
    {
        /// <summary>
        /// 歌单名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 歌单图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 歌单里所包含的歌曲
        /// </summary>
        public List<SongModel> Songs { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
