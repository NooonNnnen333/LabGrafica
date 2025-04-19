using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace lab2;

public partial class ViewModel : ObservableObject
{
    // Храним выбранный пункт из Picker
    [ObservableProperty]
    private string stroka;

    // Список вариантов для Picker
    public List<string> Options { get; } = new()
    {
        "Квадрат", 
        "Круг", 
        "Прямоугольник"
    };

    // Текст, который вводим в Entry
    [ObservableProperty]
    private string line;

    [ObservableProperty]
    private string vivod;

    // Динамический список, отображаемый в CollectionView
    [ObservableProperty]
    private ObservableCollection<string> linesMassive;

    public ViewModel()
    {
        // Изначальное состояние
        LinesMassive = new ObservableCollection<string> { };
    }

    // Команда, вызываемая при нажатии на кнопку
    [RelayCommand]
    private void AddLine(string newline)
    {
        if (!string.IsNullOrWhiteSpace(newline))
        {
            LinesMassive.Add(newline);
            Line = ""; // Очищаем поле после добавления
        }
    }

    [RelayCommand]
    private void Iform()
    {
        Vivod = $"Тип линии:\t{Stroka}\nВид геометрической фигуры:\t{LinesMassive[LinesMassive.Count-1].ToString()}";
    }
    
}