public static TaskDatabase Database { get; private set; }
public App(string dbPath)
{
    InitializeComponent();
    Database = new TaskDatabase(dbPath);
    MainPage = new NavigationPage(new MainPage());
}
