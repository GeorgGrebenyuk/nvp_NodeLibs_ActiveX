﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;


namespace NVP_nanoCAD_Platform_NET._Application.Database
{

    [NVP_Manifest(
        Text = "Инициализирует Базу данных модели nanoCAD",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("dynamic", typeof(object))]
    public class Database_Constructor : INode
    {
        public IntPtr _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            _o = (_input0 as Teigha.DatabaseServices.Database).UnmanagedObject;

            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает имя документа или его полный файловый путь сохранения",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Database", typeof(object))]
    public class Get_Filename : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            Teigha.DatabaseServices.Database db = (Teigha.DatabaseServices.Database)_input0._o;

            Teigha.DatabaseServices.BlockTableRecord bl;

            return new NodeResult(db.Filename);
        }
    }


}
