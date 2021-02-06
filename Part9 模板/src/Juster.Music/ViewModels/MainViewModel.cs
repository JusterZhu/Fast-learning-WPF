using Juster.Common;
using Juster.DAL;
using Juster.Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Juster.Music.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private List<SongSheetModel> _songSheets;

        public List<SongSheetModel> SongSheets
        {
            get { return _songSheets; }
            set 
            {
                _songSheets = value;
                OnPropertyChanged("SongSheets");
            }
        }

        public MainViewModel() 
        {
            SongSheets = ConvertToModel(DataService.GetSongSheet());
        }

        private List<SongSheetModel> ConvertToModel(List<SongSheetDTO> songSheets) 
        {
            List<SongSheetModel> resultLst = new List<SongSheetModel>();

            foreach (var songSheet in songSheets)
            {
                resultLst.Add(new SongSheetModel 
                {
                    Name = songSheet.Name,
                    Icon = songSheet.Icon,
                    Songs = ConvertToSongs(songSheet.Songs)
                });
            }
            return resultLst;
        }

        private List<SongModel> ConvertToSongs(List<SongDTO> songs) 
        {
            List<SongModel> resultModels = new List<SongModel>();
            foreach (var song in songs)
            {
                resultModels.Add(new SongModel 
                {
                    Name = song.Name,
                    Singer = song.Singer,
                    Lenght = song.Lenght,
                    Url = song.Url,
                    AlbumTitle = song.AlbumTitle
                });
            }
            return resultModels;
        }
    }
}
