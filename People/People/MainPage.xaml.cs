﻿using People.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace People;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    public async void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        await App.PersonRepo.AddNewPersonAsync(newPerson.Text);
        statusMessage.Text = App.PersonRepo.StatusMessage;
    }

    public async void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Person> people = await App.PersonRepo.GetAllPeopleAsync();
        peopleList.ItemsSource = people;
    }

}

