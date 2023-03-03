using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class activity5 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();

		public ObservableCollection<employee> Employees { get { return employees; } }
		public activity5 ()
		{
			InitializeComponent ();

			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName = "Boobeh", Position = "President", profileImage ="a.png" });
                employees.Add(new employee { DisplayName = "Ollej Pangit", Position = "Vice President", profileImage = "b.png" });
                employees.Add(new employee { DisplayName = "Sid Pogi", Position = "Secretary", profileImage = "https://media.tenor.com/gQV5VzHLWQIAAAAC/among-us-sus.gif" });
            }
		}
	}
}