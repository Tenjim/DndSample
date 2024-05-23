using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Microsoft.Extensions.DependencyInjection;


namespace DndSample;

public class ViewModelLocator
{
    public static IServiceProvider ServiceProvider;

    private T GetViewModel<T>() where T : IViewModel
    {
        var viewModel = ServiceProvider.GetRequiredService<T>();
        return viewModel;
    }

    private static ViewModelLocator _viewModelLocator;
    
    
   
    public DragAndDropPageViewModel DragAndDropPageViewModel => GetViewModel<DragAndDropPageViewModel>();

}