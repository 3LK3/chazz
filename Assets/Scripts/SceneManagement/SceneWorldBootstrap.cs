using Elke.Entities.Utility;
using Unity.Entities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chazz.SceneManagement
{
#if UNITY_DISABLE_AUTOMATIC_SYSTEM_BOOTSTRAP_RUNTIME_WORLD
    /// <summary>
    /// We create the corresponding entities world before a unity scene is loaded.
    /// The initialization process of the world is handled by the CustomBootstrap.
    /// </summary>
    public static class SceneWorldBootstrap
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize() => DefaultWorldInitialization.Initialize(SceneManager.GetActiveScene().name);
    }
#endif

    /// <summary>
    /// The custom bootstrapper creates a custom world with specific systems each
    /// time a default world is initialized (except for editor worlds).
    /// </summary>
    public class CustomBootstrap : ICustomBootstrap
    {
        public bool Initialize(string defaultWorldName)
        {
            CreateInWorldInitialization.Initialize(defaultWorldName);
            return true;
        }
    }
}
