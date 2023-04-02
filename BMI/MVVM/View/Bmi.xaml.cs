using BMI.MVVM.ViewModel;

namespace BMI.MVVM.View;

public partial class Bmi : ContentPage
{
	public Bmi()
	{
		InitializeComponent();
		BindingContext = new BmiViewModel();
	}
}
