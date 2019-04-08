using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace HandyControl.Properties.Langs
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public partial class Lang
    {
        private static string CurrentCultureName;

        private static ResourceSet _ResourceSet;

        private static ResourceSet ResourceSet
        {
            set
            {
                _ResourceSet = value;
                UpdateLang();
            }
        }

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

        private Lang()
        {
            
        }

        public static void UpdateLang(CultureInfo culture)
        {
            if (Equals(CurrentCultureName, culture.Name)) return;
            CurrentCultureName = culture.Name;
            ResourceSet = ResourceManager.GetResourceSet(culture, true, true);
        }

        private static ResourceManager ResourceManager { get; } = new Lazy<ResourceManager>(() =>
            new ResourceManager("HandyControl.Properties.Langs.Lang", typeof(Lang).Assembly)).Value;

        public static Lang Instance { get; } = new Lazy<Lang>(() => new Lang()).Value;

        public static Lang GetInstance() => Instance;        
    }
}