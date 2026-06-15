using UnityEngine;

public static class Bootstrapper
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        var bootstrapSettings = BootstrapSetting.Instance;
        if (bootstrapSettings == null)
            return;

        foreach (var entry in bootstrapSettings.Entries)
        {
            var obj = Object.Instantiate(entry.Prefab);

            if (entry.DontDestroyOnLoad)
            {
                Object.DontDestroyOnLoad(obj);
            }
        }
    }
}
