using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_PET.Models;
using CRUD_PET.Views;

namespace CRUD_PET.Presenters
{
    public class PetPresenter
    {
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += EditPet;
            this.view.DeleteEvent += DeletePet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            this.view.SetPetListBindingSource(petsBindingSource);

            LoadAllPetList();
        }

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeletePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
