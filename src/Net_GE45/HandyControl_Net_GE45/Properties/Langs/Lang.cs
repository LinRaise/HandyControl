using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace HandyControl.Properties.Langs
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Lang : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private static void Set(ref string oldValue, string newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(oldValue, newValue)) return;
            oldValue = newValue;
            Instance.OnPropertyChanged(propertyName);
        }

        private Lang() { }

        public static void UpdateLang(CultureInfo culture)
        {
            var t = culture.Name;
        }

        public static Lang Instance { get; } = new Lazy<Lang>(() => new Lang()).Value;

        public static Lang GetInstance() => Instance;

        private string _am = "上午";

        public string Am
        {
            get => _am;
            private set => Set(ref _am, value);
        }

        private string _cancel = "取消";

        public string Cancel
        {
            get => _cancel;
            private set => Set(ref _cancel, value);
        }

        private string _cannotRegisterCompositeCommandInItself = "无法自注册复合命令";

        public string CannotRegisterCompositeCommandInItself
        {
            get => _cannotRegisterCompositeCommandInItself;
            private set => Set(ref _cannotRegisterCompositeCommandInItself, value);
        }

        private string _cannotRegisterSameCommandTwice = "不能注册同一命令两次";

        public string CannotRegisterSameCommandTwice
        {
            get => _cannotRegisterSameCommandTwice;
            private set => Set(ref _cannotRegisterSameCommandTwice, value);
        }

        private string _clear = "清空";

        public string Clear
        {
            get => _clear;
            private set => Set(ref _clear, value);
        }

        private string _close = "关闭";

        public string Close
        {
            get => _close;
            private set => Set(ref _close, value);
        }

        private string _closeAll = "关闭所有";

        public string CloseAll
        {
            get => _closeAll;
            private set => Set(ref _closeAll, value);
        }

        private string _closeOther = "关闭其他";

        public string CloseOther
        {
            get => _closeOther;
            private set => Set(ref _closeOther, value);
        }

        private string _confirm = "确定";

        public string Confirm
        {
            get => _confirm;
            private set => Set(ref _confirm, value);
        }

        private string _errorImgPath = "错误的图片路径！";

        public string ErrorImgPath
        {
            get => _errorImgPath;
            private set => Set(ref _errorImgPath, value);
        }

        private string _errorImgSize = "非法的图片尺寸！";

        public string ErrorImgSize
        {
            get => _errorImgSize;
            private set => Set(ref _errorImgSize, value);
        }

        private string _formatError = "格式错误";

        public string FormatError
        {
            get => _formatError;
            private set => Set(ref _formatError, value);
        }

        private string _interval10m = "间隔10分钟";

        public string Interval10m
        {
            get => _interval10m;
            private set => Set(ref _interval10m, value);
        }

        private string _interval1h = "间隔1小时";

        public string Interval1h
        {
            get => _interval1h;
            private set => Set(ref _interval1h, value);
        }

        private string _interval1m = "间隔1分钟";

        public string Interval1m
        {
            get => _interval1m;
            private set => Set(ref _interval1m, value);
        }

        private string _interval2h = "间隔2小时";

        public string Interval2h
        {
            get => _interval2h;
            private set => Set(ref _interval2h, value);
        }

        private string _interval30m = "间隔30分钟";

        public string Interval30m
        {
            get => _interval30m;
            private set => Set(ref _interval30m, value);
        }

        private string _interval30s = "间隔30秒";

        public string Interval30s
        {
            get => _interval30s;
            private set => Set(ref _interval30s, value);
        }

        private string _interval5m = "间隔5分钟";

        public string Interval5m
        {
            get => _interval5m;
            private set => Set(ref _interval5m, value);
        }

        private string _isNecessary = "不能为空";

        public string IsNecessary
        {
            get => _isNecessary;
            private set => Set(ref _isNecessary, value);
        }

        private string _no = "否";

        public string No
        {
            get => _no;
            private set => Set(ref _no, value);
        }

        private string _outOfRange = "不在范围内";

        public string OutOfRange
        {
            get => _outOfRange;
            private set => Set(ref _outOfRange, value);
        }

        private string _pm = "下午";

        public string Pm
        {
            get => _pm;
            private set => Set(ref _pm, value);
        }

        private string _pngImg = "PNG图片";

        public string PngImg
        {
            get => _pngImg;
            private set => Set(ref _pngImg, value);
        }

        private string _tip = "提示";

        public string Tip
        {
            get => _tip;
            private set => Set(ref _tip, value);
        }

        private string _tooLarge = "过大";

        public string TooLarge
        {
            get => _tooLarge;
            private set => Set(ref _tooLarge, value);
        }

        private string _unknown = "未知";

        public string Unknown
        {
            get => _unknown;
            private set => Set(ref _unknown, value);
        }

        private string _unknownSize = "未知大小";

        public string UnknownSize
        {
            get => _unknownSize;
            private set => Set(ref _unknownSize, value);
        }

        private string _yes = "是";

        public string Yes
        {
            get => _yes;
            private set => Set(ref _yes, value);
        }
    }
}