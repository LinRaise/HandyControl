using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace HandyControl.Properties.Langs
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public partial class Lang : INotifyPropertyChanged
    {
		private static void UpdateLang()
        {
			Instance.TooLarge = _ResourceSet.GetString("TooLarge");
			Instance.Interval30s = _ResourceSet.GetString("Interval30s");
			Instance.Interval30m = _ResourceSet.GetString("Interval30m");
			Instance.Interval10m = _ResourceSet.GetString("Interval10m");
			Instance.Cancel = _ResourceSet.GetString("Cancel");
			Instance.OutOfRange = _ResourceSet.GetString("OutOfRange");
			Instance.UnknownSize = _ResourceSet.GetString("UnknownSize");
			Instance.PngImg = _ResourceSet.GetString("PngImg");
			Instance.Unknown = _ResourceSet.GetString("Unknown");
			Instance.Confirm = _ResourceSet.GetString("Confirm");
			Instance.CloseOther = _ResourceSet.GetString("CloseOther");
			Instance.Am = _ResourceSet.GetString("Am");
			Instance.No = _ResourceSet.GetString("No");
			Instance.Pm = _ResourceSet.GetString("Pm");
			Instance.Tip = _ResourceSet.GetString("Tip");
			Instance.Yes = _ResourceSet.GetString("Yes");
			Instance.Close = _ResourceSet.GetString("Close");
			Instance.Clear = _ResourceSet.GetString("Clear");
			Instance.FormatError = _ResourceSet.GetString("FormatError");
			Instance.CloseAll = _ResourceSet.GetString("CloseAll");
			Instance.CannotRegisterSameCommandTwice = _ResourceSet.GetString("CannotRegisterSameCommandTwice");
			Instance.IsNecessary = _ResourceSet.GetString("IsNecessary");
			Instance.Interval1h = _ResourceSet.GetString("Interval1h");
			Instance.Interval1m = _ResourceSet.GetString("Interval1m");
			Instance.Interval2h = _ResourceSet.GetString("Interval2h");
			Instance.Interval5m = _ResourceSet.GetString("Interval5m");
			Instance.CannotRegisterCompositeCommandInItself = _ResourceSet.GetString("CannotRegisterCompositeCommandInItself");
			Instance.ErrorImgPath = _ResourceSet.GetString("ErrorImgPath");
			Instance.ErrorImgSize = _ResourceSet.GetString("ErrorImgSize");
        }
		
		private string _TooLarge = "过大";

		/// <summary>
        ///   查找类似 过大 的本地化字符串。
        /// </summary>
        public string TooLarge
        {
            get => _TooLarge;
            set => Set(ref _TooLarge, value);
        }

		private string _Interval30s = "间隔30秒";

		/// <summary>
        ///   查找类似 间隔30秒 的本地化字符串。
        /// </summary>
        public string Interval30s
        {
            get => _Interval30s;
            set => Set(ref _Interval30s, value);
        }

		private string _Interval30m = "间隔30分钟";

		/// <summary>
        ///   查找类似 间隔30分钟 的本地化字符串。
        /// </summary>
        public string Interval30m
        {
            get => _Interval30m;
            set => Set(ref _Interval30m, value);
        }

		private string _Interval10m = "间隔10分钟";

		/// <summary>
        ///   查找类似 间隔10分钟 的本地化字符串。
        /// </summary>
        public string Interval10m
        {
            get => _Interval10m;
            set => Set(ref _Interval10m, value);
        }

		private string _Cancel = "取消";

		/// <summary>
        ///   查找类似 取消 的本地化字符串。
        /// </summary>
        public string Cancel
        {
            get => _Cancel;
            set => Set(ref _Cancel, value);
        }

		private string _OutOfRange = "不在范围内";

		/// <summary>
        ///   查找类似 不在范围内 的本地化字符串。
        /// </summary>
        public string OutOfRange
        {
            get => _OutOfRange;
            set => Set(ref _OutOfRange, value);
        }

		private string _UnknownSize = "未知大小";

		/// <summary>
        ///   查找类似 未知大小 的本地化字符串。
        /// </summary>
        public string UnknownSize
        {
            get => _UnknownSize;
            set => Set(ref _UnknownSize, value);
        }

		private string _PngImg = "PNG图片";

		/// <summary>
        ///   查找类似 PNG图片 的本地化字符串。
        /// </summary>
        public string PngImg
        {
            get => _PngImg;
            set => Set(ref _PngImg, value);
        }

		private string _Unknown = "未知";

		/// <summary>
        ///   查找类似 未知 的本地化字符串。
        /// </summary>
        public string Unknown
        {
            get => _Unknown;
            set => Set(ref _Unknown, value);
        }

		private string _Confirm = "确定";

		/// <summary>
        ///   查找类似 确定 的本地化字符串。
        /// </summary>
        public string Confirm
        {
            get => _Confirm;
            set => Set(ref _Confirm, value);
        }

		private string _CloseOther = "关闭其他";

		/// <summary>
        ///   查找类似 关闭其他 的本地化字符串。
        /// </summary>
        public string CloseOther
        {
            get => _CloseOther;
            set => Set(ref _CloseOther, value);
        }

		private string _Am = "上午";

		/// <summary>
        ///   查找类似 上午 的本地化字符串。
        /// </summary>
        public string Am
        {
            get => _Am;
            set => Set(ref _Am, value);
        }

		private string _No = "否";

		/// <summary>
        ///   查找类似 否 的本地化字符串。
        /// </summary>
        public string No
        {
            get => _No;
            set => Set(ref _No, value);
        }

		private string _Pm = "下午";

		/// <summary>
        ///   查找类似 下午 的本地化字符串。
        /// </summary>
        public string Pm
        {
            get => _Pm;
            set => Set(ref _Pm, value);
        }

		private string _Tip = "提示";

		/// <summary>
        ///   查找类似 提示 的本地化字符串。
        /// </summary>
        public string Tip
        {
            get => _Tip;
            set => Set(ref _Tip, value);
        }

		private string _Yes = "是";

		/// <summary>
        ///   查找类似 是 的本地化字符串。
        /// </summary>
        public string Yes
        {
            get => _Yes;
            set => Set(ref _Yes, value);
        }

		private string _Close = "关闭";

		/// <summary>
        ///   查找类似 关闭 的本地化字符串。
        /// </summary>
        public string Close
        {
            get => _Close;
            set => Set(ref _Close, value);
        }

		private string _Clear = "清空";

		/// <summary>
        ///   查找类似 清空 的本地化字符串。
        /// </summary>
        public string Clear
        {
            get => _Clear;
            set => Set(ref _Clear, value);
        }

		private string _FormatError = "格式错误";

		/// <summary>
        ///   查找类似 格式错误 的本地化字符串。
        /// </summary>
        public string FormatError
        {
            get => _FormatError;
            set => Set(ref _FormatError, value);
        }

		private string _CloseAll = "关闭所有";

		/// <summary>
        ///   查找类似 关闭所有 的本地化字符串。
        /// </summary>
        public string CloseAll
        {
            get => _CloseAll;
            set => Set(ref _CloseAll, value);
        }

		private string _CannotRegisterSameCommandTwice = "不能注册同一命令两次";

		/// <summary>
        ///   查找类似 不能注册同一命令两次 的本地化字符串。
        /// </summary>
        public string CannotRegisterSameCommandTwice
        {
            get => _CannotRegisterSameCommandTwice;
            set => Set(ref _CannotRegisterSameCommandTwice, value);
        }

		private string _IsNecessary = "不能为空";

		/// <summary>
        ///   查找类似 不能为空 的本地化字符串。
        /// </summary>
        public string IsNecessary
        {
            get => _IsNecessary;
            set => Set(ref _IsNecessary, value);
        }

		private string _Interval1h = "间隔1小时";

		/// <summary>
        ///   查找类似 间隔1小时 的本地化字符串。
        /// </summary>
        public string Interval1h
        {
            get => _Interval1h;
            set => Set(ref _Interval1h, value);
        }

		private string _Interval1m = "间隔1分钟";

		/// <summary>
        ///   查找类似 间隔1分钟 的本地化字符串。
        /// </summary>
        public string Interval1m
        {
            get => _Interval1m;
            set => Set(ref _Interval1m, value);
        }

		private string _Interval2h = "间隔2小时";

		/// <summary>
        ///   查找类似 间隔2小时 的本地化字符串。
        /// </summary>
        public string Interval2h
        {
            get => _Interval2h;
            set => Set(ref _Interval2h, value);
        }

		private string _Interval5m = "间隔5分钟";

		/// <summary>
        ///   查找类似 间隔5分钟 的本地化字符串。
        /// </summary>
        public string Interval5m
        {
            get => _Interval5m;
            set => Set(ref _Interval5m, value);
        }

		private string _CannotRegisterCompositeCommandInItself = "无法自注册复合命令";

		/// <summary>
        ///   查找类似 无法自注册复合命令 的本地化字符串。
        /// </summary>
        public string CannotRegisterCompositeCommandInItself
        {
            get => _CannotRegisterCompositeCommandInItself;
            set => Set(ref _CannotRegisterCompositeCommandInItself, value);
        }

		private string _ErrorImgPath = "错误的图片路径！";

		/// <summary>
        ///   查找类似 错误的图片路径！ 的本地化字符串。
        /// </summary>
        public string ErrorImgPath
        {
            get => _ErrorImgPath;
            set => Set(ref _ErrorImgPath, value);
        }

		private string _ErrorImgSize = "非法的图片尺寸！";

		/// <summary>
        ///   查找类似 非法的图片尺寸！ 的本地化字符串。
        /// </summary>
        public string ErrorImgSize
        {
            get => _ErrorImgSize;
            set => Set(ref _ErrorImgSize, value);
        }
	}
}