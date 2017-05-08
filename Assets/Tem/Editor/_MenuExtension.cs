﻿using UnityEngine;
using UnityEditor;

#if UNITY_5_3_OR_NEWER
using UnityEditor.SceneManagement;
#endif

using System.Collections;

using Tem;

namespace Tem {

    public class MenuExtension : EditorWindow {
        
        [MenuItem ("Tools/Tem/New Scene", false, -100)]
        private static void NewScene(){
            CreateEmptyScene();

            GameObject obj = (GameObject)Instantiate(Resources.Load("Prefabs/default", typeof(GameObject)));
            obj.name = "default";
        }

        static void CreateEmptyScene() {
            #if UNITY_5_3_OR_NEWER
            EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects);
            #else
            EditorApplication.NewScene();
            #endif
        }



        [MenuItem("Tools/Tem/ Editor 01", false, 10)]
        static void OpenEditor01() {
            WeaponEditorWindow.Init();
        }

    }
}