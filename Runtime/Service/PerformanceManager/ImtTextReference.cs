﻿// zlib/libpng License
//
// Copyright (c) 2020 Sinoa
//
// This software is provided 'as-is', without any express or implied warranty.
// In no event will the authors be held liable for any damages arising from the use of this software.
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it freely,
// subject to the following restrictions:
//
// 1. The origin of this software must not be misrepresented; you must not claim that you wrote the original software.
//    If you use this software in a product, an acknowledgment in the product documentation would be appreciated but is not required.
// 2. Altered source versions must be plainly marked as such, and must not be misrepresented as being the original software.
// 3. This notice may not be removed or altered from any source distribution.

using System;
using System.Dynamic;
using UnityEngine;

namespace IceMilkTea.Service
{
    public class ImtTextReference
    {
        private Action<string> resetCallback;
        private string text;


        public string Text { get => text; set => SetText(value); }
        public Color Color = Color.white;
        public float Size = 10.0f;
        public Vector2 Position = Vector2.zero;



        public ImtTextReference(Action<string> resetCallback)
        {
            this.resetCallback = resetCallback;
        }


        private void SetText(string value)
        {
            text = value;
            resetCallback(value);
        }
    }
}