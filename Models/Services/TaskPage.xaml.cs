private async void OnSaveClicked(object sender, EventArgs e)
{
    try
    {
        var task = (TaskItem)BindingContext;
        await App.Database.SaveTaskAsync(task);
        await Navigation.PopAsync();
    }
    catch (Exception ex)
    {
        await DisplayAlert("Error", "No se pudo guardar la tarea: " + ex.Message, "OK");
    }
}

private async void OnDeleteClicked(object sender, EventArgs e)
{
    var task = (TaskItem)BindingContext;
    await App.Database.DeleteTaskAsync(task);
    await Navigation.PopAsync();
}
