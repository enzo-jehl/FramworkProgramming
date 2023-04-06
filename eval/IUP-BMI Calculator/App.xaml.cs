using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
    public BMIResultRepository BMIResultRepo { get; set; }
    // TODO
    public App(string path)
	{
		InitializeComponent();

		MainPage = new AppShell();


        BMIResultRepo = new BMIResultRepository(path);

    }
}
