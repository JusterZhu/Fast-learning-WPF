using System;
using System.Collections.Generic;
using System.Text;

namespace Juster.DAL
{
    public class DataService
    {
        public static List<SongSheetDTO> GetSongSheet() 
        {
            List<SongSheetDTO> songSheets = new List<SongSheetDTO>();

            var songSheetJay = new SongSheetDTO();
            songSheetJay.Name = "周杰伦的歌单";
            songSheetJay.Icon = "/Juster.Common;component/imgs/music.png";
            songSheetJay.Songs = new List<SongDTO>() 
            {
                new SongDTO{ Name = "七里香" , AlbumTitle = "叶惠美" , Lenght = 800 , Singer = "周杰伦" , Url = "pack://application:,,,/Juster.Common;component/mp3/周杰伦 - 稻香.mp3" },
                new SongDTO{ Name = "外婆" , AlbumTitle = "叶惠美" , Lenght = 800 , Singer = "周杰伦" , Url = "pack://application:,,,/Juster.Common;component/mp3/周杰伦 - 稻香.mp3" },
                new SongDTO{ Name = "将军" , AlbumTitle = "叶惠美" , Lenght = 800 , Singer = "周杰伦" , Url = "pack://application:,,,/Juster.Common;component/mp3/周杰伦 - 稻香.mp3" },
                new SongDTO{ Name = "搁浅" , AlbumTitle = "叶惠美" , Lenght = 800 , Singer = "周杰伦" , Url = "pack://application:,,,/Juster.Common;component/mp3/周杰伦 - 稻香.mp3" }
            };
            songSheets.Add(songSheetJay);

            var songSheetJolin = new SongSheetDTO();
            songSheetJolin.Name = "蔡依林的歌单";
            songSheetJolin.Icon = "/Juster.Common;component/imgs/music.png";
            songSheetJolin.Songs = new List<SongDTO>()
            {
                new SongDTO{ Name = "倒带" , AlbumTitle = "城堡" , Lenght = 800 , Singer = "蔡依林" , Url = "pack://application:,,,/Juster.Common;component/mp3/蔡依林 - 日不落.mp3" },
                new SongDTO{ Name = "爱情36计" , AlbumTitle = "城堡" , Lenght = 800 , Singer = "蔡依林" , Url = "pack://application:,,,/Juster.Common;component/mp3/蔡依林 - 日不落.mp3" },
                new SongDTO{ Name = "海盗" , AlbumTitle = "城堡" , Lenght = 800 , Singer = "蔡依林" , Url = "pack://application:,,,/蔡依林 - 特务J.mp3" },
                new SongDTO{ Name = "柠檬草的味道" , AlbumTitle = "城堡" , Lenght = 800 , Singer = "蔡依林" , Url = "pack://application:,,,/蔡依林 - 特务J.mp3" }
            };
            songSheets.Add(songSheetJolin);

            return songSheets;
        }
    }

    /// <summary>
    /// 歌曲模型
    /// </summary>
    public class SongDTO
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

    /// <summary>
    /// 歌单
    /// </summary>
    public class SongSheetDTO
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
        public List<SongDTO> Songs { get; set; }
    }
}
