﻿using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TEdit.Geometry.Primitives;
using GalaSoft.MvvmLight;
using System.Linq;

namespace TEdit.Terraria.Objects
{
    public class TileProperty : ObservableObject, ITile
    {
        private Color _color = Colors.Magenta;
        private int _id = -1;
        private string _name = "UNKNOWN";
        private bool _isFramed;
        private Vector2Short _frameSize = new Vector2Short(1, 1);
        private Vector2Short _frameGap = new Vector2Short(0, 0);
        private readonly ObservableCollection<FrameProperty> _frames = new ObservableCollection<FrameProperty>();
        private bool _isSolid;
        private bool _isSolidTop;
        private bool _isLight;
        private FramePlacement _placement;
        private Vector2Short _textureGrid;

        private bool _isAnimated;
        private bool _isGrass;
        private bool _isPlatform;
        private bool _isCactus;
        private bool _hasFrameName;
        private bool _isStone;
        private bool _canBlend;
        private int? _mergeWith;


        public TileProperty()
        {
        }

        public Vector2Short TextureGrid
        {
            get { return _textureGrid; }
            set { Set("TextureGrid", ref _textureGrid, value); }
        }

        public Vector2Short FrameGap
        {
            get { return _frameGap; }
            set { Set("FrameGap", ref _frameGap, value); }
        }
        public FramePlacement Placement
        {
            get { return _placement; }
            set { Set("Placement", ref _placement, value); }
        }

        public bool IsAnimated
        {
            get { return _isAnimated; }
            set { Set("IsAnimated", ref _isAnimated, value); }
        }

        public bool IsLight
        {
            get { return _isLight; }
            set { Set("IsLight", ref _isLight, value); }
        }

        public bool IsOrigin(Vector2Short uv, out FrameProperty frame)
        {
            frame = Frames.FirstOrDefault(f => f.UV == uv);

            return frame != null;
        }

        public bool IsSolidTop
        {
            get { return _isSolidTop; }
            set { Set("IsSolidTop", ref _isSolidTop, value); }
        }

        public bool IsSolid
        {
            get { return _isSolid; }
            set { Set("IsSolid", ref _isSolid, value); }
        }

        public ObservableCollection<FrameProperty> Frames
        {
            get { return _frames; }
        }

        public TileProperty(int id, string name, Color color, bool isFramed = false)
        {
            _color = color;
            _id = id;
            _name = name;
            _isFramed = isFramed;
        }

        public Color Color
        {
            get { return _color; }
            set { Set("Color", ref _color, value); }
        }

        public int Id
        {
            get { return _id; }
            set { Set("Id", ref _id, value); }
        }

        public string Name
        {
            get { return _name; }
            set { Set("Name", ref _name, value); }
        }

        public Vector2Short FrameSize
        {
            get { return _frameSize; }
            set { Set("FrameSize", ref _frameSize, value); }
        }
        public bool IsFramed
        {
            get { return _isFramed; }
            set { Set("IsFramed", ref _isFramed, value); }
        }

        private WriteableBitmap _image;
        public WriteableBitmap Image
        {
            get { return _image; }
            set { Set("Image", ref _image, value); }
        }


        public bool IsGrass
        {
            get { return _isGrass; }
            set { Set("IsGrass", ref _isGrass, value); }
        }


        public bool IsPlatform
        {
            get { return _isPlatform; }
            set { Set("IsPlatform", ref _isPlatform, value); }
        }


        public bool IsCactus
        {
            get { return _isCactus; }
            set { Set("IsCactus", ref _isCactus, value); }
        }

        public bool HasFrameName
        {
            get { return _hasFrameName; }
            set { Set("HasFrameName", ref _hasFrameName, value); }
        }


        public bool IsStone
        {
            get { return _isStone; }
            set { Set("IsStone", ref _isStone, value); }
        }


        public bool CanBlend
        {
            get { return _canBlend; }
            set { Set("CanBlend", ref _canBlend, value); }
        }


        public int? MergeWith
        {
            get { return _mergeWith; }
            set { Set("MergeWith", ref _mergeWith, value); }
        }
    }
}