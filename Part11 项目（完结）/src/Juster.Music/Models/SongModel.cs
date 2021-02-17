using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juster.Music.Models
{
    /// <summary>
    /// 歌曲模型
    /// </summary>
    public class SongModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 歌曲存放地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 歌手
        /// </summary>
        public string Singer { get; set; }

        /// <summary>
        /// 歌曲时长（s）
        /// </summary>
        public int Lenght { get; set; }

        /// <summary>
        /// 专辑名称
        /// </summary>
        public string AlbumTitle { get; set; }
    }
}
