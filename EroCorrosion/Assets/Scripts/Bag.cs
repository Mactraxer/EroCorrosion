using System.Collections.Generic;

public class Bag
{
    private BagModel _model;
    private List<ResourceModel> _resources;
    private BagUI _view;

    public Bag(BagModel model, BagUI view)
    {
        _model = model;
        _resources = new List<ResourceModel>();
        _view = view;
    }

    public List<ResourceModel> UploadResources()
    {
        List<ResourceModel> uploadedResources = _resources;
        
        _resources = new List<ResourceModel>();
        _view.UpdateView(_resources.Count, _model.Capacity);
        return uploadedResources;
    }

    public void TryAddResouces(int blockCount, ResourceModel resource)
    {
        if (_resources.Count >= _model.Capacity) return;

        if (blockCount + _resources.Count > _model.Capacity)
        {
            AddResources(_model.Capacity - _resources.Count, resource);
        }

        AddResources(blockCount, resource);
    }

    private void AddResources(int count, ResourceModel resource)
    {
        for (int i = 0; i < count; i++)
        {
            _resources.Add(resource);
        }

        _view.UpdateView(_resources.Count, _model.Capacity);
    }
}