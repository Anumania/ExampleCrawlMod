using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrawlAPI;
using UnityEngine;
using System.IO;


namespace ExampleCrawlMod
{

    [BepInPlugin("org.anumania.plugins.exampleMod", "Example Mod", "1.0.0.0")]
    public class ExampleMod : BaseUnityPlugin
    {
        [CrawlPlugin]
        public void Start()
        {
            try
            {
                //binted example for loading sprites and using them as animations. this setup will be replaced by some helper functions
                //soon, but this is how i got custom sprites working on a monster.
                /*
                exAtlas modAtlas = ScriptableObject.CreateInstance<exAtlas>();
                Texture2D modAtlasTexture = new Texture2D(2048, 2048);
                byte[] array2 = File.ReadAllBytes("./Crawl_Textures/test.png");
                modAtlasTexture.LoadImage(array2);
                Console.WriteLine("loaded!");
                modAtlas.name = "modAtlasTexture";
                modAtlas.texture = modAtlasTexture;
                modAtlas.elements = new exAtlas.Element[1];
                modAtlas.elements[0] = new exAtlas.Element();
                modAtlas.elements[0].name = "test";
                modAtlas.elements[0].coords = new Rect(0, 0, 4, 4);
                modAtlas.elements[0].originalHeight = 64;
                modAtlas.elements[0].originalWidth = 64;
                modAtlas.elements[0].trimRect = new Rect(0, 0, 31, 31);
                CustomMonster monst = new CustomMonster();
                monst.SetToDefaults();
                Material matt = monst.m_animationIdle.frameInfos[0].atlas.material;
                Material matthew = new Material(matt);
                matthew.mainTexture = modAtlas.texture;
                foreach (exAtlas mat in Resources.FindObjectsOfTypeAll(typeof(exAtlas)))
                {
                    if (mat.name == "AtlasMonsters")
                    {

                        //mat.SetTexture(name)

                        //Console.WriteLine("A");
                        //monst.m_animationIdle.frameInfos[0].atlas.material = mat;
                        //mat.mainTexture = modAtlasTexture;
                    }
                }
                monst.m_animationIdle.frameInfos[0].atlas = modAtlas;
                monst.m_animationIdle.frameInfos[0].index = 0;
                monst.m_animationIdle.frameInfos[0].atlas.material = matthew;

                monst.m_animationIdle.frameInfos[0].atlas.texture = modAtlasTexture;
                */
                CustomDeity testman = new CustomDeity(); //entirely blank custom deity
                testman.SetToDefaults(); //sets all fields to that of the first deity
                testman.m_name = "Greg";
                testman.m_textFlavour = "Bow before greg";
                testman.m_text = "this is my description";

                CustomMonster testMonster = new CustomMonster(); //entirely blank custom monster
                testMonster.SetToDefaults(); //sets everything to that of the "ghoul" enemy, and sets all evolves to gnomes

                testman.AddMonster(testMonster, 0); //you can either add custom monsters to custom deities

                //SystemDeity.GetDeity(1).AddMonster(testMonster, 0); //or real ones. (this will overwrite monsters) 

                DeityAPI.AddDeity(testman); //add the deity (and monsters) to the mod deities menu
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
    


