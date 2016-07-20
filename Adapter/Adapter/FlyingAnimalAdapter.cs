namespace Adapter
{
    public class FlyingAnimalAdapter : IActionAdapter
    {
        private IFlyable _animal;

        public FlyingAnimalAdapter(IFlyable animal)
        {
            _animal = animal;
        }

        public string DoAction() => _animal.Fly();
    }

}
