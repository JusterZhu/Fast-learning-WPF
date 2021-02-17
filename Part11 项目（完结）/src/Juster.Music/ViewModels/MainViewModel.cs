using Juster.Common;
using Juster.DAL;
using Juster.Logger;
using Juster.Music.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Juster.Music.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainWindow View { get; set; }

        private int _minVal;

        public int MinVal
        {
            get { return _minVal; }
            set
            {
                _minVal = value;
                OnPropertyChanged("MinVal");
            }
        }

        private int _maxVal;

        public int MaxVal
        {
            get { return _maxVal; }
            set
            {
                _maxVal = value;
                OnPropertyChanged("MaxVal");
            }
        }

        private int _currentVal;

        public int CurrentVal
        {
            get { return _currentVal; }
            set
            {
                _currentVal = value;
                OnPropertyChanged("CurrentVal");
            }
        }

        private bool _isPlay;

        public bool IsPlay
        {
            get { return _isPlay; }
            set
            {
                _isPlay = value;
                OnPropertyChanged("IsPlay");
            }
        }

        private SongModel _song;

        public SongModel Song
        {
            get { return _song; }
            set
            {
                _song = value;
                if (_song != null)
                {
                    View.SetSource(_song.Url);
                }
                OnPropertyChanged("Song");
            }
        }

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
            try
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
            catch (Exception ex)
            {
                NLogger.Error(ex.Message, ex);
                return null;
            }
        }

        private List<SongModel> ConvertToSongs(List<SongDTO> songs) 
        {
            try
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
            catch (Exception ex)
            {
                NLogger.Error(ex.Message,ex);
                return null;
            }
        }
    }
}
