﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a special Block object containing all the entities in the active paper space layout
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadPaperSpace 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPaperSpace_Constructor : INode 
	{
		public OdaX.IAcadPaperSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPaperSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPaperSpace_ConstructorCast : INode 
	{
		public OdaX.IAcadPaperSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPaperSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Adds a paperspace viewport to paperspace.", 
		ViewType = "Data")]
	[NodeInput("AcadPaperSpace", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Adds a paperspace viewport to paperspace.
	///</summary>
	public class AddPViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPViewport(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
