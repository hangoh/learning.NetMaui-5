using System;
namespace BMI.MVVM.ViewModel
{
	public class BmiViewModel
	{

		public Model.BMI BMI { get; set; }
		public BmiViewModel()
		{
			BMI = new Model.BMI();
			BMI.Height = 171;
			BMI.Weight = 51;
		}
	}
}

