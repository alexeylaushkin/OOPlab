using KLADobj.ApplicationServices.GetFreeListUseCase;
using KLADobj.ApplicationServices.Ports;
using KLADobj.DomainObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace KLADobj.DesktopClient.InfrastructureServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IGetKLADobjListUseCase _getKLADobjListUseCase;

        public MainViewModel(IGetKLADobjListUseCase getKLADobjListUseCase)
            => _getKLADobjListUseCase = getKLADobjListUseCase;

        private Task<bool> _loadingTask;
        private kladobj _currentKLADobj;
        private ObservableCollection<kladobj> _kladobjs;

        public event PropertyChangedEventHandler PropertyChanged;

        public kladobj CurrentKLADobj
        {
            get => _currentKLADobj; 
            set
            {
                if (_currentKLADobj != value)
                {
                    _currentKLADobj = value;
                    OnPropertyChanged(nameof(CurrentKLADobj));
                }
            }
        }

        private async Task<bool> LoadKLADobjs()
        {
            var outputPort = new OutputPort();
            bool result = await _getKLADobjListUseCase.Handle(GetKLADobjListUseCaseRequest.CreateAllKLADobjsRequest(), outputPort);
            if (result)
            {
                KLADobjs = new ObservableCollection<kladobj>(outputPort.KLADobjs);
            }
            return result;
        }

        public ObservableCollection<kladobj> KLADobjs
        {
            get 
            {
                if (_loadingTask == null)
                {
                    _loadingTask = LoadKLADobjs();
                }
                
                return _kladobjs; 
            }
            set
            {
                if (_kladobjs != value)
                {
                    _kladobjs = value;
                    OnPropertyChanged(nameof(KLADobjs));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class OutputPort : IOutputPort<GetKLADobjListUseCaseResponse>
        {
            public IEnumerable<kladobj> KLADobjs { get; private set; }

            public void Handle(GetKLADobjListUseCaseResponse response)
            {
                if (response.Success)
                {
                    KLADobjs = new ObservableCollection<kladobj>(response.KLADobjs);
                }
            }
        }
    }
}
