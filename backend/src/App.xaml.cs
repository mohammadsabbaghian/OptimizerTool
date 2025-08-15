using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

public partial class App : Application
{
    public App()
    {
        // Subscribe to unhandled exception events
        AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
        TaskScheduler.UnobservedTaskException += OnUnobservedTaskException;

        InitializeComponent();
        MainPage = new MainPage();
    }

    private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        // Log or display the exception
        Exception ex = e.ExceptionObject as Exception;
        // You can log to file, show a dialog, etc.
    }

    private void OnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
    {
        // Log or display the exception
        Exception ex = e.Exception;
        // You can log to file, show a dialog, etc.
        e.SetObserved();
    }
}