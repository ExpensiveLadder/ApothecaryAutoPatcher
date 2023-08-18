using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;

namespace ApothecaryAutoPatcher
{
    public class Settings
    {
        [SettingName("Effects")]
        public List<Effect> Effects = new() {
            new(Skyrim.MagicEffect.AlchRestoreHealth, 0.96f, 10),
            new(Skyrim.MagicEffect.AlchRestoreStamina, 0.96f, 10),
            new(Skyrim.MagicEffect.AlchRestoreMagicka, 0.96f, 10),
            new(Skyrim.MagicEffect.AlchFortifyHealth, 2.67f, 300),
            new(Skyrim.MagicEffect.AlchFortifyStamina, 2.67f, 300),
            new(Skyrim.MagicEffect.AlchFortifyMagicka, 2.67f, 300),
            new(Skyrim.MagicEffect.AlchFortifyHealRate, 2.67f, 300),
            new(Skyrim.MagicEffect.AlchFortifyStaminaRate, 2.67f, 300),
            new(Skyrim.MagicEffect.AlchFortifyMagickaRate, 2.67f, 300),
            new(Skyrim.MagicEffect.AlchFortifyAlteration, 6.67f, 60),
            new(Skyrim.MagicEffect.AlchFortifyConjuration, 6.67f, 60),
            new(Skyrim.MagicEffect.AlchFortifyDestruction, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyRestoration, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyIllusion, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifySneak, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyAlchemy, 3.33f, 60), //MAG_AlchFortifySneakAttacks
            new(Skyrim.MagicEffect.AlchFortifyLockpicking, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyPickpocket, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifySmithing, 3.33f, 60), //MAG_AlchFortifyUnarmed
            new(Skyrim.MagicEffect.AlchFortifyEnchanting, 3.33f, 60), //MAG_AlchFortifyPowerAttacks
            new(Skyrim.MagicEffect.AlchFortifyHeavyArmor, 3.33f, 60), //MAG_AlchFortifyShouts
            new(Skyrim.MagicEffect.AlchFortifyOneHanded, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyTwoHanded, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyMarksman, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyBlock, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchFortifyLightArmor, 6.67f, 300), //MAG_AlchFortifyArmorRating
            new(Skyrim.MagicEffect.AlchFortifyCarryWeight, 6.67f, 300),
            new(Skyrim.MagicEffect.AlchFortifyBarter, 1.33f, 300),
            new(Skyrim.MagicEffect.AlchResistFire, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchResistFrost, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchResistShock, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchResistPoison, 3.33f, 60),
            new(Skyrim.MagicEffect.AlchResistMagic, 1.67f, 300),
            new(Skyrim.MagicEffect.AlchInvisibillity, 0f, 4),
            new(Skyrim.MagicEffect.AlchWaterbreathing, 0f, 4),
            new(Skyrim.MagicEffect.AlchCureDisease, 1f, 0),
            new(Skyrim.MagicEffect.AlchWeaknessFire, 6.66f, 60),
            new(Skyrim.MagicEffect.AlchWeaknessFrost, 6.66f, 60),
            new(Skyrim.MagicEffect.AlchWeaknessShock, 6.66f, 60),
            new(Skyrim.MagicEffect.AlchWeaknessPoison, 6.66f, 60),
            new(Skyrim.MagicEffect.AlchWeaknessMagic, 2.67f, 60), //MAG_AlchReflectDamage
            new(Skyrim.MagicEffect.AlchParalysis, 3.33f, 10),
            new(Skyrim.MagicEffect.AlchDamageHealth, 0.44f, 10),
            new(Skyrim.MagicEffect.AlchDamageStamina, 0.88f, 10),
            new(Skyrim.MagicEffect.AlchDamageMagicka, 0.88f, 10),
            new(Skyrim.MagicEffect.AlchDamageHealthDuration, 0.27f, 30),
            new(Skyrim.MagicEffect.AlchDamageStaminaDuration, 0.52f, 30),
            new(Skyrim.MagicEffect.AlchDamageStaminaRate, 3.33f, 30), //MAG_AlchCommand
            new(Skyrim.MagicEffect.AlchDamageMagickaRate, 3.33f, 30), //MAG_AlchSilence
            new(Skyrim.MagicEffect.AlchDamageHealthRavage, 3.33f, 60), //MAG_AlchDamageWeapon
            new(Skyrim.MagicEffect.AlchDamageStaminaRavage, 3.33f, 30), //MAG_AlchCalm
            new(Skyrim.MagicEffect.AlchDamageMagickaRavage, 19.950001f, 60), //MAG_AlchDamageArmor
            new(Skyrim.MagicEffect.AlchDamageSpeed, 3.33f, 60), //MAG_AlchBurden
            new(Skyrim.MagicEffect.AlchInfluenceConfDown, 3.33f, 30),
            new(Skyrim.MagicEffect.AlchInfluenceAggUp, 3.33f, 30),
        };

        public List<FormLink<IIngredientGetter>> Blacklist = new()
        {
            Skyrim.Ingredient.DBJarrinRoot
        };
    }

    public class Effect
    {
        public Effect(FormLinkGetter<IMagicEffectGetter> BaseEffect, float Magnitude, int Duration)
        {
            this.BaseEffect = BaseEffect;
            this.Magnitude = Magnitude;
            this.Duration = Duration;
        }
        public FormLinkGetter<IMagicEffectGetter> BaseEffect;
        public int Duration;
        public float Magnitude;
    }

    public class Program
    {
        static Lazy<Settings> Settings = null!;

        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .SetAutogeneratedSettings(
                    nickname: "Settings",
                    path: "settings.json",
                    out Settings)
                .SetTypicalOpen(GameRelease.SkyrimSE, "YourPatcher.esp")
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            //Your code here!

            foreach (var ingredientGetter in state.LoadOrder.PriorityOrder.Ingredient().WinningOverrides())
            {
                if (Settings.Value.Blacklist.Contains(ingredientGetter.ToLink())) continue;
                var ingredientoverride = ingredientGetter.DeepCopy();
                var overridden = false;
                foreach (var effect in ingredientoverride.Effects)
                {
                    if (effect.Data == null) continue;
                    foreach (var effectInfo in Settings.Value.Effects)
                    {
                        if (effect.BaseEffect.FormKey == effectInfo.BaseEffect.FormKey)
                        {
                            if (effect.Data.Magnitude != effectInfo.Magnitude || effect.Data.Duration != effectInfo.Duration)
                            {
                                effect.Data.Magnitude = effectInfo.Magnitude;
                                effect.Data.Duration = effectInfo.Duration;
                                overridden = true;
                            }
                        }
                    }
                }
                if (overridden)
                {
                    state.PatchMod.Ingredients.Set(ingredientoverride);
                    Console.WriteLine(ingredientoverride.EditorID);
                }
            }
        }
    }
}
