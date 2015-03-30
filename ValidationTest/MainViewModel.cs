﻿using FluentValidation;
//using PropertyChanged;
using System.ComponentModel;

namespace ValidationTest
{
	//[ImplementPropertyChanged]
	public class MainViewModel : ViewModelBase<MainViewModel>
	{
		public DelegateCommand Save { get; private set; }

		public MainViewModel (IValidator<MainViewModel> validator) : base(validator)
		{
			this.Save = new DelegateCommand (OnSave, Validate);
			this.PropertyChanged += (sender, e) => {
				if (e != null) {
					this.Save.RaiseCanExecuteChanged();
				}
			};
		}

		public void OnSave()
		{
			var x = "";
		}

		int _age;
		public int Age {
			get {
				return _age;
			}
			set {
				if (_age != value) {
					_age = value;
					RaisePropertyChanged ();
				}
			}
		}
		bool _isAgreementAccepted;
		public bool IsAgreementAccepted {
			get {
				return _isAgreementAccepted;
			}
			set {
				if (_isAgreementAccepted != value) {
					_isAgreementAccepted = value;
					RaisePropertyChanged ();
				}
			}
		}
		string _emailAddress;
		public string EmailAddress {
			get {
				return _emailAddress;
			}
			set {
				if (_emailAddress != value) {
					_emailAddress = value;
					RaisePropertyChanged ();
				}
			}
		}


	}
}