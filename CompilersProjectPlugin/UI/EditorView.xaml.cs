using ControlScriptLanguage;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CompilersProject.UI
{
    /// <summary>
    /// Представляет собой окно редактора плагина.
    /// </summary>
    public partial class EditorView : UserControl, INotifyPropertyChanged
    {
        private Plugin plugin;
        
        internal EditorView(Plugin plugin)
        {
            this.plugin = plugin;
            InitializeComponent();
        }

        public string OscFrequencyScriptText
        {
            get => Routing.OscFrequencyScriptText;
            set
            {
                if (OscFrequencyScriptText != value)
                {
                    Routing.OscFrequencyScriptText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string FilterCutoffScriptText
        {
            get => Routing.FilterCutoffScriptText;
            set
            {
                if (FilterCutoffScriptText != value)
                {
                    Routing.FilterCutoffScriptText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string FilterResonanceScriptText
        {
            get => Routing.FilterResonanceScriptText;
            set
            {
                if (FilterResonanceScriptText != value)
                {
                    Routing.FilterResonanceScriptText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string AmplitudeScriptText
        {
            get => Routing.AmplitudeScriptText;
            set
            {
                if (AmplitudeScriptText != value)
                {
                    Routing.AmplitudeScriptText = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                DefaultExt = ".cscript",
                Title = "Открытие"
            };
            
            Action<string> textSetter = null;

            switch (scriptTabs.SelectedIndex)
            {
                case 0:
                    dialog.Title += " скрипта частоты генератора...";
                    textSetter = (x) => OscFrequencyScriptText = x;
                    break;
                case 1:
                    dialog.Title += " скрипта частоты среза фильтра...";
                    textSetter = (x) => FilterCutoffScriptText = x;
                    break;
                case 2:
                    dialog.Title += " скрипта резонанса фильтра...";
                    textSetter = (x) => FilterResonanceScriptText = x;
                    break;
                case 3:
                    dialog.Title += " скрипта амплитуды...";
                    textSetter = (x) => AmplitudeScriptText = x;
                    break;
            }

            if (dialog.ShowDialog() == true)
            {
                var text = File.ReadAllText(dialog.FileName);
                textSetter(text);
            }
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog()
            {
                DefaultExt = ".cscript",
                Filter = "script|*.cscript",
                Title = "Сохранение",
            };

            string text = null;

            switch (scriptTabs.SelectedIndex)
            {
                case 0:
                    dialog.Title += " скрипта частоты генератора...";
                    text = OscFrequencyScriptText;
                    break;
                case 1:
                    dialog.Title += " скрипта частоты среза фильтра...";
                    text = FilterCutoffScriptText;
                    break;
                case 2:
                    dialog.Title += " скрипта резонанса фильтра...";
                    text = FilterResonanceScriptText;
                    break;
                case 3:
                    dialog.Title += " скрипта амплитуды...";
                    text = AmplitudeScriptText;
                    break;
            }

            if (dialog.ShowDialog() == true)
                File.WriteAllText(dialog.FileName, text);
        }

        private void CompileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (scriptTabs.SelectedIndex)
                {
                    case 0:
                        var factory = ControlScriptCompiler.Compile(OscFrequencyScriptText);
                        plugin.AudioProcessor.Routing.OscAFrequencyScript = factory.GetScript();
                        break;
                    case 1:
                        var scriptFactory = ControlScriptCompiler.Compile(FilterCutoffScriptText);
                        plugin.AudioProcessor.Routing.FilterCutoffScript = scriptFactory.GetScript();
                        break;
                    case 2:
                        scriptFactory = ControlScriptCompiler.Compile(FilterResonanceScriptText);
                        plugin.AudioProcessor.Routing.FilterResonanceScript = scriptFactory.GetScript();
                        break;
                    case 3:
                        scriptFactory = ControlScriptCompiler.Compile(AmplitudeScriptText);
                        plugin.AudioProcessor.Routing.AmplitudeScript = scriptFactory.GetScript();
                        break;
                }
            }
            catch (TranslatedCodeCompilationException)
            {
                MessageBox.Show("Произошли ошибки компиляции");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InformationMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программно управляемый синтезатор", "Информация", MessageBoxButton.YesNoCancel);
        }
    }
}
