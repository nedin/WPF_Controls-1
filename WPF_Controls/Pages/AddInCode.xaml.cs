﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControls.Pages {
	/// <summary>
	/// Interaction logic for AddInCode.xaml
	/// </summary>
	public partial class AddInCode : Page {
		public AddInCode() {
			InitializeComponent();

			// Don't attempt to access the elements before the call
			// to InitializeComponent.  The elements have not been properly
			// initialized yet.
		}
	}
}