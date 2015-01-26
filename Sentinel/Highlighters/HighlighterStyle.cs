#region License
//
// � Copyright Ray Hayes
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
//
#endregion

namespace Sentinel.Highlighters
{
    using System.Runtime.Serialization;
    using System.Windows.Media;

    using Newtonsoft.Json;

    using Sentinel.Interfaces;
    using Sentinel.Support.Mvvm;

    [DataContract]
    public class HighlighterStyle 
        : ViewModelBase
        , IHighlighterStyle
    {
        private Color? background;

        private Color? foreground;

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Color? Background
        {
            get
            {
                return background;
            }

            set
            {
                if (value != background)
                {
                    background = value;
                    OnPropertyChanged("Background");
                }
            }
        }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Color? Foreground
        {
            get
            {
                return foreground;
            }

            set
            {
                if (value != foreground)
                {
                    foreground = value;
                    OnPropertyChanged("Foreground");
                }
            }
        }
    }
}