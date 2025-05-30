private async void OnAddTaskClicked(object sender, EventArgs e)
{
    await Navigation.PushAsync(new TaskPage());
}

private async void OnTaskSelected(object sender, SelectedItemChangedEventArgs e)
{
    if (e.SelectedItem != null)
        await Navigation.PushAsync(new TaskPage((TaskItem)e.SelectedItem));
}
