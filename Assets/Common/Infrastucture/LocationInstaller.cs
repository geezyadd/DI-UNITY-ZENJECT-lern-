using UnityEngine;
using Zenject;

namespace Assets.Common.Infrastucture
{
    public class LocationInstaller : MonoInstaller
    {
        public Transform StartPoint;
        public GameObject PrinterPrefab;
        public GameObject PrintIfKeyKode;
        public GameObject Ground; 
        public override void InstallBindings()
        {
            PrinterServiceBinding();
            PrinterBinding();
            GroundBinding();
        }

        private void GroundBinding()
        {
            Ground InstantiatePrefabForComponen = Container
                                        .InstantiatePrefabForComponent<Ground>(Ground, StartPoint.position, Quaternion.identity, null);

            Container
                .Bind<Ground>()
                .FromInstance(InstantiatePrefabForComponen)
                .AsSingle();
        }

        private void PrinterBinding()
        {
            PrintEIfKeyKodeEEEE InstantiatePrefabForComponen = Container
                            .InstantiatePrefabForComponent<PrintEIfKeyKodeEEEE>(PrintIfKeyKode, StartPoint.position, Quaternion.identity, null);

            Container
                .Bind<PrintEIfKeyKodeEEEE>()
                .FromInstance(InstantiatePrefabForComponen)
                .AsSingle();
        }

        private void PrinterServiceBinding()
        {
            PrintEeeeee InstantiatePrefabForComponen = Container
                            .InstantiatePrefabForComponent<PrintEeeeee>(PrinterPrefab, StartPoint.position, Quaternion.identity, null);

            Container
                .Bind<PrintEeeeee>()
                .FromInstance(InstantiatePrefabForComponen)
                .AsSingle();
        }
    }
}